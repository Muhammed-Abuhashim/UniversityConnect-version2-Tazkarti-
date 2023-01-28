using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityConnect
{
    class Student : Person , Task
    {
       
        public string[,] extrainfo = { {"500", "01202941341" } , {"400", "01202941341" } , {"600","01202941341" } };
        
        public Student (int index) : base(index){
        }

        public string credit
        { get
            {
                return extrainfo[index, 0];
            }
        }
        public string phone
        {
            get
            {
                return extrainfo[index, 1];
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Credit: {0}       Phone: {1}        ",credit,phone);
        }

     /* public string chat (string conversaition){
            string wholeconversation = null;
            if (conversaition == null)
                return null;
            else
            {
                wholeconversation = wholeconversation + "\n" + conversaition;
                return wholeconversation;
            }
        }*/
        public string chatpreview()
        { 
            string readconversationwhole;
            if (index == 0)
            {
                readconversationwhole = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat1.txt");
                return readconversationwhole;
            }
            else if (index == 1)
            {
                readconversationwhole = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat2.txt");
                return readconversationwhole;
            }
            else //if(index == 2)
            {
                readconversationwhole = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat3.txt");
                return readconversationwhole;
            } 
        }

        public void chatsend(int index , string conv)
        {
            string readconveration;
            if (index == 0)
            {
               readconveration = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat1.txt") + "\n" 
                                 + Firstname +" " + Lastname + ": " + conv + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\chat1.txt", readconveration);
            }
            else if (index == 1)
            {
                readconveration = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat2.txt") + "\n"
                    + Firstname + " " + Lastname + ": " + conv + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\chat2.txt", readconveration);

            }
            else if (index == 2)
            {
                readconveration = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat3.txt") + "\n"
                    + Firstname + " " + Lastname + ": " + conv + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\chat3.txt", readconveration);

            }
        }

        public string preview()
        {
            string readcoursetiming;
            if (index == 0)
            {
                readcoursetiming = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event.txt");
                return readcoursetiming;
            }
            else if (index == 1)
            {
                readcoursetiming = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event1.txt");
                return readcoursetiming;
            }
            else 
            {
                readcoursetiming = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event.txt");
                return readcoursetiming;
            }
            
        }
        public string posts(string po)
        {
            string readpost;
            if (index == 0)
            {
                readpost = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\post1.txt");
                return readpost;
            }
            else if (index == 1)
            {
                readpost = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\post2.txt");
                return readpost;
            }
            else
            {
                readpost = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\post3.txt");
                return readpost;
            }
        }
    }
}
