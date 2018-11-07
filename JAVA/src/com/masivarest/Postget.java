package com.masivarest;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;

public class Postget {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		try {
			get_token();
			//send_sms();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		 
		
	}
	
	private static void get_token() throws IOException
	{
		String urlParameters = "client_id=AQUISUCLIENT_ID&client_secret=AQUISUCLIENT_SECRET&grant_type=client_credentials";
		URL url = new URL("https://api.login-sms.com/token");
		URLConnection conn = url.openConnection();
				
		conn.setDoOutput(true);
		OutputStreamWriter writer = new OutputStreamWriter(conn.getOutputStream());

		try {
			writer.write(urlParameters);
		} catch (IOException e) {
			e.printStackTrace();
		}
		writer.flush();

		String line;
		BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));

		while ((line = reader.readLine()) != null) {
		    System.out.println(line);
		}
		writer.close();
		reader.close();  
		//Respuesta esperada:
		//{"access_token":"c852525d85ef4b7c6d89e08fc0b42399fe865204","expires_in":3600,"token_type":"Bearer","scope":null}
	}
	
	private static void send_sms() throws IOException
	{		    
		
		String urlParameters = "{\"to_number\":\"+593992727390\",\"content\":\"Hello\"}";
		URL url = new URL("https://api.login-sms.com/messages/send");
		URLConnection conn = url.openConnection();
		conn.setRequestProperty("Authorization", "Bearer c852525d85ef4b7c6d89e08fc0b42399fe865204");
		conn.setRequestProperty("Content-Type", "application/json");
		
		conn.setDoOutput(true);

		OutputStreamWriter writer = new OutputStreamWriter(conn.getOutputStream());

		try {
			writer.write(urlParameters);
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		writer.flush();

		String line;
		BufferedReader reader = new BufferedReader(new InputStreamReader(conn.getInputStream()));

		while ((line = reader.readLine()) != null) {
		    System.out.println(line);
		}
		writer.close();
		reader.close();  
		//Respuesta Esperada:
		//{"error":false,"status":200,"message":"Message sent successfully","ids":[{"campaign_id":5004054},{"messages_id":[10503667]}]}
	}
}
