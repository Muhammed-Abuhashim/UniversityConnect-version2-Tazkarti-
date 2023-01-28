using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConnect
{
    interface Task
    {
        string chatpreview ();
        void chatsend(int index , string conv);
        string posts(string po);
        string preview();
    }
}
