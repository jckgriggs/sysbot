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
            Form1 mainform = new Form1(username.Text, oauth.Text, channel.Text);
            this.Hide();           
            mainform.ShowDialog();
            this.Close();
        }
    }
}
