using FlatUI;

namespace sysBOT
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
            this.titleButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.streamTitle = new MaterialSkin.Controls.MaterialSingleLineTextField();
            alert = new FlatUI.FlatAlertBox();
            this.SuspendLayout();
            // 
            // titleButton
            // 
            this.titleButton.AutoSize = true;
            this.titleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleButton.Depth = 0;
            this.titleButton.Icon = null;
            this.titleButton.Location = new System.Drawing.Point(24, 121);
            this.titleButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.titleButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.titleButton.Name = "titleButton";
            this.titleButton.Primary = false;
            this.titleButton.Size = new System.Drawing.Size(84, 36);
            this.titleButton.TabIndex = 0;
            this.titleButton.Text = "Set Title";
            this.titleButton.UseVisualStyleBackColor = true;
            this.titleButton.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // streamTitle
            // 
            this.streamTitle.Depth = 0;
            this.streamTitle.Hint = "Stream Title";
            this.streamTitle.Location = new System.Drawing.Point(24, 89);
            this.streamTitle.MaxLength = 32767;
            this.streamTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.streamTitle.Name = "streamTitle";
            this.streamTitle.PasswordChar = '\0';
            this.streamTitle.SelectedText = "";
            this.streamTitle.SelectionLength = 0;
            this.streamTitle.SelectionStart = 0;
            this.streamTitle.Size = new System.Drawing.Size(177, 23);
            this.streamTitle.TabIndex = 1;
            this.streamTitle.TabStop = false;
            this.streamTitle.UseSystemPasswordChar = false;
            // 
            // alert
            // 
            alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            alert.Cursor = System.Windows.Forms.Cursors.Hand;
            alert.Font = new System.Drawing.Font("Segoe UI", 10F);
            alert.kind = FlatUI.FlatAlertBox._Kind.Success;
            alert.Location = new System.Drawing.Point(12, 310);
            alert.Name = "alert";
            alert.Size = new System.Drawing.Size(410, 42);
            alert.TabIndex = 2;
            alert.Text = "User Joined";
            alert.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 364);
            this.Controls.Add(alert);
            this.Controls.Add(this.streamTitle);
            this.Controls.Add(this.titleButton);
            this.Name = "Form1";
            this.Text = "sysBOT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton titleButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField streamTitle;
        public static FlatAlertBox alert;
    }
}

