<?php 
	include "scripts/configura.php";
	include "scripts/funcoes.inc";
	verifica_sessao();
?>
<html>
	<head> 
		<meta charset="UTF-8">
		<title>SELETO - Ficha de Inscrição</title>
		<style>
			body 
			{
				background-color: #f7fff7;
				font-family: Verdana, sans-serif;
			}
			.container 
			{
				max-width: 800px;
				margin: 0 auto;
				padding: 20px;
				border: 1px solid #c0c0c0;
				background-color: #fff;
			}
			label 
			{
				font-weight: bold;
			}
			input[type="text"], select 
			{
				padding: 5px;
				border: 1px solid #ccc;
				border-radius: 3px;
				font-size: 14px;
			}
			input[type="reset"], input[type="submit"] 
			{
				padding: 8px 15px;
				background-color: #4CAF50;
				color: #fff;
				border: none;
				border-radius: 3px;
				cursor: pointer;
				font-size: 16px;
				margin-top: 10px;
			}
			input[type="reset"]:hover, input[type="submit"]:hover 
			{
				background-color: #3e8e41;
			}
		</style>
	</head>
	<body>
	<div class="container">
		<center><font face="Verdana" color="black"><b>
		<font size="2">
		<p>
		<?php
			$conexao = mysqli_connect("$host", "$user", "$pass","$bd");
			$cand_nascimento = $_POST['ano_nascimento'] . '-' . $_POST['mes_nascimento'] . '-' . $_POST['dia_nascimento'];
			$cand_matri = $_POST['cand_matri']; 
			echo $cand_matri; 
			$cand_matri = sprintf("%06d", $cand_matri);
			$pega_id = mysqli_query($conexao, "SELECT max(cand_id) as ULT_ID from candidatos");
			$pega_id2 = mysqli_fetch_assoc($pega_id);
			$ultimo_idx = $pega_id2["ULT_ID"];
			$ultimo_id = $ultimo_idx + 1;
			$id_inscricao = sprintf("%04d", $ultimo_id);
			$cand_grau = sprintf("%02d", $_POST['cand_grau']);
			$cand_inscricao_sistema = "$cand_grau-$id_inscricao";
			$insere=mysqli_query($conexao, "INSERT INTO CANDIDATOS 
											(cand_matri, cand_nome, cand_nascimento, cand_endereco, cand_fone, 
											cand_doc_identificacao, cand_grau, cand_usu_id, cand_dt_inscricao, cand_dt_sistema)
											VALUES ('$_POST[cand_matri]', '$_POST[cand_nome]', '$cand_nascimento', 
											'$_POST[cand_endereco]', '$_POST[cand_fone]', '$_POST[cand_doc_identificacao]', 
											'$cand_grau', '0', NOW(), NOW())");
			//mysqli_close();
			echo "
				<center><b><font size=5 color=purple>INSCRIÇÃO BEM SUCEDIDA!<p></font>
				</B></CENTER>"; 
		?>
		<p>
		</p>
		<div style="width: 100%;">
		<div style="float: left;">
			<a href="seleto.php" style="color: blue; text-decoration: underline;">Voltar aos editais</a>
		</div>
		<div style="float: right;">
			<a href="logout.php" style="color: red; text-decoration: underline;">Encerrar sessão</a>
		</div>
		</div>
		<p>
		</p>
	</div>
	</body>
</html>
