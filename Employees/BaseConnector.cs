using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class BaseConnector
    {
        public static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                @"Data Source=|DataDirectory|\Employees.accdb";
    }
}
