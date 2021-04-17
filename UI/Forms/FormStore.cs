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
    public partial class Stores : Form
    {
        Model1 db = new Model1();
        public Stores()
        {
            InitializeComponent();
        }
        private void FormStore_Load(object sender, EventArgs e)
        {
            listOfStores.DataSource = db.WareHouses.Select(s=>new {s.Id, s.Name,s.Address,s.Supervisor}).ToList();

            //DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
            //c.DataPropertyName = "Controle";
            //c.Name = "Controle"; 
            //listOfStores.Columns.Add(c);

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Controle";
            btn.Name = "Controle";
            btn.Text = "Edit";
            btn.UseColumnTextForButtonValue = true;
            listOfStores.Columns.Add(btn);
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
            listOfStores.ForeColor= ThemeColor.SecondaryColor;
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            WareHouse store = new WareHouse();
            store.Address = TBAddress.Text;
            store.Name = TBName.Text;
            store.Supervisor = TBSupervisor.Text;
            db.WareHouses.Add(store);
            db.SaveChanges();
            TBAddress.Text = string.Empty;
            TBName.Text = string.Empty;
            TBSupervisor.Text = string.Empty;
            MessageBox.Show("Store Is Added");
            listOfStores.DataSource = db.WareHouses.Select(s => new { s.Id, s.Name, s.Address, s.Supervisor }).ToList();


       
        }

        private void listOfStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.ColumnIndex == 0)
            {
            int id = (int)listOfStores.CurrentRow.Cells[1].Value;
            EditStore form = new EditStore(id,this);
            form.Show();
             }
        }
    }
}
