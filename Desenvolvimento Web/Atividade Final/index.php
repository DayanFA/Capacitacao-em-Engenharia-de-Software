<?php
	include "scripts/configura.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
		<title>SELETO - autenticação</title>
		<style>
			body 
			{
				background-color: #F7FFF7;
				margin: 0;
				padding: 0;
				font-family: Verdana;
				font-size: 14px;
				color: black;
			}
			.container 
			{
				max-width: 600px;
				margin: 50px auto;
				border: 1px solid #c0c0c0;
				background-color: #fff;
				padding: 20px;
			}
			h1 
			{
				font-size: 24px;
				margin-top: 0;
			}
			label 
			{
				display: block;
				margin-bottom: 5px;
			}

			input[type=text], input[type=password] 
			{
				padding: 5px;
				font-size: 14px;
			}
			input[type=submit] 
			{
				padding: 10px 25px;
				background-color: #4CAF50;
				color: white;
				border: none;
				border-radius: 3px;
				cursor: pointer;
			}
			input[type=submit]:hover 
			{
				background-color: #3E8E41;
			}
		</style>
	</head>
	<body>
		<div class="container">
			<h1>UNIVERSIDADE FEDERAL DO TESTE</h1>
			<h2>LOGIN DO ALUNO</h2>
			<form method="post" action="autenticacao.php">
				<label>Login:</label>
				<input type="text" name="usuario" maxlength="10" required>
				<label>Senha:</label>
				<input type="password" name="codigo" maxlength="10" required>
				<p>
				<input type="submit" value="Acessar >>>" name="acessar">
			</form>
			<p>
			</p>
			<p>
				Lembre-se de não compartilha sua senha com ninguém.
			</p>
		</div>
	</body>
</html>