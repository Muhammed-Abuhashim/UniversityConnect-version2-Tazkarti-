using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityConnect
{
    class Course
    {
        int i;

        string[,] eventslist = { { "12", "AMR DIAB" },{"11","KHALED MONIB"},{"13","TAMER HOSNY"} }; 
        public Course (int index)
        {
            i = index;
        }

        public string Posts()
        {
            string readText = File.ReadAllText("D:\\github\\UniversityConnect version2 (Tazkarti)\\event.txt");
            File.WriteAllText(@"D:\\github\\UniversityConnect version2 (Tazkarti)\\event.txt", "Hiiii");
            return readText;
        }

    }
}
