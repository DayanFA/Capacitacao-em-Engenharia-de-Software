<?php
	include "scripts/configura.php";
?>
<html>
	<head>
		<meta charset="UTF-8">
		<title>SELETO - autenticação</title>
	</head>
	<body bgproperties="fixed" topmargin="30" leftmargin="1" rightmargin="0" bgcolor="#f7fff7">
		<table align="center" border="0" width="90%" cellspacing="1">
			<tr>
				<td width="100%" align="center" bgcolor="C0C0C0" valign="middle">
					<center>
						<font face="Verdana" color="black" size="2"><b>PREFEITURA MUNICIPAL DE <i>TESTE_123</i></font></b>
				    </center>
				</td>
			</tr>
			<tr>
				<td width="100%" align="center" bgcolor="C0C0C0" valign="middle">
					<center>
						<font face="Verdana" color="black" size="2"><b>SELETO<br> SISTEMA DE CONTROLE DE CONCURSOS PÚBLICOS<br></font></b>
						<font size="2"><b>(http://localhost/seleto/)</font></b>
				    </center>
				</td>
			</tr>
		</table>
		<table align="center" border="0" width="90%" cellspacing="1">
			<tr>
				<td align="center">
					<font face="Verdana" size="3"> <b>AUTENTIFICAÇÃO NO SISTEMA<p></font></b>
				</td>
			</tr>
			<tr>
				<td align="center">
					<form method="post" action="autenticacao.php">
					<b><font face="Verdana" size="2">Login:</font></b>
					&nbsp;<input type="text" name="usuario" size="16" maxlength="10">
				</td>
			</tr>
			</tr>
			<tr>
				<td align="center">
					<b><font face="Verdana" size="2">Senha:</font></b>
					&nbsp;<input type="password" name="codigo" size="16" maxlength="10">
				</td>
			</tr>
			<tr>
				<td align="center" valign="top">
					&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<input type="submit" value="Acessar >>>" name="acessar">
					</form>
				</td>
			</tr>
		</table>
		<center>
			<p>&nbsp;
			<font face="Verdana" size="2" color="black"><br>Você está em um ambiente seguro, monitorado e de<br> acesso restrito.</font>
			<hr noshade color="C0C0C0" size="6" width="90%">
			<table border="0" width="90%" cellspacing="1" height="30">
				<tr>
					<td width="100%" align="center" height="1" valign="middle">
						<font face="Verdana" size="2" class="baixo">Ajuda | Segurança <br>
					</td>
				</tr>
			</table>
		</center>
	</body>
</html>