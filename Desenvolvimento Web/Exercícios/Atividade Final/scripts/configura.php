<script>
	largura = 708 ;
	altura = 580 ;
	X = (screen.availWidth - largura) / 2;
	Y = (screen.availHeight - altura) / 2;
	function abrir(url) 
	{
		window.open('url','width=' + 700 + ',height=' + 540 + ',top=' + Y + ',left=' + X + ',screenX=' + X + ',screenY=' + Y + ",scrollbars=yes");
	}
</script>
<script> 
	function ValidaFormulario () 
	{
	if (document.formulario.cand_nome.value=="")
	{ 
		alert("Preencher todos os campos obrigatórios!"); 
		document.formulario.cand_nome.focus(); 
		return false;
	}
	if (document.formulario.cand_endereco.value=="")
	{ 
		alert("Preencher todos os campos obrigatórios!"); 
		document.formulario.cand_endereco.focus(); 
		return false;
	}
	if (document.formulario.cand_car_id.value=="")
	{ 
		alert("Preencher todos os campos obrigatórios!"); 
		document.formulario.cand_car_id.focus(); 
		return false;
	}
	if (document.formulario.cand_unidade_lotacao.value==""){ 
		alert("Preencher todos os campos obrigatórios!"); 
		document.formulario.cand_unidade_lotacao.focus(); 
		return false;
	}	
	if (document.formulario.cand_doc_identificacao.value=="")
	{ 
		alert("Preencher todos os campos obrigatórios!"); 
		document.formulario.cand_doc_identificacao.focus(); 
		return false;
	}
	if (document.formulario.cand_tipo_doc_ident.value=="")
	{ 
		alert("Preencher todos os campos obrigatórios!"); 
		document.formulario.cand_tipo_doc_ident.focus(); 
		return false;
	}
	return true;
}
</script>
<style>
.Menu_MouseOver 
{
	font-size: 12px;
	color: #000000;
	cursor: hand;
	vertical-align: middle;
	background-color: green;
}
.Menu_MouseOut 
{
	font-size: 12px;
	color: #669999;
	border-bottom: 1px solid #c9d2b2;
	vertical-align: middle;
	background-color: #669999;
}
body 
	{ scrollbar-face-color: #f7fff7; scrollbar-shadow-color: black; scrollbar-highlight-color: #f7fff7; scrollbar-3dlight-color: #f7fff7; scrollbar-darkshadow-color: #f7fff7; scrollbar-track-color: "#001038"; scrollbar-arrow-color: "#001038" }
	A:hover {TEXT-DECORATION: underline; color: black; font-weight:bold; }
	A:link {TEXT-DECORATION: none; color: black; font-weight:bold; }
	A:visited {TEXT-DECORATION: none; color: black; font-weight:bold; }
	.aux:hover {TEXT-DECORATION: underline; color: orange; }
	.aux:link {TEXT-DECORATION: none; color: #FFCC00; font-weight:bold; }
	.aux:visited {TEXT-DECORATION: none; color: #CCCCFF; }
input
{
	font-size: 10px;
	color: black;
    font-weight: bold;  
	border: solid 1px #1D640F;
	filter: alpha(opacity=80, finishopacity=80, style=1);
	border: solid 1px #1D640F;
}		
</style>