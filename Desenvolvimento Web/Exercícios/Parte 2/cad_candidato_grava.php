<?php 
	include "scripts/configura.php";
	include "scripts/funcoes.inc";
	verifica_sessao();
?>
<html>
	<head> 
		<meta charset="UTF-8">
		<title>SELETO - Ficha de Inscrição</title>
	</head>
	<body>
		<table align="center" border="0" width="90%" cellspacing="1">
		<Tr><td></td></tr></table>
		<table align="center" border="0" width="90%" cellspacing="1">
		<tr>
		<td width="100%" bgcolor="C0C0C0" valign="middle">
		<center><font face="Verdana" color="black"><b>
		<font size="2">
		<p>
		<?php
			$conexao=mysqli_connect("$host", "$user", "$pass","$bd");
			$cand_dt_inscricao="2023-05-$_POST[dia_inscricao]";
			$cand_nascimento="$_POST[ano_nascimento]-$_POST[mes_nascimento]-$_POST[dia_nascimento]";
			$cand_inscricao = $_POST['cand_inscricao']; 
			echo $cand_inscricao; 
			$cand_inscricao = sprintf("%06d", $cand_inscricao);
			$pega_id=mysqli_query($conexao, "SELECT max(cand_id) ULT_ID from candidatos");
			$pega_id2=mysqli_fetch_assoc($pega_id);
			$ultimo_idx=$pega_id2["ULT_ID"];
			$ultimo_id=$ultimo_idx+1;
			$id_inscricao=sprintf("%04d", $ultimo_id);
			$cand_car_id=sprintf("%02d", $_POST['cand_car_id']);
			$cand_inscricao_sistema="$cand_car_id-$id_inscricao";
			$insere=mysqli_query($conexao, "INSERT INTO CANDIDATOS 
											(cand_inscricao, cand_nome,
											cand_nascimento, cand_endereco,cand_fone, cand_pai,
											cand_mae, cand_doc_identificacao, cand_tipo_doc_ident,
											cand_car_id, cand_unidade_lotacao, cand_usu_id, cand_dt_inscricao,
											cand_dt_sistema)
											VALUES ('$_POST[cand_inscricao]', '$_POST[cand_nome]',
											'$cand_nascimento', '$_POST[cand_endereco]', '$_POST[cand_fone]', '$_POST[cand_pai]',
											'$_POST[cand_mae]', '$_POST[cand_doc_identificacao]', $_POST[cand_tipo_doc_ident],
											'$_POST[cand_car_id]', '0','$_SESSION[id]',
											'$cand_dt_inscricao', '$_POST[cand_data_cadastro]')");
				//mysqli_close();
			echo "
				<center><b><font size=3 color=red>CANDIDATO INSERIDO COM SUCESSO!<p></font>
				</B></CENTER>"; 
		?>
	</body>
</html>