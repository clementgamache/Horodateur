using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punch.SQL_Classes
{
    static class Translations
    {

        public static string getRightString(int id)
        {
            string request = "Select * from settings where name = 'language'";
            string language = SQL.get(request, 2)[0][1];
            language = SQL.get(request, 2)[0][1];
            int column;
            if (language == "English") column = 1;
            else if (language == "French") column = 2;
            else throw new Exception("The database saved language is invalid");
            request = "Select * from locale where id = " + id.ToString();
            return SQL.get(request, 3)[0][column];

        }
    }
}
