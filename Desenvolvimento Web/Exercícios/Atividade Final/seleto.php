<?php
	include "scripts/configura.php";
	include "scripts/funcoes.inc";
	verifica_sessao();
?>
<html>
	<head>
		<meta charset="UTF-8">
		<title>SELETO - Principal</title>
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
			h1 
			{
				text-align: center;
				color: black;
				margin-bottom: 30px;
			}
			.welcome-message 
			{
				font-size: 20px;
				text-align: center;
				margin-bottom: 20px;
			}
			hr 
			{
				border: none;
				border-top: 1px solid #c0c0c0;
				margin: 20px 0;
			}
			a 
			{
				color: blue;
				text-decoration: none;
			}

			a:hover {
				text-decoration: underline;
			}
		</style>
	</head>
	<body>
		<div class="container">
			<h1>EDITAIS PARA BOLSISTAS</h1>
			<?php
				$conexao=mysqli_connect("$host", "$user", "$pass", "$bd");
				//$banco=mysql_select_db("$db", $conexao);
				$boas_vindas=mysqli_query($conexao,"SELECT usu_nome 
									  FROM usuarios 
									  WHERE usu_id=$_SESSION[id]");
				$linha=mysqli_fetch_assoc($boas_vindas);
				$nome=$linha["usu_nome"];
			?>
			<p class="welcome-message">Bem-vindo(a), <?php echo "$nome"; ?>!</p>
			<hr>
			<h4>Edital número 12.3:</h4>
			<p>
				[<a href="cad_candidato.php?id=<?php echo $_SESSION['id']; ?>" style="color: blue; text-decoration: underline;">FICHA de INSCRIÇÃO</a>]
			</p>
			<p align="right">
				<?php
					imprime_data();
				?>
			</p>
			<p align="right">
				<a href="logout.php" style="color: red; text-decoration: underline;">Encerrar sessão</a>
			</p>
			</div>
	</body>
</html>