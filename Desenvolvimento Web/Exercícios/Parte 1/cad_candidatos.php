<?php
	include "scripts/function.inc";
?>
<html>
	<head>
		<title>:: Cadastro de Candidatos</title>
	</head>
	<body>
		<font face="Verdana size="2">
			::<a href="index.php">Principal</a> |
			::<a href="cad_candidatos.php">Cadastro de Candidatos</a> | 
			::<a href="cad_locais.php">Cadastro de Locais de Prova</a> | 
			::<a href="cons_cand_local.php">Consulta Candidato x Local de Prova</a> |
			::<a href="dados_acesso.php">Acesso</a> |
		Visite o site da <a href="https://www.ufac.br" target="_blank">UFAC</a>
		</font>
		<p>
		<form method="post" action="cad_candidatos_resposta.php">
			<table border = "1">
				<tr>
					<td>
						Nome completo*:
					</td>
					<td colspan="3">
						<input type="text" size="30" name="nomeCompleto">
					</td>
				</tr>
				<tr>
					<td>
						Data de nascimento*:
					</td>
					<td>
						<input type="text" size="10" name="dataNascimento">
					</td>
					<td>
						CPF*:
					</td>
					<td>
						<input type="text" size="12" name="CPF">
					</td>
				</tr>
				<tr>
					<td>
						Endereço Completo:
					</td>
					<td colspan="3">
						<textarea cols="32" rows="3" name="enderecoCompleto">
							Informe seu endereço completo!
						</textarea>
					</td>
				</tr>
				<tr>
					<td>
						Forma de contato:
					</td>
					<td>
						<input type="checkbox" name="email" value="0">E-mail
					</td>
					<td>
						<input type="checkbox" name="carta" value="1">Carta
					</td>
					<td>
						<input type="checkbox" name="telefone" value="2">Telefone
					</td>
				</tr>
				<tr>
					<td>
						Cargo*:
					</td>
					<td>
						<input type="radio" name="cargo" value="C1">Analista de Sistemas
					</td>
					<td>
						<input type="radio" name="cargo" value="C2">Analista de Suporte
					</td>
					<td>
						<input type="radio" name="cargo" value="C3">Auxiliar de Merenda
					</td>
				</tr>
				<tr>
					<td colspan="2">
						<input type="reset" value="Limpar">
					</td>
					<td colspan="2">
						<input type="submit" value="Gravar >>">
					</td>
				</tr>
			</table>
		</form>
		<p>
			Contato: <a href="mailto:dayan.alves@sou.ufac.br">dayan.alves@sou.ufac.br</a><p>
	</body>
</html>