using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class FunctionRepository : BaseConnector
    {
        public static List<Function> GetAll()
        {
            string commando = "SELECT * FROM functions";

            OleDbDataAdapter adapter = new OleDbDataAdapter(commando, connectionString);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);

            List<Function> functions = new List<Function>();

            foreach (DataRow row in datatable.Rows)
            {
                Function function = new Function();

                function.functionid = row.Field<int>("functionID");
                function.functionname = row.Field<string>("function");
                function.hourlyWage = row.Field<Decimal>("hourlywage");

                functions.Add(function);
            }

            return functions;
        }
    }
}
