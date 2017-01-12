using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;
using System.Configuration;

namespace sysBOT
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["username"].Value = username.Text;
                config.AppSettings.Settings["oauth"].Value = oauth.Text;
                config.AppSettings.Settings["channel"].Value = channel.Text;
                config.AppSettings.Settings["token"].Value = accessToken.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                Console.WriteLine($"{config.AppSettings.Settings["username"].Value}; {oauth.Text}; {channel.Text}; {accessToken.Text}");
                
            }
            Form1 mainform = new Form1(username.Text, oauth.Text, channel.Text, accessToken.Text);
            this.Hide();           
            mainform.ShowDialog();
            this.Close();
        }

        private void getAccessToken_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.jackgriggs.net/sysbot/auth/");

        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
