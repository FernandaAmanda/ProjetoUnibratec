<?php
class Senha {
	public $senha = "";
	public $guiche  = "";
	public $estadoSenha = "";
}

class ajaxSenha {
	
	function listarSenhas() {
		/* Specify the server and connection string attributes. */
		$serverName = "localhost\sqlexpress";
		$connectionInfo = array (
				"Database" => "PocketQueue" 
		);
		
		/* Connect using Windows Authentication. */
		$conn = sqlsrv_connect ( $serverName, $connectionInfo );
		if ($conn === false) {
			echo "Unable to connect.</br>";
			die ( print_r ( sqlsrv_errors (), true ) );
		}
		
		$tsql = "Select top 1 * from Senha
		Where IDSenha = (select top 1 max(IDSenha) from Senha where EstadoSenha = 'Em Atendimento')
		UNION
		Select TOP 5 * From Senha
		Where IDSenha in (select top 5 IDSenha from Senha where EstadoSenha = 'Atendido' order by IDSenha desc)
		order by IDSenha desc";
		
		$json = array();
		$stmt = sqlsrv_query ( $conn, $tsql );
		if ($stmt === false) {
			echo "Error in executing query.</br>";
			die ( print_r ( sqlsrv_errors (), true ) );
		}
		
		while( $row = sqlsrv_fetch_array ( $stmt ) ) {
			$e = new Senha();
			$e->senha = $row[0];
			$e->guiche  =  $row[6];
			$e->estadoSenha  =  $row[8];
			
			$return[] = $e;
		}
		
		sqlsrv_free_stmt ( $stmt );
		sqlsrv_close ( $conn );
		
		// Return json encoded results
		return json_encode ( $return );
	}
}

$ajaxSenha = new ajaxSenha ();
echo $ajaxSenha->listarSenhas ();
?>