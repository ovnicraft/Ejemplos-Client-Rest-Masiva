using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Test_Masiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void post_request()
        {

             
        
        }

        private void send_sms(string token)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://api.login-sms.com/messages/send");

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Headers["Authorization"] = "Bearer "+token;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"to_number\":\"+593992727390\"," +
                              "\"content\":\"Hello Prueba desde C#\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Console.WriteLine("" + responseString);
            if (responseString.IndexOf("Message sent successfully") != -1)
            {
                MessageBox.Show("Mensaje Enviado Correctamente", "Estatus", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void get_token()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://api.login-sms.com/token");
            request.Method = "POST";
            request.ContentType = "application/json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"client_id\":\"AquiClientID\"," +
                              "\"client_secret\":\"AquiClienSecret\"," +
                              "\"grant_type\":\"client_credentials\"}";

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            int start = 0;
            int end = 0;
            byte val = 34;            
            start = responseString.IndexOf(":" + (char)val);
            end = responseString.IndexOf((char)val+",");
            if ((start != -1) && (end != -1))
            {
                txt_token.Text = responseString.Substring(start+2, end-start-2);
                btn_send_sms.Enabled = true;
            }
            Console.WriteLine("" + responseString);
        }

        private void btn_get_token_Click(object sender, EventArgs e)
        {
            get_token();
        }

        private void btn_send_sms_Click(object sender, EventArgs e)
        {
            if (txt_token.Text != "")
            {
                send_sms(txt_token.Text);
            }
            else
            {
                MessageBox.Show("Presione el boton para generar TOKEN", "TOKEN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
