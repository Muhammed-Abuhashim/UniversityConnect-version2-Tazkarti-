using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityConnect
{
    public partial class LoginInForm : Form
    {
        Form MainForm;
        int y = 0;
        string id, password;
        public LoginInForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        public LoginInForm(int type , Form MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
            this.y = type;
            textBox2.PasswordChar = '*';
        }


        private void LoginInForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            int index = lo.Verify(y, id, password);
            MessageBox.Show(Convert.ToString(index));
            if(index>=0&&index<=12)
            {
                MessageBox.Show("LOG IN Successfully!!");
                if (index < 3)
                {
                    studentslists s = new studentslists(y,index, this);
                    s.Show();
                    this.Hide();
                }
                else
                {
                    InstructorList i = new InstructorList(y,index, this);
                    i.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Error!\nPlease Try Again.");
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           id = textBox1.Text;
        }
    }
}
