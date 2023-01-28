using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityConnect
{
    class Instructor : Person , Task 
    {
        public string [] extrainfo = {"Head Manager","Payment","Manager" };

        public Instructor(int index) : base(index)
        {
        }

        public string Degree
        {
            get
            {
                return extrainfo[index-10];
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("Degree: {0}",Degree);
        }

        public string chatpreview()
        {
            string readconversationwhole;
            if (index == 10)
            {
                readconversationwhole = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat1.txt");
                return readconversationwhole;
            }
            else if (index == 11)
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

        public void chatsend(int index, string conv)
        {
            string readconveration;
            if (index == 10)
            {
                readconveration = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat1.txt") + "\n"
                                  + Firstname + " " + Lastname + ": " + conv + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\chat1.txt", readconveration);
            }
            else if (index == 11)
            {
                readconveration = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat2.txt") + "\n"
                    + Firstname + " " + Lastname + ": " + conv + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\chat2.txt", readconveration);

            }
            else if (index == 12)
            {
                readconveration = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\chat3.txt") + "\n"
                    + Firstname + " " + Lastname + ": " + conv + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\chat3.txt", readconveration);

            }
        }
        public string preview()
        {
            string readcoursetiming;
            if (index == 10)
            {
                readcoursetiming = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event.txt");
                return readcoursetiming;
            }
            else if (index == 11)
            {
                readcoursetiming = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event1.txt");
                return readcoursetiming;
            }
            else
            {
                readcoursetiming = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event2.txt");
                return readcoursetiming;
            }
        }
        public string posts(string po)
        {
            string postupload;
            if (index == 10)
            {
                postupload = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\post1.txt") + "\n"
                                  + po + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\post1.txt", postupload);
            }
            else if (index == 11)
            {
                postupload = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\post2.txt") + "\n"
                                  + po + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\post2.txt", postupload);

            }
            else if (index == 12)
            {
                postupload = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\post3.txt") + "\n"
                    + po + Environment.NewLine;
                File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\post3.txt", postupload);

            }
            return "";
        }
    }
}
