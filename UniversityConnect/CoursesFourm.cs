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
    public partial class CoursesFourm : Form
    {
        int index , type;
        Form f;
        Student s;
        Instructor i;


        public CoursesFourm()
        {
            InitializeComponent();
          
        }
        public CoursesFourm(int type, int index , Form F)
        {
            InitializeComponent();
            this.index = index;
            f = F;
            this.type = type;
            if (index < 3)
            {
                s = new Student(index);
                label2.Text = s.preview();
            }
            else
            {
                i = new Instructor(index);
                label2.Text = i.preview();
            }
            if (type == 0)
            {
                richTextBox1.Text = s.posts(" ");
            }
        }


        private void Label1_Click(object sender, EventArgs e)
        {
           
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(type == 1)
            {
                i.posts(richTextBox1.Text);
            }
            f.Show();
            this.Hide();
        }
    }
}
