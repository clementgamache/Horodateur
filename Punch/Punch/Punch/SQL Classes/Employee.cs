using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch.SQL_Classes
{
    class Employee
    {
        public string Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastMomentIn { get; set; }

        public Employee(string id)
        {
            string request = "Select * from Employees where id = " + id;
            List<string> result = SQL.get(request, 6)[0];
            if (result == null)
            {
                string errorMessage = Translations.getRightString(6) + id;
                throw new Exception(errorMessage);
            }

            DateTime lastIn = Convert.ToDateTime(result[5]);
            Id = id;
            FirstName = result[1];
            LastName = result[2];
            LastMomentIn = lastIn;
        }

        public Employee(string id, string firstName, string lastName, DateTime lastMomentin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            LastMomentIn = lastMomentin;
        }

        public Employee(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            LastMomentIn = DateTime.MinValue;
        }

        public Employee(List<string> sqlResponse)
        {
            Id = sqlResponse[0];
            FirstName = sqlResponse[1];
            LastName = sqlResponse[2];
            LastMomentIn = Convert.ToDateTime(sqlResponse[5]);
        }

        public void punchIn()
        {
            LastMomentIn = DateTime.Now;
            update();
        }

        public void punchOut()
        {
            string request =
                @"insert into activity 
                    (employeeid, timein, timeout) 
                    values('" + Id + "', '" + SQL.getDateTimeString(LastMomentIn) + "', '" + SQL.getDateTimeString(DateTime.Now) + "')";
            SQL.run(request);
            LastMomentIn = DateTime.MinValue;
            update();
        }

        public void delete()
        {
            string request = "delete from employees where id = '" + Id + "'";
            SQL.run(request);
        }


        public void update()
        {
            string request = 
                @"Update Employees set 
                    firstname = '" + FirstName + @"', 
                    lastname = '" + LastName + @"', 
                    lastin = '" + SQL.getDateTimeString(LastMomentIn)+ @"' 
                    where id = '" + Id + "'";
            SQL.run(request);
        }

        public void insert()
        {
            string request =
                @"insert into employees (id, firstname, lastname, lastin) values
                    ('" + Id +"', '"+FirstName+"', '"+LastName+"', '"+SQL.getDateTimeString(LastMomentIn)+"')";
            SQL.run(request);
        }

       

        public static List<Employee> getEmployees(string request)
        {
            List<Employee> allEmployees = new List<Employee>();
            List<List<string>> responses = SQL.get(request, 6);
            foreach(List<string> response in responses)
            {
                allEmployees.Add(new Employee(response));
            }
            return allEmployees;
        }
    }
}
