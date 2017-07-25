using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFacExample
{
    public class SqlDAL : IDAL
    {

        public void Insert(string commandText)
        {
            Console.WriteLine("sql: " + commandText);
        }
    }
}
