<?php
	include "scripts/function.inc";
?>
<html>
	<head>
		<title> :: Página principal - Sistema de Concursos </title>
	</head>
	<body>
		<a href="internalpages/testaphp.php">Verifique as configurações do PHP</a>
		<p>
		<font face="Verdana size="2">
			::<a href="index.php">Principal</a> |
			::<a href="cad_candidatos.php">Cadastro de Candidatos</a> | 
			::<a href="cad_locais.php">Cadastro de Locais de Prova</a> | 
			::<a href="cons_cand_local.php">Consulta Candidato x Local de Prova</a> |
			::<a href="dados_acesso.php">Acesso</a> |
		Visite o site da <a href="https://www.ufac.br" target="_blank">UFAC</a>
		<p>
			Seja bem-vindo(a)!
		<p align="right">

	<?php
		imprime_data();
	?>
		<p>
		<b>
			<font face="Courire New" size="4" color="#11111"> Vai pra cima dele</font>
			<font color="red" size="7"> MENGO!!!</font>
		</b>
		<h1 align="center"> SELETO - Sistema de Concursos</h1>
		<h2 align="right"> Faça sua autentificação para acessar o sistema<h2>
		<h3> Usuários </h3>
		<strong>Administrador</strong>
		<br>
		<i> admin</i>
		<br>
		<u>root</u>
		<br>
		x<sup>2</sup>+a-log<sub>n</sub>
		<br>
		Que curso<strike>legal</strike>ótimo
		<br>
		<p align="center"> Isso está centralizado com a tag p </p>
		<h2> Locais de prova</h2>
		<center> Isso está centralizado com a tag center </center>
		<ol type="1">
			<li>Bloco Jersey Nazareno
			<li>Bloco Wanderley Dantas
			<li>Bloco da Reitoria
		</ol>
		<h2>Cargos</h2>
		<ul type="disc">
			<li>Analista de Suporte
			<li>Analista de Sistemas
			<li>Merendeira
		</ul>
		<center>
		<img src="imgs\user.png"height="160px" width="160px">
		<p>
		<img src="imgs\user2.jpg"height="160px" width="160px">
		</center>
	</body>
</html>