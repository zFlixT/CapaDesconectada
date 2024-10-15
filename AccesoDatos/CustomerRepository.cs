using AccesoDatos;
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

        public Customer ObtenerPorId(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                var dataTable = new DataTable();

                String selectForId = "";
                selectForId = selectForId + "SELECT [CustomerID] " + "\n";
                selectForId = selectForId + "      ,[CompanyName] " + "\n";
                selectForId = selectForId + "      ,[ContactName] " + "\n";
                selectForId = selectForId + "      ,[ContactTitle] " + "\n";
                selectForId = selectForId + "      ,[Address] " + "\n";
                selectForId = selectForId + "      ,[City] " + "\n";
                selectForId = selectForId + "      ,[Region] " + "\n";
                selectForId = selectForId + "      ,[PostalCode] " + "\n";
                selectForId = selectForId + "      ,[Country] " + "\n";
                selectForId = selectForId + "      ,[Phone] " + "\n";
                selectForId = selectForId + "      ,[Fax] " + "\n";
                selectForId = selectForId + "  FROM [dbo].[Customers] " + "\n";
                selectForId = selectForId + "  Where CustomerID = @CustomerID";
                using (var commando = new SqlCommand(selectForId, conexion))
                {
                    commando.Parameters.AddWithValue("@CustomerID", id);
                    SqlDataAdapter adaptador = new SqlDataAdapter(commando);
                    adaptador.Fill(dataTable);
                    Customer cliente = ExtraerInfoCliente(dataTable);
                    return cliente;
                }
            }
        }

        public Customer ExtraerInfoCliente(DataTable dataTeble)
        {
            Customer customer = new Customer();
            foreach (DataRow fila in dataTeble.Rows)
            {
                customer.CustomerID = fila.Field<string>("CustomerID");
                customer.CompanyName = fila.Field<string>("CompanyName");
                customer.ContactName = fila.Field<string>("ContactName");
                customer.ContactTitle = fila.Field<string>("ContactTitle");
                customer.Address = fila.Field<string>("Address");
                customer.City = fila.Field<string>("City");
                customer.Region = fila.Field<string>("Region");
                customer.PostalCode = fila.Field<string>("PostalCode");
                customer.Country = fila.Field<string>("Country");
                customer.Phone = fila.Field<string>("Phone");
                customer.Fax = fila.Field<string>("Fax");
            }
            return customer; ;
        }

        public int InsertarCliente(Customer cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {

                String InsertarporId = "";
                InsertarporId = InsertarporId + "INSERT INTO [dbo].[Customers] " + "\n";
                InsertarporId = InsertarporId + "           ([CustomerID] " + "\n";
                InsertarporId = InsertarporId + "           ,[CompanyName] " + "\n";
                InsertarporId = InsertarporId + "           ,[ContactName] " + "\n";
                InsertarporId = InsertarporId + "           ,[ContactTitle] " + "\n";
                InsertarporId = InsertarporId + "           ,[Address]) " + "\n";
                InsertarporId = InsertarporId + "     VALUES " + "\n";
                InsertarporId = InsertarporId + "           (@CustomerID " + "\n";
                InsertarporId = InsertarporId + "           ,@CompanyName " + "\n";
                InsertarporId = InsertarporId + "           ,@ContactName " + "\n";
                InsertarporId = InsertarporId + "           ,@ContactTitle " + "\n";
                InsertarporId = InsertarporId + "           ,@Address)";

                using (var commando = new SqlCommand(InsertarporId, conexion))
                {
                    SqlCommand comando = parametrosSqlCustomers(commando, cliente);
                    SqlDataAdapter adaptador = new SqlDataAdapter(commando);
                    adaptador.InsertCommand = commando;
                    return adaptador.InsertCommand.ExecuteNonQuery();
                }
            }
        }

        public int ActualizarCliente(Customer cliente)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String updateUser = "";
                updateUser = updateUser + "UPDATE [dbo].[Customers] " + "\n";
                updateUser = updateUser + "   SET [CustomerID] = @CustomerID " + "\n";
                updateUser = updateUser + "      ,[CompanyName] = @CompanyName " + "\n";
                updateUser = updateUser + "      ,[ContactName] = @ContactName " + "\n";
                updateUser = updateUser + "      ,[ContactTitle] = @ContactTitle " + "\n";
                updateUser = updateUser + "      ,[Address] = @Address " + "\n";
                updateUser = updateUser + " WHERE CustomerID = @CustomerID";
                using (var commando = new SqlCommand(updateUser, conexion))
                {
                    SqlCommand comando = parametrosSqlCustomers(commando, cliente);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.UpdateCommand = comando;
                    return adapter.UpdateCommand.ExecuteNonQuery();
                }
            }
        }

        private SqlCommand parametrosSqlCustomers (SqlCommand comando, Customer cliente)
        {
            comando.Parameters.AddWithValue("CustomerID", cliente.CustomerID);
            comando.Parameters.AddWithValue("CompanyName", cliente.CompanyName);
            comando.Parameters.AddWithValue("ContactName", cliente.ContactName);
            comando.Parameters.AddWithValue("ContactTitle", cliente.ContactTitle);
            comando.Parameters.AddWithValue("Address", cliente.Address);
            return comando;
        }
        public int EliminarCliente(string id)
        {
            using (var conexion = DataBase.GetSqlConnection())
            {
                String deleteCliente = "";
                deleteCliente = deleteCliente + "DELETE FROM [dbo].[Customers] " + "\n";
                deleteCliente = deleteCliente + "      WHERE CustomerID = @CustomerID";
                using (var comando = new SqlCommand(deleteCliente, conexion))
                {
                    comando.Parameters.AddWithValue("@CustomerID", id);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = comando;
                    var eliminadas = adapter.DeleteCommand.ExecuteNonQuery();
                    return eliminadas;
                }
            }
        }
    }
}
