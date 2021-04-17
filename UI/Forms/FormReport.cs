using MoreLinq;
using MoreLinq.Extensions;
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
    public partial class FormReport : Form
    {
        Model1 db = new Model1();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            LoadTheme();
        }
        private void LoadTheme()
        {


            label1.ForeColor = ThemeColor.SecondaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            button1.ForeColor = ThemeColor.SecondaryColor;
          
            StoreInfo.ForeColor = ThemeColor.SecondaryColor;
            ItemsInfo.ForeColor = ThemeColor.SecondaryColor;
            label11.ForeColor = ThemeColor.SecondaryColor;


            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.SecondaryColor;
            button3.ForeColor = ThemeColor.SecondaryColor;
            ItemInStores.ForeColor = ThemeColor.SecondaryColor;
           


            label7.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            BTNView.ForeColor = ThemeColor.SecondaryColor;

            dataGridView1.ForeColor = ThemeColor.SecondaryColor;
            dataGridView2.ForeColor = ThemeColor.SecondaryColor;
            dataGridView3.ForeColor = ThemeColor.SecondaryColor;

            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.SecondaryColor;
            period.ForeColor = ThemeColor.SecondaryColor;
            label10.ForeColor = ThemeColor.SecondaryColor;
            periodList.ForeColor = ThemeColor.SecondaryColor;

            button2.ForeColor = ThemeColor.SecondaryColor;
            dataGridView4.ForeColor = ThemeColor.SecondaryColor;
        }


        private void CBStore_Click(object sender, EventArgs e)
        {
            var stores = db.WareHouses.ToList();

            CBStore.Items.Clear();
            foreach (var item in stores)
            {
                CBStore.Items.Add(item.Name);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            var wareHoseInfo = db.WareHouses.Where(S => S.Name == (string)CBStore.SelectedItem).SingleOrDefault();

            StoreInfo.DataSource = db.WareHouses.Where(S => S.Id == wareHoseInfo.Id).Select(s => new { s.Id, s.Name, s.Supervisor }).ToList();


            ItemsInfo.DataSource = db.WareHouseItems
                .Where(S => S.IdWareHouse == wareHoseInfo.Id)
                .Select(s => new { s.Id, s.Item.Name, s.Item.ProductionDate, s.Quantity, s.Item.code, s.Item.EXP, s.Item.ProductionDate.Value })
                .ToList();

        }

        private void CBItems_Click(object sender, EventArgs e)
        {
            var items = db.Items.ToList();

            CBItems.Items.Clear();
            foreach (var item in items)
            {
                CBItems.Items.Add(item.Name);
            }
        }
        private void CBItems_SelectedValueChanged(object sender, EventArgs e)
        {
            CBStores2.Enabled = true;
        }
        private void CBStores2_Click(object sender, EventArgs e)
        {
            var itemInfo = db.Items.Where(S => S.Name == (string)CBItems.SelectedItem).SingleOrDefault();
            var stores = db.WareHouseItems.Where(S => S.IdItem == itemInfo.ID).Select(S => new { S.WareHouse.Name }).ToList().Distinct();
            CBStores2.Items.Clear();

            foreach (var item in stores)
            {

                CBStores2.Items.Add(item.Name);

            }

            if (CBItems.SelectedItem!=null)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ItemsInfo = db.Items.Where(S => S.Name == (string)CBItems.SelectedItem).SingleOrDefault();
            var storeInfo = db.WareHouses.Where(S => S.Name == (string)CBStores2.SelectedItem).SingleOrDefault();
            ItemInStores.DataSource = db.WareHouseItems.Where(S => S.IdWareHouse == storeInfo.Id && S.IdItem == ItemsInfo.ID).Select(S => new { S.WareHouse.Id, S.WareHouse.Name, S.Item.Quantity, S.Item.ProductionDate }).ToList();
        }

        private void BTNView_Click(object sender, EventArgs e)
        {
            var start = Start.Value;
            var end = End.Value;
       
        dataGridView1.DataSource = db.WareHouseSuppliers.Where(s => s.TransfareDate > Start.Value && s.TransfareDate < End.Value).Select(s => new { s.Item.Name, s.Quantity, s.Item.ProductionDate, s.Item.code }).ToList();
        dataGridView2.DataSource = db.WareHouseSuppliers.Where(s => s.TransfareDate > Start.Value && s.TransfareDate < End.Value).Select(s => new { s.WareHouse.Name, s.Quantity, s.WareHouse.Supervisor, s.WareHouse.TransfareDate }).ToList();
        dataGridView3.DataSource = db.WareHouseSuppliers.Where(s => s.TransfareDate > Start.Value && s.TransfareDate < End.Value).Select(s => new { s.Supplier.Name, s.Supplier.Email, s.Supplier.Fax }).ToList();

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            var stores = db.WareHouseItems.ToList().Distinct();

            comboBox1.Items.Clear();
            foreach (var item in stores)
            {
                comboBox1.Items.Add(item.WareHouse.Name);
            }
        }

        private void period_Click(object sender, EventArgs e)
        {
            var start = dateTimeStart.Value;
            var end = dateTimeEnd.Value;
            var storeInfo = db.WareHouses.Where(i => i.Name == (string)comboBox1.SelectedItem).SingleOrDefault();

            periodList.DataSource = db.WareHouseSuppliers.Where(s => s.TransfareDate > dateTimeStart.Value && s.TransfareDate < dateTimeEnd.Value&&s.IdWareHouse==storeInfo.Id).Select(i=>new { i.Item.Name,i.Item.Quantity,i.Item.ProductionDate}).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dateNow = DateTime.Now.Year;

            dataGridView4.DataSource = db.Items.Where(s => s.ProductionDate.Value.Year + s.EXP - dateNow <= 2)
                .Select(s => new { s.Name, s.Quantity, s.ProductionDate, s.Unit }).ToList();
        }
    }


}

