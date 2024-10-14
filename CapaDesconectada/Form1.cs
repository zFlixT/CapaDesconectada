using AccesoDatos;
using CapaDesconectada.NorthwindTableAdapters;
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
        #region No Tipado
        private CustomerRepository customerRepository = new CustomerRepository();
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNoTipado.DataSource = customerRepository.ObtenerTodos();
        }

        private void btnBuscarNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorId(tbxBusquedaNt.Text);

        }
        #endregion

        #region Tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;

        }
        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(tbxBusquedaTipado.Text);
            if (customer != null)
            {
                var objeto1 = customerRepository.ExtraerInfoCliente(customer);
                Console.WriteLine(customer);
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
