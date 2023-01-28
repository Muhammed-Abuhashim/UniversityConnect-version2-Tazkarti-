using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityConnect
{
    class Login
    {
        string[,] Client = { { "omar", "000000" }, { "maryam", "111111" }, { "dina", "222222" } };
        string[,] Admin = { { "muhammed", "000000" }, { "noha", "111111" }, { "lama", "222222" } };
        public int Verify(int type, string id, string password)
        {
            if(checkedid(type, id) )
            {
                return checkpassowrd(type , password);
            }
            else
            {
                return 20;
            }

        }

        public bool checkedid(int type, string id)
        {
            if (type == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (id == Client[i, 0])
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (id == Admin[i, 0])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int checkpassowrd(int type, string pass)
        {
            if (type == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (pass == Client[i, 1])
                    {
                        return i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (pass == Admin[i, 1])
                    {
                        return i+10;
                    }
                }
            }
            return 20;
        }
    } 
}
