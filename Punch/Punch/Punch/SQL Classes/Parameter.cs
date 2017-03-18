using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punch.SQL_Classes
{
    class Parameter
    {
        public string tableName { get; set; }
        public string id { get; set; }
        public string name { get; set; }

        public Parameter(string tableName, string id, string name)
        {
            this.tableName = tableName;
            this.id = id;
            this.name = name;
        }

        public Parameter(string tableName, string name)
        {
            this.tableName = tableName;
            string request = "Select * from " + tableName + " where id = " + id;
            List<string> result = SQL.get(request, 2)[0];
            if (result == null)
            {
                string errorMessage = Translations.getRightString(6) + id;
                throw new Exception(errorMessage);
            }
            id = result[0];
            name = result[1];
        }

        public Parameter(string tableName, List<string> sqlResponse)
        {
            this.tableName = tableName;
            id = sqlResponse[0];
            name = sqlResponse[1];
        }

        
        public void insert()
        {
            string request =
                @"insert into " + tableName + @" (name) values
                    ('" + name + "')";
            SQL.run(request);
        }

        public void update()
        {
            string request =
                @"Update "+tableName + @" set 
                    name = '" + name + @"'
                    where id = " + id;
            SQL.run(request);
        }

        public void delete()
        {
            string request = "delete from " + tableName + " where id = " + id;
            SQL.run(request);
        }

        public static List<Parameter> getParameters(string tableName, string request)
        {
            List<Parameter> allParameters = new List<Parameter>();
            List<List<string>> responses = SQL.get(request, 6);
            foreach (List<string> response in responses)
            {
                allParameters.Add(new Parameter(tableName, response));
            }
            return allParameters;
        }
    }
}
