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
    public partial class chatform : Form
    {
        Form BeformForm;
        int index, t;
        Student stu;
        Instructor i;
        public chatform()
        {
            InitializeComponent();
        }

        public chatform(int type, int index, Form L)
        {
            InitializeComponent();
            this.BeformForm= L;
            this.index = index;
            t = type;
            //i = new Instructor(index + 10);
            // label1.Text = "Dr. " + i.Firstname + i.Lastname;
            if (type == 0)
            {
                stu = new Student(index);
                richTextBox1.Text = stu.chatpreview();
            }
            else
            {
                i = new Instructor(index);
                richTextBox1.Text = i.chatpreview();
            }
        }

        private void Chatform_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //stu.chatsend(index, textBox1.Text);
        }

        private void RichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
           // stu.chatsend(indexdoctor, richTextBox1.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (t == 0)
                stu.chatsend(index, richTextBox2.Text);
            else
                i.chatsend(index, richTextBox2.Text);
            BeformForm.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
