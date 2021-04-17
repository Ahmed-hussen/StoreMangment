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
    public partial class EditStore : Form
    {
        public int Id;
        Stores _Formstore;
        public EditStore(int id, Stores Formstore)
        {
            Id = id;
            _Formstore = Formstore;
            InitializeComponent();
        }
        Model1 db = new Model1();
        private void EditStore_Load(object sender, EventArgs e)
        {
            WareHouse store = new WareHouse();
            store = db.WareHouses.SingleOrDefault(s => s.Id == Id);
            TBAddress.Text = store.Address;
            TBName.Text = store.Name;
            TBSupervisor.Text = store.Supervisor;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WareHouse store = new WareHouse();
            store = db.WareHouses.SingleOrDefault(s => s.Id == Id);
            store.Name = TBName.Text;
            store.Address = TBAddress.Text;
            store.Supervisor = TBSupervisor.Text;
            db.SaveChanges();
            MessageBox.Show("Done");
            this.Close();
         
            _Formstore.listOfStores.DataSource = db.WareHouses.Select(s => new { s.Id, s.Name, s.Address, s.Supervisor }).ToList();
       
        
        }
    }
}
