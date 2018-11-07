<?php	
$ch = curl_init(); 
// definimos la URL a la que hacemos la petición
curl_setopt($ch, CURLOPT_URL,"https://api.login-sms.com/token");
// indicamos el tipo de petición: POST
curl_setopt($ch, CURLOPT_POST, TRUE);
// definimos cada uno de los parámetros
curl_setopt($ch, CURLOPT_POSTFIELDS, "client_id=AQUICLIENT_ID&client_secret=AQUICLIENT_SECRET&grant_type=client_credentials");
 
// recibimos la respuesta y la guardamos en una variable
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
$remote_server_output = curl_exec ($ch);
 
// cerramos la sesión cURL
curl_close ($ch);
 
// hacemos lo que queramos con los datos recibidos
// por ejemplo, los mostramos
print_r($remote_server_output);
//{"access_token":"34da02212496b3b48e1d93644f3c7f3a21a12b67","expires_in":3600,"token_type":"Bearer","scope":null} ?>
?>
