using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysBOT
{
    public partial class Form1 : MaterialForm
    {
        public Connection conn;
        public static bool newUser;
        Twitch api = new Twitch();
        static Form1 form = new Form1();
        public Form1(string username, string oauth, string channel, string token)
        {
            InitializeComponent();
            Console.WriteLine($"Form1 Channel: {channel}");
            Thread init = new Thread(() => initConnection(username, oauth, channel, token));
            init.SetApartmentState(ApartmentState.STA);
            init.IsBackground = false;
            init.Start();
            init.Join();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        public Form1()
        {
              
        }

        public void initConnection(string username, string oauth, string channel, string token)
        {
            Console.WriteLine($"initConnection Channel: {channel}");
            conn = new Connection(username, oauth, channel, token);
        }

        public static void invokeAlert(string text)
        {
            if (alert.InvokeRequired)
            {
                alert.Invoke((MethodInvoker)(() => alert.Text = text));
                alert.Invoke((MethodInvoker)(() => alert.Visible = true));
            }
            else
            {
                alert.Text = text;
                alert.Visible = true;
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            api.setStreamTitle(streamTitle.Text.ToString());
        }
    }
}
