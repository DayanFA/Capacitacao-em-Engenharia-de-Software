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
			::<a href="cad_locais.php">Cadastro de Locais de Proca</a> | 
			::<a href="cons_cand_local.php">Consulta Candidato x Local de Prova</a> |
			::<a href="dados_acesso.php">Acesso</a> |
		Visite o site da <a href="https://www.ufac.br" target="_blank">UFAC</a>
		</font>
		<p>
			<table border = "1">
				<tr>
					<td>
						Nome completo*:
					</td>
					<td colspan="3">
						<?php 
							echo $_POST['nomeCompleto']; 
						?>
					</td>
				</tr>
				<tr>
					<td>
						Data de nascimento*:
					</td>
					<td>
						<?php 
							echo $_POST['dataNascimento']; 
						?>
					</td>
					<td>
						CPF*:
					</td>
					<td>
						<?php 
							echo $_POST['CPF']; 
						?>
					</td>
				</tr>
				<tr>
					<td>
						Endereço Completo:
					</td>
					<td colspan="3">
						<?php 
							echo $_POST['enderecoCompleto']; 
						?>
					</td>
				</tr>
				<tr>
					<td>
						Forma de contato:
					</td>
					<td colspan="3">
					<?php 
						$formaContato = array();
						if(isset($_POST['email'])) 
						{ 
							$formaContato[] = 'E-mail';
						}
						if(isset($_POST['carta'])) 
						{ 
							$formaContato[] = 'Carta'; 
						}
						if(isset($_POST['telefone'])) { 
							$formaContato[] = 'Telefone';
						}
						if(!empty($formaContato)) 
						{
							$formaContatoTexto = implode(", ", $formaContato); 
							echo $formaContatoTexto; 
						} 
						else 
						{
							echo "Nenhuma forma de contato selecionada."; 
						}
					?>
				</td>
				</tr>
				<tr>
					<td>
						Cargo*:
					</td>
					<td colspan="3">
						<?php 
							echo $_POST['cargo']; 
						?>
					</td>
				</tr>
			</table>
			<p>
			Contato: <a href="mailto:dayan.alves@sou.ufac.br">dayan.alves@sou.ufac.br</a><p>
	</body>
</html>