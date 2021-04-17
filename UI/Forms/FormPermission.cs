using MoreLinq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
   
    public partial class FormPermission : Form
    {
        Model1 ENT = new Model1();
        public FormPermission()
        {
            InitializeComponent();
        }

        private void FormPermission_Load(object sender, EventArgs e)
        {
           
            tabPage1_Click( sender,  e);
            tabPage2_Click( sender,  e);
            LoadTheme();
        }
        private void LoadTheme()
        {
    
            BtnAdd.BackColor = ThemeColor.PrimaryColor;
            BtnAdd.ForeColor = Color.White;
            BtnAdd.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;    
            label6.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;
            ListOfSupplyPermission.ForeColor = ThemeColor.SecondaryColor;

            button1.BackColor = ThemeColor.PrimaryColor;
            button1.ForeColor = Color.White;
            button1.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            label16.ForeColor = ThemeColor.SecondaryColor;
            label15.ForeColor = ThemeColor.SecondaryColor;
            label12.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
            label17.ForeColor = ThemeColor.SecondaryColor;
            label18.ForeColor = ThemeColor.PrimaryColor;
            label13.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
       
            ListOfExchangePermission.ForeColor = ThemeColor.SecondaryColor;

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ListOfSupplyPermission.DataSource = ENT.WareHouseSuppliers.Select(P => new {P.id, P.IdItem, P.IdSupplier, P.IdWareHouse, P.LicenseDate, P.LicenseNum, P.Quantity}).ToList();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Controls";
            btn.Name = "Controls";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            ListOfSupplyPermission.Columns.Add(btn);
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            ListOfExchangePermission.DataSource = ENT.WithDraws.Select(P => new { P.Id,P.IdItem, P.IdSupplier, P.IdWareHouse, P.IdCustomer, P.LicenseNum, P.Quantity }).ToList();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Controls";
            btn.Name = "Controls";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            ListOfExchangePermission.Columns.Add(btn);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            WareHouseSupplier Sperm = new WareHouseSupplier();
             //|| CBCust.SelectedItem == null || CBItems.SelectedItem == null || CBStore.SelectedItem == null || CBSupplier.SelectedItem == null
            WareHouseItem store = new WareHouseItem();

            var itemInfo = ENT.Items.Where(r => r.Name == (string)comboBox1.SelectedItem).SingleOrDefault(); 
            var supplierInfo = ENT.Suppliers.Where(r => r.Name == (string)comboBox2.SelectedItem).SingleOrDefault();
            var storeInfo = ENT.WareHouses.Where(r => r.Name == (string)comboBox3.SelectedItem).SingleOrDefault();

            try
            {

                if (string.IsNullOrWhiteSpace(TBQuantity.Text) || string.IsNullOrWhiteSpace(TBPermitNUM.Text))
                {
                    MessageBox.Show("Please Complete empty Field");
                }

                else if (Convert.ToInt32(TBQuantity.Text) > itemInfo.Quantity)
                {
                    MessageBox.Show("this Quantity Greater than item Quantity");
                }


                else
                {
                    Sperm.IdItem = itemInfo.ID;
                    Sperm.IdSupplier = supplierInfo.Id;
                    Sperm.IdWareHouse = storeInfo.Id;

                    store.IdItem = itemInfo.ID;
                    store.IdWareHouse = storeInfo.Id;

                    Sperm.LicenseDate = LicenseDate.Value; //permission date
                    
                    store.Quantity = Convert.ToInt32(TBQuantity.Text);
                    Sperm.Quantity = Convert.ToInt32(TBQuantity.Text);
                    var quantity = itemInfo.Quantity - Convert.ToInt32(TBQuantity.Text);
                    itemInfo.Quantity = quantity;
                    Sperm.LicenseNum = Convert.ToInt32(TBPermitNUM.Text);

                    ENT.WareHouseSuppliers.Add(Sperm);
                    ENT.WareHouseItems.Add(store);
                    ENT.SaveChanges();

                    MessageBox.Show("Done");
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    TBQuantity.Text = string.Empty;
                    TBPermitNUM.Text = string.Empty;

                    ListOfSupplyPermission.DataSource = ENT.WareHouseSuppliers.Select(P => new { P.id, P.IdItem, P.IdSupplier, P.IdWareHouse, P.LicenseDate, P.LicenseNum, P.Quantity }).ToList();

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Please Invalid Inputs");
            }



        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

   

            var items = from u in ENT.Items
                        join a in ENT.WareHouseItems
                        on u.ID equals a.IdItem into userAssignments
                        from ua in userAssignments.DefaultIfEmpty()
                            //  where u.ID != a.IdItem
                        where ua == null
                        select new
                        {
                            Name = u.Name
                        };

            comboBox1.Items.Clear();
            foreach (var v in items)
            {
                
             comboBox1.Items.Add(v.Name);

            }

          
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            //   var supliers = from S in ENT.Suppliers
            //                select S;
            var supliers = ENT.Suppliers.ToList();
             comboBox2.Items.Clear();
            foreach (var v in supliers)
            {
                comboBox2.Items.Add(v.Name);
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            var store = ENT.WareHouses.ToList();
            comboBox3.Items.Clear();
            foreach (var v in store)
            {
                comboBox3.Items.Add(v.Name);
            }
        }

        private void CBStore_Click(object sender, EventArgs e)
        {
    
            var storeItem = ENT.WareHouseItems.Where(r => r.WareHouse.Id == r.IdWareHouse).ToList().DistinctBy(r=>r.IdWareHouse);

            CBStore.Items.Clear();
            foreach (var v in storeItem)
            {
                CBStore.Items.Add(v.WareHouse.Name);
            }

            CBItems.Enabled=true;
        }

        private void CBItems_Click(object sender, EventArgs e)
        {
            var storeInfo = ENT.WareHouses.Where(r => r.Name == (string)CBStore.SelectedItem).SingleOrDefault();
           
            var storeItems = from s in ENT.Items
                             join store in ENT.WareHouseItems
                             on s.ID equals store.IdItem
                             where store.IdWareHouse == storeInfo.Id
                             select new
                             {
                                 Name = s.Name
                             };

            CBItems.Items.Clear();
            foreach (var v in storeItems)
            {
                CBItems.Items.Add(v.Name);
            }

            CBSupplier.Enabled = true;
        }

        private void CBSupplier_Click(object sender, EventArgs e)
        {
            var ItemsInfo = ENT.Items.Where(r => r.Name == (string)CBItems.SelectedItem).SingleOrDefault();

            var supplierItems = from s in ENT.Suppliers
                             join store in ENT.WareHouseSuppliers
                             on s.Id equals store.IdSupplier
                             where store.IdItem== ItemsInfo.ID
                             select new
                             {
                                 Name = s.Name
                             };
            CBSupplier.Items.Clear();
            foreach (var v in supplierItems)
            {
                CBSupplier.Items.Add(v.Name);
            }
        }
        private void CBCust_Click(object sender, EventArgs e)
        {
            var customers = ENT.Customers.ToList();

            CBCust.Items.Clear();
            foreach (var v in customers)
            {
                CBCust.Items.Add(v.Name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var itemInfo = ENT.Items.Where(r => r.Name == (string)CBItems.SelectedItem).SingleOrDefault();
            var supplierInfo = ENT.Suppliers.Where(r => r.Name == (string)CBSupplier.SelectedItem).SingleOrDefault();
            var storeInfo = ENT.WareHouses.Where(r => r.Name == (string)CBStore.SelectedItem).SingleOrDefault();
            var Customers = ENT.Customers.Where(r => r.Name == (string)CBCust.SelectedItem).SingleOrDefault();
            var wareHouseItems = ENT.WareHouseItems.Where(r => r.IdItem == itemInfo.ID).SingleOrDefault();

            WithDraw Sperm = new WithDraw();
            try
            {
                if (string.IsNullOrWhiteSpace(TBQuntity.Text) || string.IsNullOrWhiteSpace(TBNUM.Text))
                {
                    MessageBox.Show("Please Complete empty Field");
                }

                else if (Convert.ToInt32(TBQuntity.Text) > wareHouseItems.Quantity)
                {
                    MessageBox.Show("this Quantity Greater than item Quantity");
                }
                else
                {

                    Sperm.IdItem = itemInfo.ID;
                    Sperm.IdSupplier = supplierInfo.Id;
                    Sperm.IdWareHouse = storeInfo.Id;
                    Sperm.IdCustomer = Customers.IdCustomers;

                    Sperm.LicenseData = date.Value;
                    Sperm.Quantity = Convert.ToInt32(TBQuntity.Text);
                    Sperm.LicenseNum = Convert.ToInt32(TBNUM.Text);

                    ENT.WithDraws.Add(Sperm);
                    ENT.SaveChanges();

                    MessageBox.Show("Done");
                    CBItems.SelectedItem = string.Empty;
                    CBSupplier.SelectedItem = string.Empty;
                    CBStore.SelectedItem = string.Empty;
                    TBQuntity.Text = string.Empty;
                    TBNUM.Text = string.Empty;

                    ListOfExchangePermission.DataSource = ENT.WithDraws.Select(P => new {P.Id, P.IdItem, P.IdSupplier, P.IdWareHouse, P.LicenseNum, P.Quantity}).ToList();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Field");
            }
        

        }

        private void ListOfSupplyPermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = (int)ListOfSupplyPermission.CurrentRow.Cells[1].Value;
                EditSupPermission form = new EditSupPermission(id, this);
                form.Show();
            }

        }

        private void ListOfExchangePermission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = (int)ListOfExchangePermission.CurrentRow.Cells[1].Value;
                EditExchangPermission form = new EditExchangPermission(id, this);
                form.Show();
            }
        }
    }
}
