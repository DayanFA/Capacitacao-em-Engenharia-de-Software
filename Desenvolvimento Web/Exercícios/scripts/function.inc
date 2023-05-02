<?php
	function get_client_ip()
	{
		$ipaddress = "";
		if (isset($_SERVER ['HTTP_CLIENT_IP']))
			$ipaddress = $_SERVER ['HTTP_CLIENT_IP'];
		else if (isset($_SERVER ['HTTP_X_FORWARDED_FOR']))
			$ipaddress = $_SERVER ['HTTP_X_FORWARDED_FOR'];
		else if (isset($_SERVER ['HTTP_X_FORWARDED']))
			$ipaddress = $_SERVER ['HTTP_X_FORWARDED'];
		else if (isset($_SERVER ['HTTP_FORWARDED_FOR']))
			$ipaddress = $_SERVER ['HTTP_FORWARDED_FOR'];
		else if (isset($_SERVER ['HTTP_FORWARDED']))
			$ipaddress = $_SERVER ['HTTP_FORWARDED'];
		else if (isset($_SERVER ['REMOTE_ADDR']))
			$ipaddress = $_SERVER ['REMOTE_ADDR'];
		else
			$ipaddress = 'UNKNOWN';
		return $ipaddress;
	};
	date_default_timezone_set('America/Rio_Branco');
	function imprime_data() 
	{
		$dia_mes=date('j');
		$mes=date('m');
		$ano=date('Y');
		if($mes==1) 
		{
			$mes="Janeiro";
		}
		elseif($mes==2) 
		{
			$mes="Fevereiro";
		}
		elseif($mes==3) 
		{
			$mes="Março";
		}
		elseif($mes==4) 
		{
			$mes="Abril";
		}
		elseif($mes==5) 
		{
			$mes="Maio";
		}
		elseif($mes==6) 
		{
			$mes="Junho";
		}
		elseif($mes==7) 
		{
			$mes="Julho";
		}
		elseif($mes==8) 
		{
			$mes="Agosto";
		}
		elseif($mes==9) 
		{
			$mes="Setembro";
		}
		elseif($mes==10) 
		{
			$mes="Outubro";
		}
		elseif($mes==11) 
		{
			$mes="Novembro";
		}
		elseif($mes==12) 
		{
			$mes="Dezembro";
		}
		$data_oficial="Rio Branco/AC," . " $dia_mes de" . " $mes de" . " $ano.";
		echo $data_oficial;
	}
?>