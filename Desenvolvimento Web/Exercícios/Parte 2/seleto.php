<?php
	include "scripts/configura.php";
	include "scripts/funcoes.inc";
	verifica_sessao();
?>
<html>
	<head>
		<meta charset="UTF-8">
		<title>SELETO - Principal</title>
	</head>
	<body bgproperties="fixed" topmargin="30" leftmargin="1" rightmargin="0" bgcolor="#f7fff7">
		<table align="center" border="0" width="90%" cellspacing="1">
			<tr>
				<td width="100%" align="center" bgcolor="C0C0C0" valign="middle">
					<center>
						<font face="Verdana" color="black" size="2"><b>SELETO<br> SISTEMA DE CONTROLE DE CONCURSOS PÚBLICOS<br></font></b>
						<font size="2"><b>(http://localhost/seleto/)</font></b>
				    </center>
				</td>
			</tr>
		</table>
		<font size="2" face="arial">
		<center>
			<p>
			<u><b>ACESSO PRINCIPAL</b></u>
		</center>
		<p>
		<?php
			$conexao=mysqli_connect("$host", "$user", "$pass", "$bd");
			//$banco=mysql_select_db("$db", $conexao);
			$boas_vindas=mysqli_query($conexao,"SELECT usu_nome 
									  FROM usuarios 
									  WHERE usu_id=$_SESSION[id]");
			$linha=mysqli_fetch_assoc($boas_vindas);
			$nome=$linha["usu_nome"];
			echo "<font size=2><center>Bem-Vindo (a), $nome!
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
			imprime_data();
		?>
		</center>
		</font>
		</div>
		<p>
		<font size="2">
		<b>
		<hr width="100%" align="left">
		<center>
			[<a href="cad_candidato.php?id=<?php echo $_SESSION['id']; ?>" style="color: blue; text-decoration: underline;">FICHA de INSCRIÇÃO</a>]
	</body>
</html>