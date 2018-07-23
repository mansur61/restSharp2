namespace restSharp2
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
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtScope = new System.Windows.Forms.TextBox();
            this.txtResponseType = new System.Windows.Forms.TextBox();
            this.txtRedirectUri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGrantType = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtClientID2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRedirectUri2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtState2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtApiResponse = new System.Windows.Forms.TextBox();
            this.txtTokenGir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtJsonParse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(161, 25);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(167, 20);
            this.txtClientID.TabIndex = 0;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(161, 293);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.Size = new System.Drawing.Size(167, 20);
            this.txtClientSecret.TabIndex = 1;
            this.txtClientSecret.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(161, 126);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(167, 20);
            this.txtState.TabIndex = 2;
            // 
            // txtScope
            // 
            this.txtScope.Location = new System.Drawing.Point(161, 100);
            this.txtScope.Name = "txtScope";
            this.txtScope.Size = new System.Drawing.Size(167, 20);
            this.txtScope.TabIndex = 3;
            // 
            // txtResponseType
            // 
            this.txtResponseType.Location = new System.Drawing.Point(161, 74);
            this.txtResponseType.Name = "txtResponseType";
            this.txtResponseType.Size = new System.Drawing.Size(167, 20);
            this.txtResponseType.TabIndex = 4;
            // 
            // txtRedirectUri
            // 
            this.txtRedirectUri.Location = new System.Drawing.Point(161, 48);
            this.txtRedirectUri.Name = "txtRedirectUri";
            this.txtRedirectUri.Size = new System.Drawing.Size(167, 20);
            this.txtRedirectUri.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "client_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "state";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "scope";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "response_type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "redirect_uri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "grant_type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "client_secret";
            // 
            // txtGrantType
            // 
            this.txtGrantType.Location = new System.Drawing.Point(161, 319);
            this.txtGrantType.Name = "txtGrantType";
            this.txtGrantType.Size = new System.Drawing.Size(167, 20);
            this.txtGrantType.TabIndex = 13;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(351, 55);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUrl.Size = new System.Drawing.Size(196, 39);
            this.txtUrl.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Autherization";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(348, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Url Göster";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Code Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(161, 244);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(167, 20);
            this.txtCode.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "client_id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Token Al";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(351, 251);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSonuc.Size = new System.Drawing.Size(226, 170);
            this.txtSonuc.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(364, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Token Goster";
            // 
            // txtClientID2
            // 
            this.txtClientID2.Location = new System.Drawing.Point(161, 270);
            this.txtClientID2.Name = "txtClientID2";
            this.txtClientID2.Size = new System.Drawing.Size(167, 20);
            this.txtClientID2.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "OAuth Code";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Acses Token";
            // 
            // txtRedirectUri2
            // 
            this.txtRedirectUri2.Location = new System.Drawing.Point(161, 345);
            this.txtRedirectUri2.Name = "txtRedirectUri2";
            this.txtRedirectUri2.Size = new System.Drawing.Size(167, 20);
            this.txtRedirectUri2.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(49, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "redirect_uri";
            // 
            // txtState2
            // 
            this.txtState2.Location = new System.Drawing.Point(161, 372);
            this.txtState2.Name = "txtState2";
            this.txtState2.Size = new System.Drawing.Size(167, 20);
            this.txtState2.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(49, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "state";
            // 
            // txtApiResponse
            // 
            this.txtApiResponse.Location = new System.Drawing.Point(676, 318);
            this.txtApiResponse.Multiline = true;
            this.txtApiResponse.Name = "txtApiResponse";
            this.txtApiResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtApiResponse.Size = new System.Drawing.Size(215, 156);
            this.txtApiResponse.TabIndex = 30;
            // 
            // txtTokenGir
            // 
            this.txtTokenGir.Location = new System.Drawing.Point(676, 263);
            this.txtTokenGir.Name = "txtTokenGir";
            this.txtTokenGir.Size = new System.Drawing.Size(167, 20);
            this.txtTokenGir.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(597, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Api Response";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(607, 270);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Token";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Api Verileri Getir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(685, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Api Verileri ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(715, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "Json Parse Göster";
            // 
            // txtJsonParse
            // 
            this.txtJsonParse.Location = new System.Drawing.Point(665, 48);
            this.txtJsonParse.Multiline = true;
            this.txtJsonParse.Name = "txtJsonParse";
            this.txtJsonParse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtJsonParse.Size = new System.Drawing.Size(215, 156);
            this.txtJsonParse.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 486);
            this.Controls.Add(this.txtJsonParse);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTokenGir);
            this.Controls.Add(this.txtApiResponse);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtState2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtRedirectUri2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtClientID2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.txtGrantType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRedirectUri);
            this.Controls.Add(this.txtResponseType);
            this.Controls.Add(this.txtScope);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtClientSecret);
            this.Controls.Add(this.txtClientID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtScope;
        private System.Windows.Forms.TextBox txtResponseType;
        private System.Windows.Forms.TextBox txtRedirectUri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGrantType;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtClientID2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRedirectUri2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtState2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtApiResponse;
        private System.Windows.Forms.TextBox txtTokenGir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtJsonParse;
    }
}

