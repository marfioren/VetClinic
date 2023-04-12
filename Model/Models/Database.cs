using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Model
{
    public class Database
    {
        static Database instance;
        static User Logged;
        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                    return instance;
                }
                else
                {
                    return instance;
                }
            }
        }
    }
}