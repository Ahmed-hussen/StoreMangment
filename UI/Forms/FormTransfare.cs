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
    public partial class FormTransfare : Form
    {
        Model1 db = new Model1();
        public FormTransfare()
        {
            InitializeComponent();
        }

        private void FormTransfare_Load(object sender, EventArgs e)
        {

            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label17.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.SecondaryColor;
           
        }

        private void CBFrom_Click(object sender, EventArgs e)
        {

            var store = from s in db.WareHouses
                        join r in db.WareHouseItems
                        on s.Id equals r.IdWareHouse
                        select new
                        {
                            Name=s.Name
                        };
            CBFrom.Items.Clear();
            foreach (var item in store)
            {
                CBFrom.Items.Add(item.Name);
            }

            CBItems.Enabled = true;
            
        }

        private void CBTo_Click(object sender, EventArgs e)
        {

            var store = db.WareHouses.ToList();

            CBTo.Items.Clear();
            foreach (var item in store)
            {
                if (item.Name== (string)CBFrom.SelectedItem)
                {
                            
                }
                else
                {
                    CBTo.Items.Add(item.Name);

                }
            }
        }
        private void CBSupplier_Click(object sender, EventArgs e)
        {
            var supplier = db.Suppliers.ToList();

            CBSupplier.Items.Clear();
            foreach (var item in supplier)
            {
                CBSupplier.Items.Add(item.Name);
            }
        }
        private void CBItems_Click(object sender, EventArgs e)
        {
            var storeInfo = db.WareHouses.Where(r => r.Name == (string)CBFrom.SelectedItem).SingleOrDefault();

            var storeItems = from s in db.Items
                             join store in db.WareHouseItems
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

        private void button1_Click(object sender, EventArgs e)
        {
            var itemInfo = db.Items.Where(r => r.Name == (string)CBItems.SelectedItem).SingleOrDefault();
            var supplierInfo = db.Suppliers.Where(r => r.Name == (string)CBSupplier.SelectedItem).SingleOrDefault();      
            var storeInfoFrom = db.WareHouses.Where(r => r.Name == (string)CBFrom.SelectedItem).SingleOrDefault();
            var storeInfoTo = db.WareHouses.Where(r => r.Name == (string)CBTo.SelectedItem).SingleOrDefault();

            WareHouseItem Item = new WareHouseItem();
            WareHouseSupplier Supplier = new WareHouseSupplier();

            Item items = new Item();
           
            var wareHouseItems = db.WareHouseItems.Where(r => r.IdWareHouse == storeInfoFrom.Id).SingleOrDefault();
            var wareHouseSupplier = db.WareHouseSuppliers.Where(r => r.IdWareHouse == storeInfoFrom.Id).SingleOrDefault();

            // items transfare
            wareHouseSupplier.IdItem = itemInfo.ID;
            wareHouseItems.IdItem = itemInfo.ID;
           
            // Quantity Transfar
            wareHouseItems.Quantity =Convert.ToInt32(TBQuntity.Text);
            wareHouseSupplier.Quantity= Convert.ToInt32(TBQuntity.Text);
            // supplier Transfare
            wareHouseSupplier.IdSupplier = supplierInfo.Id;
            // date
            wareHouseSupplier.LicenseDate = date.Value;
            // EXP
            items.EXP =Convert.ToInt32(TBEXP.Text);

            // store transfare
            wareHouseSupplier.IdWareHouse = storeInfoTo.Id;
            wareHouseItems.IdWareHouse = storeInfoTo.Id;

            db.SaveChanges();
            MessageBox.Show("Done");
        }


    }
}
