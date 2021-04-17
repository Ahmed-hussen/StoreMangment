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
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void FormClients_Load(object sender, EventArgs e)
        {
            LoadTheme();
            tabPage1_Click(sender,  e);
            tabPage2_Click(sender,  e);
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            listOfSupliers.DataSource = db.Suppliers.Select(p => new { p.Id, p.Name,p.Email, p.Telephone,p.HomeNumber, p.Website,p.Fax }).ToList();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Controls";
            btn.Name = "Controls";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            listOfSupliers.Columns.Add(btn);
            
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            ListOfCust.DataSource = db.Customers.Select(p => new { p.IdCustomers, p.Name, p.Email, p.Telephone, p.HomeNumebr, p.Website, p.Fax }).ToList();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Controls";
            btn.Name = "Controls";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            ListOfCust.Columns.Add(btn);
        }
        private void LoadTheme()
        {
      

            button1.BackColor = ThemeColor.PrimaryColor;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            button2.BackColor = ThemeColor.PrimaryColor;
            button2.ForeColor = Color.White;
            button2.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;
            listOfSupliers.ForeColor = ThemeColor.SecondaryColor;
            //Customer
            label11.ForeColor = ThemeColor.SecondaryColor;
            lable12.ForeColor = ThemeColor.SecondaryColor;
            label13.ForeColor = ThemeColor.SecondaryColor;
            label14.ForeColor = ThemeColor.SecondaryColor;
            label15.ForeColor = ThemeColor.PrimaryColor;
            lable16.ForeColor = ThemeColor.PrimaryColor;
            ListOfCust.ForeColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Supplier suplier = new Supplier();
            suplier.HomeNumber = TBHome.Text;
            suplier.Name = TBName.Text;
            suplier.Telephone = TBTele.Text;
            suplier.Website = TBWeb.Text;
            suplier.Fax = TBHome.Text;
            suplier.Email = TBEmail.Text;
            db.Suppliers.Add(suplier);
            db.SaveChanges();
            TBHome.Text=string.Empty;
            TBName.Text= string.Empty;
            TBTele.Text= string.Empty;
            TBWeb.Text= string.Empty;
            TBHome.Text= string.Empty;
            TBEmail.Text= string.Empty;
            TBFax.Text= string.Empty;

            listOfSupliers.DataSource = db.Suppliers.Select(p => new { p.Id, p.Name, p.Email, p.Telephone, p.HomeNumber, p.Website, p.Fax }).ToList();

        }

        private void listOfSupliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = (int)listOfSupliers.CurrentRow.Cells[1].Value;
                EditSuplier form = new EditSuplier(id, this);
                form.Show();
            }
        }

        private void CustomerTab_Selected(object sender, TabControlEventArgs e)
        {
            ListOfCust.DataSource = db.Customers.Select(p => new { p.IdCustomers, p.Name, p.Email, p.Telephone, p.HomeNumebr, p.Website, p.Fax }).ToList();
        
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.HomeNumebr = TBHomeCust.Text;
            customer.Name = TBNameCust.Text;
            customer.Telephone = TBTeleCust.Text;
            customer.Website = TBWebCust.Text;
            customer.Fax = TBHomeCust.Text;
            customer.Email = TBEmailCust.Text;
            db.Customers.Add(customer);
            db.SaveChanges();
            TBHomeCust.Text = string.Empty;
            TBNameCust.Text = string.Empty;
            TBTeleCust.Text = string.Empty;
            TBWebCust.Text = string.Empty;
            TBHomeCust.Text = string.Empty;
            TBEmailCust.Text = string.Empty;

            ListOfCust.DataSource = db.Customers.Select(p => new { p.IdCustomers, p.Name, p.Email, p.Telephone, p.HomeNumebr, p.Website, p.Fax }).ToList();

        }

        private void ListOfCust_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = (int)ListOfCust.CurrentRow.Cells[1].Value;
                EditCustomer form = new EditCustomer(id, this);
                form.Show();
            }

        }

  
    }
}
