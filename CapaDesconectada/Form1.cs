using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            DataTable  dataTable = new DataTable();

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

            var conexion = @"Data Source=MAURIPC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;";
            SqlDataAdapter adapter = new SqlDataAdapter(Sellect, conexion);
            adapter.Fill(dataTable);
            gridNoTipado.DataSource = dataTable;
        }
    }
}
