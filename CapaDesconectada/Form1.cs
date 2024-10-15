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
            if (cliente == null)
            {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null)
            {
                var listaClientes = new List<Customer> { cliente};
                gridNoTipado.DataSource = listaClientes;
            }
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }

        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = tbxCustomerID.Text,
                CompanyName = tbxCompanyName.Text,
                ContactName = tbxContactName.Text,
                ContactTitle = tbxContactTitle.Text,
                Address = tbxAddres.Text,
            };
            MessageBox.Show(cliente.CustomerID);
            MessageBox.Show(cliente.CompanyName);
            MessageBox.Show(cliente.ContactName);
            MessageBox.Show(cliente.ContactTitle);
            MessageBox.Show(cliente.Address);
            return cliente;
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
        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            adaptador.Insert(cliente.CustomerID, cliente.CompanyName, cliente.ContactName, cliente.ContactTitle, cliente.Address, cliente.City, cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone,cliente.Fax
            );
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

    }
}
