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
    public partial class EditItem : Form
    {
        public int Id;
        FormProducts _item;
        public EditItem(int id, FormProducts item)
        {
            Id = id;
            _item = item;
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void EditItem_Load(object sender, EventArgs e)
        {
            Item item = new Item();
            item = db.Items.SingleOrDefault(s => s.ID == Id);
            TBName.Text = item.Name;
            TBEXP.Text = item.EXP.ToString();
            TBQuantity.Text = item.Quantity.ToString();
            TBUnit.Text = item.Unit;
            ProductionDate.Value = (DateTime)item.ProductionDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item = db.Items.SingleOrDefault(s => s.ID == Id);
            item.Name = TBName.Text;
            item.Quantity = Convert.ToInt32(TBQuantity.Text);
            item.ProductionDate = ProductionDate.Value;
            item.Unit = TBUnit.Text;
            item.EXP = Convert.ToInt32(TBEXP.Text);
            db.SaveChanges();
            MessageBox.Show("Done");
            this.Close();

            _item.listOfItems.DataSource = db.Items.Select(p => new { p.ID, p.Name, p.Quantity, p.ProductionDate, p.EXP }).ToList();


        }
    }
}
