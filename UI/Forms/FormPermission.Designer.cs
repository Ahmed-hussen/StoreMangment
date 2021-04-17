
namespace UI.Forms
{
    partial class FormPermission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.ListOfSupplyPermission = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LicenseDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPermitNUM = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CBCust = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ListOfExchangePermission = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.TBQuntity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TBNUM = new System.Windows.Forms.TextBox();
            this.CBStore = new System.Windows.Forms.ComboBox();
            this.CBSupplier = new System.Windows.Forms.ComboBox();
            this.CBItems = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfSupplyPermission)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfExchangePermission)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1307, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.ListOfSupplyPermission);
            this.tabPage1.Controls.Add(this.BtnAdd);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.TBQuantity);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.LicenseDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TBPermitNUM);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1299, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Supply Permission";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(421, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "List Of Supply Permission";
            // 
            // ListOfSupplyPermission
            // 
            this.ListOfSupplyPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfSupplyPermission.Location = new System.Drawing.Point(328, 51);
            this.ListOfSupplyPermission.Name = "ListOfSupplyPermission";
            this.ListOfSupplyPermission.RowHeadersWidth = 51;
            this.ListOfSupplyPermission.RowTemplate.Height = 24;
            this.ListOfSupplyPermission.Size = new System.Drawing.Size(965, 455);
            this.ListOfSupplyPermission.TabIndex = 18;
            this.ListOfSupplyPermission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfSupplyPermission_CellClick);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(56, 371);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(141, 46);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantity";
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(116, 205);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(165, 22);
            this.TBQuantity.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Permission Date";
            // 
            // LicenseDate
            // 
            this.LicenseDate.Location = new System.Drawing.Point(122, 288);
            this.LicenseDate.Name = "LicenseDate";
            this.LicenseDate.Size = new System.Drawing.Size(200, 22);
            this.LicenseDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Permation Num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Supplier";
            // 
            // TBPermitNUM
            // 
            this.TBPermitNUM.Location = new System.Drawing.Point(116, 246);
            this.TBPermitNUM.Name = "TBPermitNUM";
            this.TBPermitNUM.Size = new System.Drawing.Size(165, 22);
            this.TBPermitNUM.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(116, 161);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(165, 24);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.Click += new System.EventHandler(this.comboBox3_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Click += new System.EventHandler(this.comboBox2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CBCust);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ListOfExchangePermission);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.TBQuntity);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.date);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.TBNUM);
            this.tabPage2.Controls.Add(this.CBStore);
            this.tabPage2.Controls.Add(this.CBSupplier);
            this.tabPage2.Controls.Add(this.CBItems);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1299, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Exchange Permission";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // CBCust
            // 
            this.CBCust.FormattingEnabled = true;
            this.CBCust.Location = new System.Drawing.Point(116, 336);
            this.CBCust.Name = "CBCust";
            this.CBCust.Size = new System.Drawing.Size(165, 24);
            this.CBCust.TabIndex = 40;
            this.CBCust.Click += new System.EventHandler(this.CBCust_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Customers";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(421, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(339, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "List Of Exchange Permission";
            // 
            // ListOfExchangePermission
            // 
            this.ListOfExchangePermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfExchangePermission.Location = new System.Drawing.Point(328, 62);
            this.ListOfExchangePermission.Name = "ListOfExchangePermission";
            this.ListOfExchangePermission.RowHeadersWidth = 51;
            this.ListOfExchangePermission.RowTemplate.Height = 24;
            this.ListOfExchangePermission.Size = new System.Drawing.Size(965, 455);
            this.ListOfExchangePermission.TabIndex = 37;
            this.ListOfExchangePermission.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfExchangePermission_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Quantity";
            // 
            // TBQuntity
            // 
            this.TBQuntity.Location = new System.Drawing.Point(116, 216);
            this.TBQuntity.Name = "TBQuntity";
            this.TBQuntity.Size = new System.Drawing.Size(165, 22);
            this.TBQuntity.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 17);
            this.label13.TabIndex = 31;
            this.label13.Text = "Permission Date";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(122, 299);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 17);
            this.label15.TabIndex = 28;
            this.label15.Text = "Permation Num";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 17);
            this.label16.TabIndex = 27;
            this.label16.Text = "Store";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 168);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 17);
            this.label17.TabIndex = 26;
            this.label17.Text = "Supplier";
            // 
            // TBNUM
            // 
            this.TBNUM.Location = new System.Drawing.Point(116, 257);
            this.TBNUM.Name = "TBNUM";
            this.TBNUM.Size = new System.Drawing.Size(165, 22);
            this.TBNUM.TabIndex = 24;
            // 
            // CBStore
            // 
            this.CBStore.FormattingEnabled = true;
            this.CBStore.Location = new System.Drawing.Point(116, 62);
            this.CBStore.Name = "CBStore";
            this.CBStore.Size = new System.Drawing.Size(165, 24);
            this.CBStore.TabIndex = 23;
            this.CBStore.Click += new System.EventHandler(this.CBStore_Click);
            // 
            // CBSupplier
            // 
            this.CBSupplier.Enabled = false;
            this.CBSupplier.FormattingEnabled = true;
            this.CBSupplier.Location = new System.Drawing.Point(116, 168);
            this.CBSupplier.Name = "CBSupplier";
            this.CBSupplier.Size = new System.Drawing.Size(165, 24);
            this.CBSupplier.TabIndex = 22;
            this.CBSupplier.Click += new System.EventHandler(this.CBSupplier_Click);
            // 
            // CBItems
            // 
            this.CBItems.Enabled = false;
            this.CBItems.FormattingEnabled = true;
            this.CBItems.Location = new System.Drawing.Point(116, 120);
            this.CBItems.Name = "CBItems";
            this.CBItems.Size = new System.Drawing.Size(165, 24);
            this.CBItems.TabIndex = 21;
            this.CBItems.Click += new System.EventHandler(this.CBItems_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "Items";
            // 
            // FormPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPermission";
            this.Text = "FormPermission";
            this.Load += new System.EventHandler(this.FormPermission_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfSupplyPermission)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfExchangePermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker LicenseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPermitNUM;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ListOfExchangePermission;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TBQuntity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TBNUM;
        private System.Windows.Forms.ComboBox CBStore;
        private System.Windows.Forms.ComboBox CBSupplier;
        private System.Windows.Forms.ComboBox CBItems;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox CBCust;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView ListOfSupplyPermission;
    }
}