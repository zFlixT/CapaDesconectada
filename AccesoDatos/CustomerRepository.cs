using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CustomerRepository
    {
        public DataTable ObtenerTodos()
        {
            DataTable dataTable = new DataTable();

            String Sellect = "";
            Sellect = Sellect + "SELECT [CustomerID] " + "\n";
            Sellect = Sellect + "      ,[CompanyName] " + "\n";
            Sellect = Sellect + "      ,[ContactName] " + "\n";
            Sellect = Sellect + "      ,[ContactTitle] " + "\n";
            Sellect = Sellect + "      ,[Address] " + "\n";
            Sellect = Sellect + "      ,[City] " + "\n";
            Sellect = Sellect + "      ,[Region] " + "\n";
            Sellect = Sellect + "      ,[PostalCode] " + "\n";
            Sellect = Sellect + "      ,[Country] " + "\n";
            Sellect = Sellect + "      ,[Phone] " + "\n";
            Sellect = Sellect + "      ,[Fax] " + "\n";
            Sellect = Sellect + "  FROM [dbo].[Customers]";

            SqlDataAdapter adapter = new SqlDataAdapter(Sellect, DataBase.ConnectionString);
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
