<?php
include 'Database.php';

class DAOSenha {
	public function listarPorHora(){
		global $DB;
		$sql = "select top 6 * from Senha order by Atendido desc";
		return $return = $DB->query($sql, array());
	}
}
?> 