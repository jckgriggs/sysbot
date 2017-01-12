﻿using MaterialSkin;
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
        public Form1(string username, string oauth, string channel)
        {
            InitializeComponent();

            Thread init = new Thread(() => initConnection(username, oauth, channel));
            init.SetApartmentState(ApartmentState.STA);
            init.IsBackground = false;
            init.Start();
            init.Join();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        public void initConnection(string username, string oauth, string channel)
        {
            conn = new Connection(username, oauth, channel);
        }
    }
}
