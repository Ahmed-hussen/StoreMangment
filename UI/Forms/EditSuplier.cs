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
    public partial class EditSuplier : Form
    {
        public int Id;
        FormClients _clients;
        public EditSuplier(int id, FormClients clients)
        {
            _clients = clients;
            Id = id;
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void EditSuplier_Load(object sender, EventArgs e)
        {

            Supplier item = new Supplier();
            item = db.Suppliers.SingleOrDefault(s => s.Id == Id);
            TBName.Text = item.Name;
            TBEmail.Text = item.Email.ToString();
            TBFax.Text = item.Fax;
            TBHome.Text = item.HomeNumber;
            TBTele.Text = item.Telephone;
            TBWeb.Text = item.Website;

       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier suplier = new Supplier();
            suplier = db.Suppliers.SingleOrDefault(s => s.Id == Id);
            suplier.HomeNumber = TBHome.Text;
            suplier.Name = TBName.Text;
            suplier.Telephone = TBTele.Text;
            suplier.Website = TBWeb.Text;
            suplier.Fax = TBHome.Text;
            suplier.Email = TBEmail.Text;
            db.SaveChanges();
            MessageBox.Show("Done");
            this.Close();

            _clients.listOfSupliers.DataSource = db.Suppliers.Select(p => new { p.Id, p.Name, p.Email, p.Telephone, p.HomeNumber, p.Website, p.Fax }).ToList();


        }
    }
}
