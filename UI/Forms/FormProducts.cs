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
    public partial class FormProducts : Form
    {
        Model1 db = new Model1();
        public FormProducts()
        {
            InitializeComponent();
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            listOfItems.DataSource = db.Items.Select(p=>new { p.ID, p.code, p.Name,p.Quantity,p.ProductionDate,p.EXP}).ToList();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Controls";
            btn.Name = "Controls";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            listOfItems.Columns.Add(btn);
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
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label6.ForeColor = ThemeColor.PrimaryColor;
            label7.ForeColor = ThemeColor.PrimaryColor;
            label8.ForeColor = ThemeColor.PrimaryColor;
            listOfItems.ForeColor = ThemeColor.SecondaryColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = TBName.Text;
            item.Quantity=Convert.ToInt32(TBQuantity.Text);
            item.ProductionDate = ProductionDate.Value;
            item.Unit = TBUnit.Text;
            item.EXP = Convert.ToInt32(TBEXP.Text);
            item.code = TBCode.Text;
            db.Items.Add(item);
            db.SaveChanges();
            TBName.Text = string.Empty;
            TBQuantity.Text = string.Empty;
            TBUnit.Text = string.Empty;
            TBEXP.Text = string.Empty;
            listOfItems.DataSource = db.Items.Select(p => new { p.ID, p.code, p.Name, p.Quantity, p.ProductionDate, p.EXP }).ToList();

        }

        private void listOfItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int id = (int)listOfItems.CurrentRow.Cells[1].Value;
                EditItem form = new EditItem(id, this);
                form.Show();
            }
        }
    }
}
