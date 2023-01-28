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
    public partial class InstructorList : Form
    {
        Form LoginForm;
        int index ,t;
        Instructor instr;
        public InstructorList()
        {
            InitializeComponent();
        }

        public InstructorList(int type ,int index, Form L)
        {
            InitializeComponent();
            this.LoginForm = L;
            this.index = index;
            t = type;
            instr = new Instructor(index);
            label2.Text = instr.ToString();
        }

        private void InstructorList_Load(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            new Form1().Show();
            this.Hide();
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            new Form2().Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            chatform ch = new chatform(t,index, this);
            ch.Show();
            this.Hide();
        }
    }
}
