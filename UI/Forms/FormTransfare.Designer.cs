
namespace UI.Forms
{
    partial class FormTransfare
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
            this.button1 = new System.Windows.Forms.Button();
            this.TBQuntity = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CBFrom = new System.Windows.Forms.ComboBox();
            this.CBItems = new System.Windows.Forms.ComboBox();
            this.CBTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBEXP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(485, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 46);
            this.button1.TabIndex = 53;
            this.button1.Text = "Transfare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TBQuntity
            // 
            this.TBQuntity.Location = new System.Drawing.Point(775, 83);
            this.TBQuntity.Name = "TBQuntity";
            this.TBQuntity.Size = new System.Drawing.Size(165, 22);
            this.TBQuntity.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(153, 177);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 26);
            this.label17.TabIndex = 46;
            this.label17.Text = "Items";
            // 
            // CBFrom
            // 
            this.CBFrom.FormattingEnabled = true;
            this.CBFrom.Location = new System.Drawing.Point(359, 58);
            this.CBFrom.Name = "CBFrom";
            this.CBFrom.Size = new System.Drawing.Size(165, 24);
            this.CBFrom.TabIndex = 44;
            this.CBFrom.Click += new System.EventHandler(this.CBFrom_Click);
            // 
            // CBItems
            // 
            this.CBItems.Enabled = false;
            this.CBItems.Location = new System.Drawing.Point(359, 182);
            this.CBItems.Name = "CBItems";
            this.CBItems.Size = new System.Drawing.Size(165, 24);
            this.CBItems.TabIndex = 43;
            this.CBItems.Click += new System.EventHandler(this.CBItems_Click);
            // 
            // CBTo
            // 
            this.CBTo.FormattingEnabled = true;
            this.CBTo.Location = new System.Drawing.Point(359, 115);
            this.CBTo.Name = "CBTo";
            this.CBTo.Size = new System.Drawing.Size(165, 24);
            this.CBTo.TabIndex = 42;
            this.CBTo.Click += new System.EventHandler(this.CBTo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 56;
            this.label1.Text = "Store To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 57;
            this.label2.Text = "Store From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "Supplier Name";
            // 
            // CBSupplier
            // 
            this.CBSupplier.Enabled = false;
            this.CBSupplier.FormattingEnabled = true;
            this.CBSupplier.Location = new System.Drawing.Point(359, 248);
            this.CBSupplier.Name = "CBSupplier";
            this.CBSupplier.Size = new System.Drawing.Size(165, 24);
            this.CBSupplier.TabIndex = 59;
            this.CBSupplier.Click += new System.EventHandler(this.CBSupplier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 26);
            this.label5.TabIndex = 62;
            this.label5.Text = "Production Date";
            // 
            // TBEXP
            // 
            this.TBEXP.Location = new System.Drawing.Point(775, 168);
            this.TBEXP.Name = "TBEXP";
            this.TBEXP.Size = new System.Drawing.Size(165, 22);
            this.TBEXP.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(577, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 26);
            this.label6.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(583, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 26);
            this.label7.TabIndex = 64;
            this.label7.Text = "EXP";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(775, 246);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 65;
            // 
            // FormTransfare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 467);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TBEXP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CBSupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TBQuntity);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CBFrom);
            this.Controls.Add(this.CBItems);
            this.Controls.Add(this.CBTo);
            this.Name = "FormTransfare";
            this.Text = "Tranfare Items";
            this.Load += new System.EventHandler(this.FormTransfare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBQuntity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CBFrom;
        private System.Windows.Forms.ComboBox CBItems;
        private System.Windows.Forms.ComboBox CBTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBEXP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker date;
    }
}