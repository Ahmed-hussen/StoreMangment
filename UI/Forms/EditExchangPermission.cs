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
    public partial class EditExchangPermission : Form
    {
        public int Id;
        FormPermission _FormPermission;
        public EditExchangPermission(int id, FormPermission formPermission)
        {
            Id = id;
            _FormPermission = formPermission;
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void EditExchangPermission_Load(object sender, EventArgs e)
        {
            WithDraw item = new WithDraw();
            item = db.WithDraws.SingleOrDefault(s => s.Id == Id);
            comboBox1.Text = item.Item.Name.ToString();
            comboBox2.Text = item.Supplier.Name.ToString();
            comboBox3.Text = item.WareHouse.Name.ToString();
          
            TBQuantity.Text = item.Quantity.ToString();
            TBPermitNUM.Text = item.LicenseNum.ToString();
  
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
       

           
            try
            {
                WithDraw Sperm = new WithDraw();
                var itemInfo = db.Items.Where(r => r.Name == (string)comboBox1.SelectedItem).SingleOrDefault();
                var supplierInfo = db.Suppliers.Where(r => r.Name == (string)comboBox2.SelectedItem).SingleOrDefault();
                var storeInfo = db.WareHouses.Where(r => r.Name == (string)comboBox3.SelectedItem).SingleOrDefault();
                var Customers = db.Customers.Where(r => r.Name == (string)CBCust.SelectedItem).SingleOrDefault();
                var wareHouseItems = db.WareHouseItems.Where(r => r.IdItem == itemInfo.ID).SingleOrDefault();
                if (string.IsNullOrWhiteSpace(TBQuantity.Text) || string.IsNullOrWhiteSpace(TBPermitNUM.Text))
                {
                    MessageBox.Show("Please Complete empty Field");
                }

                else if (Convert.ToInt32(TBQuantity.Text) > wareHouseItems.Quantity)
                {
                    MessageBox.Show("this Quantity Greater than item Quantity");
                }
                else
                {

                    Sperm.IdItem = itemInfo.ID;
                    Sperm.IdSupplier = supplierInfo.Id;
                    Sperm.IdWareHouse = storeInfo.Id;
                    Sperm.IdCustomer = Customers.IdCustomers;

                    Sperm.LicenseData = LicenseDate.Value;
                    Sperm.Quantity = Convert.ToInt32(TBQuantity.Text);
                    Sperm.LicenseNum = Convert.ToInt32(TBPermitNUM.Text);

                    db.WithDraws.Add(Sperm);
                    db.SaveChanges();

                    MessageBox.Show("Done");
                    this.Close();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Field");
            }

        }
    }
}
