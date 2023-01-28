using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UniversityConnect
{
    public partial class Form2 : Form
    {
        int index, type;
        Form f;
        Student s;
        Instructor i;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int type, int index, Form F)
        {
            InitializeComponent();
            
            
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            new studentslists().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoursesFourm c = new CoursesFourm(type, index, this);
            c.Show();
            this.Hide();
        }
    }
}
