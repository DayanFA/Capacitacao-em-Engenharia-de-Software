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
		<p><h1>FICHA DE INSCRIÇÃO</h1></p></center>
		<p>
		<p>		
		<form method="post" name="formulario" action="cad_candidato_grava.php">
			Num. Matrícula:&nbsp;
			<input type="text" name="cand_matri" size="10" maxlength="6">
			<Br>Nome Completo: <input type="text" name="cand_nome" size="32" maxlength="255">
			&nbsp;&nbsp;
			Data Nascimento: 
			<?php
				echo "<select name=\"dia_nascimento\">\n"; 
				for ($i = 1; $i <= 31; $i++) 
				{ 
					$i = sprintf("%02d", $i); 
					echo "\t<option value=$i>$i</option>\n"; 
				} 
				echo "</select>"; 
				echo "<select name=\"mes_nascimento\">\n"; 
				for ($i = 1; $i <= 12; $i++) 
				{ 
					$i = sprintf("%02d", $i); 
					echo "\t<option value=$i>$i</option>\n"; 
				} 
				echo "</select>"; 
				echo "<select name=\"ano_nascimento\">\n"; 
				for ($i = 1930; $i <= 2006; $i++) 
				echo "\t<option value=$i>$i</option>\n"; 
				echo "</select>"; 
			?>
			<br>Endereço:
			<input type="text" name="cand_endereco" size="74" maxlength="200"> 
			<br>
			Telefone:
			<input type="text" name="cand_fone" size="32" maxlength="30"><br>
			Grau acadêmico:<select size="1" name="cand_grau">
			<option selected>---</option>
			<option value=2>Graduação</option>
			<option value=3>Pós-Graduação</option>
			<option value=4>Mestrado</option>
			<option value=5>Doutorado</option>
			<option value=6>PHD</option>
			</select>
			<p>
				CPF: <input type="text" name="cand_doc_identificacao" size="15" maxlength="20">
			</p>
			<p>
			</p>
			<input type="reset" value="Limpar" name="limpar" style="background-color: #d3d3d3; color: black; font-weight: bold; border-radius: 5px;"> | 
			<input type="submit" value="Gravar >>" name="grava_bd" style="background-color: #008000; color: white; font-weight: bold; border-radius: 5px;">
		</form>
		<p align="right">
			<a href="logout.php" style="color: red; text-decoration: underline;">Encerrar sessão</a>
		</p>
	<div>
	</body>
</html>

