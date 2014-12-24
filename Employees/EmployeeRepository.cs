using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Employees
{
    public class EmployeeRepository : BaseConnector
    {
        public static List<Employee> GetAll()
        {
            string commando = "SELECT * FROM employees";

            OleDbDataAdapter adapter = new OleDbDataAdapter(commando, connectionString);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            List<Employee> employees = new List<Employee>();

            foreach (DataRow row in datatable.Rows)
            {
                Employee employee = new Employee();

                employee.employeeid = row.Field<int>("employeeID");
                employee.firstName = row.Field<string>("firstname");
                employee.lastName = row.Field<string>("lastname");
                employee.birth = row.Field<DateTime>("dateofbirth");
                employee.telephoneNumber = row.Field<string>("telephonenumber");
                employee.createdAt = row.Field<DateTime>("created_at");

                employees.Add(employee);
            }

            return employees;
        }

        public static void AddEmployee(Employee employee)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            conn.Open();

            //string sql = "INSERT INTO employees " + "(firstname, lastname, dateofbirth, telephonenumber, created_at) " + "VALUES ("
            //           + " ' " + employee.firstName + "', "
            //           + " ' " + employee.lastName + "', "
            //           + " #" + employee.birth + "#, "
            //           + " ' " + employee.telephoneNumber + "', "
            //           + " #" + employee.createdAt + "# " + ")";

            const string sql = "INSERT INTO employees (firstname, lastname, dateofbirth, telephonenumber, created_at) " + 
                "VALUES (@firstName, @lastName, @birth, @telephoneNumber, @createdAt)";

            cmd.Connection = conn;

            cmd.CommandText = sql;

            // Avoid SQL Injections
            cmd.Parameters.AddWithValue("@firstName", employee.firstName);
            cmd.Parameters.AddWithValue("@lastName", employee.lastName);
            cmd.Parameters.AddWithValue("@birth", employee.birth.Date);
            cmd.Parameters.AddWithValue("@telephoneNumber", employee.telephoneNumber);
            cmd.Parameters.AddWithValue("@createdAt", DateTime.Now.Date);

            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();

            conn.Close();
        }

        public static void UpdateEmployee(Employee employee)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            conn.Open();

            string commando;

            commando = "UPDATE employees SET " +
                       "firstname = '" + employee.firstName + "', " +
                       "lastname = '" + employee.lastName + "', " +
                       "created_at = #" + employee.createdAt + "# " +
                       "telephonenumber = '" + employee.telephoneNumber + "', " +
                       "dateofbirth = #" + employee.birth + "# " +
                       "WHERE employeeID = " + employee.employeeid;

            command.Connection = conn;
            command.CommandText = commando;
            adapter.UpdateCommand = command;

            adapter.UpdateCommand.ExecuteNonQuery();

            conn.Close();
        }
  

        public static void RemoveEmployee(int id)
        {
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter adapter = new OleDbDataAdapter();

            conn.Open();

            string sql = "DELETE FROM employees WHERE employeeID= "+id;

            cmd.Connection = conn;
            cmd.CommandText = sql;
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.ExecuteNonQuery();
            conn.Close();
        }
        
        public static Employee GetEmployeebyid(int id)
        {
            string cmd = "SELECT employeeID, firstname, lastname, dateofbirth, telephonenumber, created_at FROM employees WHERE employeeID="+id;

            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd, connectionString);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            if (datatable.Rows.Count > 0)
            {
                Employee employee = new Employee();
                Function function = new Function();

                employee.firstName = datatable.Rows[0].Field<string>("firstname");
                employee.lastName = datatable.Rows[0].Field<string>("lastname");
                employee.birth = datatable.Rows[0].Field<DateTime>("dateofbirth");
                employee.telephoneNumber = datatable.Rows[0].Field<string>("telephonenumber");
                employee.createdAt = datatable.Rows[0].Field<DateTime>("created_at");
                //function.functionname = datatable.Rows[1].Field<string>("function");

                return employee;
            }
            else
            {
                return null;
            }
        }
    }
}
