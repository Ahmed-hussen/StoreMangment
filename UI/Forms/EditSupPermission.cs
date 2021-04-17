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
    public partial class EditSupPermission : Form
    {
        Model1 db = new Model1();

        public int Id;
        FormPermission _formPermission;
        public EditSupPermission(int id, FormPermission formPermission)
        {
            InitializeComponent();
            Id = id;
            _formPermission = formPermission;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            WareHouseSupplier Sup = new WareHouseSupplier();
            WareHouseItem wareHouseItem = new WareHouseItem();
            var ItemInfo = db.Items.Where(S => S.Name == comboBox1.Text).FirstOrDefault(); 
            var supplierInfo=db.Suppliers.Where(S=>S.Name==comboBox2.Text).FirstOrDefault();
            var WareHouseInfo=db.WareHouses.Where(S=>S.Name== comboBox3.Text).FirstOrDefault();
            

            Sup = db.WareHouseSuppliers.SingleOrDefault(s => s.id == Id);
            Sup.IdItem = ItemInfo.ID;
            Sup.IdSupplier = supplierInfo.Id;
            Sup.IdWareHouse = WareHouseInfo.Id;
            wareHouseItem.IdWareHouse= WareHouseInfo.Id;
            wareHouseItem.Quantity= int.Parse(TBQuantity.Text);
            wareHouseItem.IdItem= ItemInfo.ID;
            Sup.Quantity = int.Parse(TBQuantity.Text);
            Sup.LicenseNum = int.Parse(TBPermitNUM.Text);
            Sup.LicenseDate = LicenseDate.Value;

            
            db.SaveChanges();
            MessageBox.Show("Done");
            this.Close();

            _formPermission.ListOfSupplyPermission.DataSource = db.WareHouseSuppliers.Select(P => new { P.id, P.IdItem, P.IdSupplier, P.IdWareHouse, P.LicenseDate, P.LicenseNum, P.Quantity }).ToList();


        }

        private void EditSupPermission_Load(object sender, EventArgs e)
        {

            WareHouseSupplier item = new WareHouseSupplier();
            item = db.WareHouseSuppliers.SingleOrDefault(s => s.id == Id);
            comboBox1.Text = item.Item.Name;
            comboBox2.Text = item.Supplier.Name.ToString();
            comboBox3.Text = item.WareHouse.Name;
            TBQuantity.Text = item.Quantity.ToString();
            TBPermitNUM.Text = item.LicenseNum.ToString();
            LicenseDate.Value = item.LicenseDate.Value;

        }
    }
}
