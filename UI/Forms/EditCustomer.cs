using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class EditCustomer : Form
    {
        public int Id;
        FormClients _clients;
        public EditCustomer(int id, FormClients clients)
        {
            _clients = clients;
            Id = id;
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            Customer item = new Customer();
            item = db.Customers.SingleOrDefault(s => s.IdCustomers == Id);
            TBName.Text = item.Name;
            TBEmail.Text = item.Email.ToString();
            TBFax.Text = item.Fax;
            TBHome.Text = item.HomeNumebr;
            TBTele.Text = item.Telephone;
            TBWeb.Text = item.Website;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer suplier = new Customer();
            suplier = db.Customers.SingleOrDefault(s => s.IdCustomers == Id);
            suplier.HomeNumebr = TBHome.Text;
            suplier.Name = TBName.Text;
            suplier.Telephone = TBTele.Text;
            suplier.Website = TBWeb.Text;
            suplier.Fax = TBHome.Text;
            suplier.Email = TBEmail.Text;
            db.SaveChanges();
            MessageBox.Show("Done");
            this.Close();

            _clients.ListOfCust.DataSource = db.Customers.Select(p => new { p.IdCustomers, p.Name, p.Email, p.Telephone, p.HomeNumebr, p.Website, p.Fax }).ToList();

        }
    }
}
