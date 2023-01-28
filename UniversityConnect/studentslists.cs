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
    public partial class studentslists : Form
    {
        Form LoginForm;
        int index , t;
        Student s;
        public studentslists()
        {
            InitializeComponent();
        }

        public studentslists(int type , int index, Form L)
        {
            InitializeComponent();
            this.LoginForm = L;
            t = type;
            this.index = index;
            s = new Student(index);
            label2.Text = s.ToString();
        }

        private void Studentslists_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            chatform ch = new chatform(t,index, this);
            ch.Show();
            this.Hide();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            //LogoutFourm l = new LogoutFourm();
            LoginForm.Show();
            this.Hide();
            MessageBox.Show("Logged Out Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           new Form1().Show();
            this.Hide();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 c = new Form2(t,index,this);
            c.Show();
            this.Hide();
        }
    }
}
