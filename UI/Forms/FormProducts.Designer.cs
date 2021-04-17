
namespace UI.Forms
{
    partial class FormProducts
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
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TBQuantity = new System.Windows.Forms.TextBox();
            this.TBUnit = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductionDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TBEXP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TBCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Add New Item";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBQuantity
            // 
            this.TBQuantity.Location = new System.Drawing.Point(182, 172);
            this.TBQuantity.Name = "TBQuantity";
            this.TBQuantity.Size = new System.Drawing.Size(169, 22);
            this.TBQuantity.TabIndex = 17;
            // 
            // TBUnit
            // 
            this.TBUnit.Location = new System.Drawing.Point(182, 230);
            this.TBUnit.Name = "TBUnit";
            this.TBUnit.Size = new System.Drawing.Size(169, 22);
            this.TBUnit.TabIndex = 16;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(182, 122);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(169, 22);
            this.TBName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(719, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "List Of All Itmes";
            // 
            // listOfItems
            // 
            this.listOfItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listOfItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfItems.Location = new System.Drawing.Point(414, 62);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.RowHeadersWidth = 51;
            this.listOfItems.RowTemplate.Height = 24;
            this.listOfItems.Size = new System.Drawing.Size(749, 423);
            this.listOfItems.TabIndex = 10;
            this.listOfItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOfItems_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Production Date";
            // 
            // ProductionDate
            // 
            this.ProductionDate.Location = new System.Drawing.Point(124, 320);
            this.ProductionDate.Name = "ProductionDate";
            this.ProductionDate.Size = new System.Drawing.Size(256, 22);
            this.ProductionDate.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "EXP";
            // 
            // TBEXP
            // 
            this.TBEXP.Location = new System.Drawing.Point(182, 372);
            this.TBEXP.Name = "TBEXP";
            this.TBEXP.Size = new System.Drawing.Size(169, 22);
            this.TBEXP.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Code";
            // 
            // TBCode
            // 
            this.TBCode.Location = new System.Drawing.Point(182, 73);
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(169, 22);
            this.TBCode.TabIndex = 25;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 509);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TBEXP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProductionDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBQuantity);
            this.Controls.Add(this.TBUnit);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfItems);
            this.Name = "FormProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBQuantity;
        private System.Windows.Forms.TextBox TBUnit;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView listOfItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ProductionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBEXP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBCode;
    }
}