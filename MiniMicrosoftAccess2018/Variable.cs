using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace MiniMicrosoftAccess2018
{
    class Variable
    {
        public static DBEngine dbe;
        public static Database myDB;
        public static TableDef myTB;
        public static string path;
        public static List<string> storeTableNames = new List<string>();
    }
}
