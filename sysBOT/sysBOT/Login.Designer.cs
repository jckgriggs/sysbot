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
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.Depth = 0;
            this.username.Hint = "Username";
            this.username.Location = new System.Drawing.Point(30, 96);
            this.username.MaxLength = 32767;
            this.username.MouseState = MaterialSkin.MouseState.HOVER;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.Size = new System.Drawing.Size(195, 23);
            this.username.TabIndex = 1;
            this.username.TabStop = false;
            this.username.UseSystemPasswordChar = false;
            // 
            // oauth
            // 
            this.oauth.BackColor = System.Drawing.Color.White;
            this.oauth.Depth = 0;
            this.oauth.Hint = "Oauth";
            this.oauth.Location = new System.Drawing.Point(30, 143);
            this.oauth.MaxLength = 32767;
            this.oauth.MouseState = MaterialSkin.MouseState.HOVER;
            this.oauth.Name = "oauth";
            this.oauth.PasswordChar = '\0';
            this.oauth.SelectedText = "";
            this.oauth.SelectionLength = 0;
            this.oauth.SelectionStart = 0;
            this.oauth.Size = new System.Drawing.Size(195, 23);
            this.oauth.TabIndex = 2;
            this.oauth.TabStop = false;
            this.oauth.UseSystemPasswordChar = false;
            // 
            // channel
            // 
            this.channel.BackColor = System.Drawing.Color.White;
            this.channel.Depth = 0;
            this.channel.Hint = "Channel";
            this.channel.Location = new System.Drawing.Point(30, 194);
            this.channel.MaxLength = 32767;
            this.channel.MouseState = MaterialSkin.MouseState.HOVER;
            this.channel.Name = "channel";
            this.channel.PasswordChar = '\0';
            this.channel.SelectedText = "";
            this.channel.SelectionLength = 0;
            this.channel.SelectionStart = 0;
            this.channel.Size = new System.Drawing.Size(195, 23);
            this.channel.TabIndex = 3;
            this.channel.TabStop = false;
            this.channel.UseSystemPasswordChar = false;
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSize = false;
            this.loginBtn.Depth = 0;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(30, 237);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Primary = true;
            this.loginBtn.Size = new System.Drawing.Size(195, 38);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Sign In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(256, 300);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.channel);
            this.Controls.Add(this.oauth);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }


        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField username;
        private MaterialSkin.Controls.MaterialSingleLineTextField oauth;
        private MaterialSingleLineTextField channel;
        private MaterialRaisedButton loginBtn;
    }
}