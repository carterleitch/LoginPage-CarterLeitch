using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage_CarterLeitch
{
    public partial class LoginScreen : UserControl
    {
        public LoginScreen()
        {
            InitializeComponent();
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Form1.name && textBox2.Text == Form1.password) 
            {
                Form f = this.FindForm();
                f.Controls.Remove(value: this);

                AccessGrantedScreen sc = new AccessGrantedScreen();
                f.Controls.Add(sc);
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
