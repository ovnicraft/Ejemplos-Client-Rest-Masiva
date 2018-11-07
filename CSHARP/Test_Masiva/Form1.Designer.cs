namespace Test_Masiva
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_get_token = new System.Windows.Forms.Button();
            this.btn_send_sms = new System.Windows.Forms.Button();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_get_token
            // 
            this.btn_get_token.Location = new System.Drawing.Point(34, 49);
            this.btn_get_token.Name = "btn_get_token";
            this.btn_get_token.Size = new System.Drawing.Size(75, 23);
            this.btn_get_token.TabIndex = 0;
            this.btn_get_token.Text = "Get Token";
            this.btn_get_token.UseVisualStyleBackColor = true;
            this.btn_get_token.Click += new System.EventHandler(this.btn_get_token_Click);
            // 
            // btn_send_sms
            // 
            this.btn_send_sms.Enabled = false;
            this.btn_send_sms.Location = new System.Drawing.Point(34, 94);
            this.btn_send_sms.Name = "btn_send_sms";
            this.btn_send_sms.Size = new System.Drawing.Size(75, 23);
            this.btn_send_sms.TabIndex = 1;
            this.btn_send_sms.Text = "Send SMS";
            this.btn_send_sms.UseVisualStyleBackColor = true;
            this.btn_send_sms.Click += new System.EventHandler(this.btn_send_sms_Click);
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(128, 52);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(556, 20);
            this.txt_token.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token Received";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.btn_send_sms);
            this.Controls.Add(this.btn_get_token);
            this.Name = "Form1";
            this.Text = "Masiva SMS Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_get_token;
        private System.Windows.Forms.Button btn_send_sms;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label1;
    }
}

