using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace sysBOT
{
    partial class Login
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
            this.username = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.oauth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.channel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.loginBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.accessToken = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.getAccessToken = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialCheckBox1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Depth = 0;
            this.username.Hint = "Username";
            this.username.Location = new System.Drawing.Point(30, 86);
            this.username.MaxLength = 32767;
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(400, 23);
            this.username.TabIndex = 1;
            this.username.TabStop = false;
            this.username.UseSystemPasswordChar = false;
            // 
            // oauth
            // 
            this.oauth.BackColor = System.Drawing.Color.White;
            this.oauth.Depth = 0;
            this.oauth.Hint = "Oauth";
            this.oauth.Location = new System.Drawing.Point(30, 131);
            this.oauth.MaxLength = 32767;
            this.oauth.MouseState = MaterialSkin.MouseState.HOVER;
            this.oauth.Name = "oauth";
            this.oauth.PasswordChar = '\0';
            this.oauth.SelectedText = "";
            this.oauth.SelectionLength = 0;
            this.oauth.SelectionStart = 0;
            this.oauth.Size = new System.Drawing.Size(400, 23);
            this.oauth.TabIndex = 2;
            this.oauth.TabStop = false;
            this.oauth.UseSystemPasswordChar = false;
            // 
            // channel
            // 
            this.channel.BackColor = System.Drawing.Color.White;
            this.channel.Depth = 0;
            this.channel.Hint = "Channel";
            this.channel.Location = new System.Drawing.Point(30, 177);
            this.channel.MaxLength = 32767;
            this.channel.MouseState = MaterialSkin.MouseState.HOVER;
            this.channel.Name = "channel";
            this.channel.PasswordChar = '\0';
            this.channel.SelectedText = "";
            this.channel.SelectionLength = 0;
            this.channel.SelectionStart = 0;
            this.channel.Size = new System.Drawing.Size(400, 23);
            this.channel.TabIndex = 3;
            this.channel.TabStop = false;
            this.channel.UseSystemPasswordChar = false;
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = false;
            this.loginBtn.Depth = 0;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(114, 319);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Primary = true;
            this.loginBtn.Size = new System.Drawing.Size(231, 36);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // accessToken
            // 
            this.accessToken.Depth = 0;
            this.accessToken.Hint = "Access Token";
            this.accessToken.Location = new System.Drawing.Point(30, 224);
            this.accessToken.MaxLength = 32767;
            this.accessToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.accessToken.Name = "accessToken";
            this.accessToken.PasswordChar = '\0';
            this.accessToken.SelectedText = "";
            this.accessToken.SelectionLength = 0;
            this.accessToken.SelectionStart = 0;
            this.accessToken.Size = new System.Drawing.Size(364, 23);
            this.accessToken.TabIndex = 5;
            this.accessToken.TabStop = false;
            this.accessToken.UseSystemPasswordChar = false;
            // 
            // getAccessToken
            // 
            this.getAccessToken.AutoSize = false;
            this.getAccessToken.Depth = 0;
            this.getAccessToken.Icon = null;
            this.getAccessToken.Location = new System.Drawing.Point(400, 224);
            this.getAccessToken.MouseState = MaterialSkin.MouseState.HOVER;
            this.getAccessToken.Name = "getAccessToken";
            this.getAccessToken.Primary = true;
            this.getAccessToken.Size = new System.Drawing.Size(30, 23);
            this.getAccessToken.TabIndex = 6;
            this.getAccessToken.Text = "?";
            this.getAccessToken.UseVisualStyleBackColor = true;
            this.getAccessToken.Click += new System.EventHandler(this.getAccessToken_Click);
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBox1.Location = new System.Drawing.Point(30, 269);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(120, 30);
            this.materialCheckBox1.TabIndex = 7;
            this.materialCheckBox1.Text = "Remember Me";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            this.materialCheckBox1.CheckedChanged += new System.EventHandler(this.materialCheckBox1_CheckedChanged);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(468, 384);
            this.Controls.Add(this.materialCheckBox1);
            this.Controls.Add(this.getAccessToken);
            this.Controls.Add(this.accessToken);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.channel);
            this.Controls.Add(this.oauth);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField username;
        private MaterialSkin.Controls.MaterialSingleLineTextField oauth;
        private MaterialSingleLineTextField channel;
        private MaterialRaisedButton loginBtn;
        private MaterialSingleLineTextField accessToken;
        private MaterialRaisedButton getAccessToken;
        private MaterialCheckBox materialCheckBox1;
    }
}