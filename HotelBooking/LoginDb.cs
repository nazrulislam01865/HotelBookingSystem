using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBooking
{
    public partial class LoginDb : Form
    {
        public LoginDb()
        {
            InitializeComponent();
        }

        private void LoginDb_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool isFocused = false;
        private void TextBoxPanel_Paint(object sender, PaintEventArgs e)
        {
 
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           MessageBox.Show(customTextBox1.TextBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginText_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
