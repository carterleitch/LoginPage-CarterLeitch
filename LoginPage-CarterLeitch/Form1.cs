using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage_CarterLeitch
{
    public partial class Form1 : Form
    {
        public static string  name = "Carter";
        public static string password = "Yeet";

        public Form1()
        {
            InitializeComponent();
            LoginScreen fs = new LoginScreen();
            this.Controls.Add(fs);
        }
    }
}
