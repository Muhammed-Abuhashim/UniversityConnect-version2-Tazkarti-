using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConnect
{
    class Person 
    {
        //private string firstname , lastname , department ;
        protected int index;
        private string[,] Clientlist = { {"1","omar","Youssef","Vip Client"},
                                          {"2","Maryam","Mohammed","New Client"},
                                          {"3","Dina","Hassan","Old Client"} };

        private string[,] Adminlist = {{"1","Mohammed","Ali","Vip Admin"},
                                  {"2","Noha","Yassin","New Admin"},
                                  {"3","Lama","Hesham","Old Admin"} };
   
    public Person(int index)
    {
        this.index = index;
    }

    public string ID
    {
        get
        {
                if (index < 3)
                    return Clientlist[index, 0];
                else if (index >= 10 && index <= 12)
                    return Adminlist[index - 10, 0];
                else
                    return null;
        }
    }
    public string Firstname
    {
        get
        {
                if (index < 3)
                    return Clientlist[index, 1];
                else if (index >= 10 && index <= 12)
                    return Adminlist[index - 10, 1];
                else
                    return null;
            }
    }
    public string Lastname
    {
        get
        {
                if (index < 3)
                    return Clientlist[index, 2];
                else if (index >= 10 && index <= 12)
                    return Adminlist[index - 10, 2];
                else
                    return null;
            }
    }
    public string Department
    {
        get
        {
                if (index < 3)
                    return Clientlist[index, 3];
                else if (index >= 10 && index <= 12)
                    return Adminlist[index - 10, 3];
                else
                    return null;
            }
    }

    public override string ToString()
    {
        return string.Format("ID: {0}       Name: {1} {2}        Department: {3}       ",
            ID, Firstname, Lastname, Department);
    }


    }
}
