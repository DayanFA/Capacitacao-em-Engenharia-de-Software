<?php
	include "scripts/function.inc";
?>
<html>
	<head>
		<title>:: Continuando a aprender ...</title>
	</head>
	<body bgcolor="" link="#FF4500" alink="#00BFFF" vlink="696969">
		<font face="Verdana size="2">
			::<a href="index.php">Principal</a> |
			::<a href="cad_candidatos.php">Cadastro de Candidatos</a> | 
			::<a href="cad_locais.php">Cadastro de Locais de Prova</a> | 
			::<a href="cons_cand_local.php">Consulta Candidato x Local de Prova</a> |
			::<a href="dados_acesso.php">Acesso</a> |
		Visite o site da <a href="https://www.ufac.br" target="_blank">UFAC</a>
		</font>
		<p>
		<table border="1" align="center" width="75%">
			<tr align="center">
				<td>
					<b>IP de acesso</b>
				</td>
				<td>
				<?php 
					echo get_client_ip();
				?>
				</td>
			</tr>
			<tr align="center">
				<td>
					<b>Data de acesso:</b>
				</td>
				<td>
				<?php 
					echo date("d/m/Y");
				?>
				</td>
			</tr>
			<tr align="center">
				<td>
					<b>Hora de acesso:</b>
				</td>
				<td>
				<?php 
					echo date("H:i:s");
				?>
				</td>
			</tr>
			<tr align="center">
				<td>
					<b>Navegador de acesso:</b>
				</td>
				<td>
				<?php 
					echo $_SERVER ['HTTP_USER_AGENT'];
				?>
				</td>
			</tr>
		</table>
		<p>
			Contato: <a href="mailto:dayan.alves@sou.ufac.br">dayan.alves@sou.ufac.br</a><p>
	</body>
</html>