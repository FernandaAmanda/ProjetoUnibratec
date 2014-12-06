<?php
class BaddyRPGDatabase {
    const myServer = "localhost\\sqlexpress";
	const myDB = "PocketQueue";
	private $connection;
	
	public function __construct(){
		$connectionInfo = array(	
			"Database" => static::myDB
		);
		$this->connection = sqlsrv_connect(static::myServer, $connectionInfo);
	}
	
	public function query($query, array $args){
		
		$refArgs = array();
		foreach($args as $arg){
			$refArgs[] = &$arg;
		}
		
		$returnStatement = sqlsrv_query($this->connection, $query, $refArgs);
		print_r("<pre>");
		if ($returnStatement === false){
			throw new Exception("ERROR");
		}
		
		$rows = array();
		
		while ($row = sqlsrv_fetch_array($returnStatement, SQLSRV_FETCH_ASSOC)){
			$rows[] = $row;
		}
		
		return $rows;
	}
}

$DB = new BaddyRPGDatabase();
?>