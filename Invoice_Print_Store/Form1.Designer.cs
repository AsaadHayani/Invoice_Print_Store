namespace Invoice_Print_Store
{
  partial class Form1
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnclose = new System.Windows.Forms.Button();
      this.btnprint = new System.Windows.Forms.Button();
      this.btnadd = new System.Windows.Forms.Button();
      this.txttotal = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.dgvinvoice = new System.Windows.Forms.DataGridView();
      this.cbxitems = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.txtqty = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.txtpric = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtname = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtdate = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtnum = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.lbllink = new System.Windows.Forms.LinkLabel();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtprice = new System.Windows.Forms.NumericUpDown();
      this.colcat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colsubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.printDocument1 = new System.Drawing.Printing.PrintDocument();
      this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
      ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
      this.SuspendLayout();
      // 
      // btnclose
      // 
      this.btnclose.BackColor = System.Drawing.Color.Red;
      this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnclose.FlatAppearance.BorderSize = 0;
      this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnclose.Location = new System.Drawing.Point(734, 326);
      this.btnclose.Name = "btnclose";
      this.btnclose.Size = new System.Drawing.Size(165, 46);
      this.btnclose.TabIndex = 42;
      this.btnclose.Text = "Close";
      this.btnclose.UseVisualStyleBackColor = false;
      this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
      // 
      // btnprint
      // 
      this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnprint.FlatAppearance.BorderSize = 0;
      this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnprint.ForeColor = System.Drawing.Color.Ivory;
      this.btnprint.Location = new System.Drawing.Point(734, 262);
      this.btnprint.Name = "btnprint";
      this.btnprint.Size = new System.Drawing.Size(165, 46);
      this.btnprint.TabIndex = 41;
      this.btnprint.Text = "Print";
      this.btnprint.UseVisualStyleBackColor = false;
      this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
      // 
      // btnadd
      // 
      this.btnadd.BackColor = System.Drawing.Color.Lime;
      this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnadd.FlatAppearance.BorderSize = 0;
      this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnadd.ForeColor = System.Drawing.Color.Black;
      this.btnadd.Location = new System.Drawing.Point(734, 199);
      this.btnadd.Name = "btnadd";
      this.btnadd.Size = new System.Drawing.Size(165, 46);
      this.btnadd.TabIndex = 40;
      this.btnadd.Text = "Add";
      this.btnadd.UseVisualStyleBackColor = false;
      this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
      // 
      // txttotal
      // 
      this.txttotal.BackColor = System.Drawing.SystemColors.HotTrack;
      this.txttotal.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
      this.txttotal.ForeColor = System.Drawing.Color.Gold;
      this.txttotal.Location = new System.Drawing.Point(239, 324);
      this.txttotal.Name = "txttotal";
      this.txttotal.Size = new System.Drawing.Size(155, 38);
      this.txttotal.TabIndex = 39;
      this.txttotal.Text = "0";
      this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdate_KeyPress);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(27, 326);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(76, 29);
      this.label9.TabIndex = 38;
      this.label9.Text = "Total:";
      // 
      // dgvinvoice
      // 
      this.dgvinvoice.AllowUserToAddRows = false;
      this.dgvinvoice.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
      this.dgvinvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvinvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgvinvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dgvinvoice.BackgroundColor = System.Drawing.Color.Gray;
      this.dgvinvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvinvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcat,
            this.colqty,
            this.colprice,
            this.colsubtotal});
      this.dgvinvoice.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dgvinvoice.Location = new System.Drawing.Point(0, 416);
      this.dgvinvoice.Name = "dgvinvoice";
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
      this.dgvinvoice.RowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvinvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvinvoice.Size = new System.Drawing.Size(962, 217);
      this.dgvinvoice.TabIndex = 37;
      this.dgvinvoice.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvinvoice_CellBeginEdit);
      this.dgvinvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinvoice_CellEndEdit);
      // 
      // cbxitems
      // 
      this.cbxitems.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cbxitems.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbxitems.FormattingEnabled = true;
      this.cbxitems.Location = new System.Drawing.Point(239, 221);
      this.cbxitems.Name = "cbxitems";
      this.cbxitems.Size = new System.Drawing.Size(455, 36);
      this.cbxitems.TabIndex = 36;
      this.cbxitems.SelectedIndexChanged += new System.EventHandler(this.cbxitems_SelectedIndexChanged);
      this.cbxitems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxitems_KeyDown);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(27, 277);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(75, 29);
      this.label8.TabIndex = 35;
      this.label8.Text = "Price:";
      // 
      // txtqty
      // 
      this.txtqty.ForeColor = System.Drawing.Color.Black;
      this.txtqty.Location = new System.Drawing.Point(544, 275);
      this.txtqty.Name = "txtqty";
      this.txtqty.Size = new System.Drawing.Size(155, 34);
      this.txtqty.TabIndex = 34;
      this.txtqty.Text = "1";
      this.txtqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtqty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtqty_KeyDown);
      this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(422, 277);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(116, 29);
      this.label7.TabIndex = 33;
      this.label7.Text = "Quantity:";
      // 
      // txtpric
      // 
      this.txtpric.BackColor = System.Drawing.Color.White;
      this.txtpric.ForeColor = System.Drawing.Color.Black;
      this.txtpric.Location = new System.Drawing.Point(523, 321);
      this.txtpric.Name = "txtpric";
      this.txtpric.ReadOnly = true;
      this.txtpric.Size = new System.Drawing.Size(155, 34);
      this.txtpric.TabIndex = 32;
      this.txtpric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(27, 224);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(118, 29);
      this.label6.TabIndex = 31;
      this.label6.Text = "Category:";
      // 
      // txtname
      // 
      this.txtname.ForeColor = System.Drawing.Color.Black;
      this.txtname.Location = new System.Drawing.Point(239, 167);
      this.txtname.Name = "txtname";
      this.txtname.Size = new System.Drawing.Size(452, 34);
      this.txtname.TabIndex = 29;
      this.txtname.Text = "Name";
      this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtname_KeyDown);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(27, 170);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(192, 29);
      this.label4.TabIndex = 28;
      this.label4.Text = "Customer Name:";
      // 
      // txtdate
      // 
      this.txtdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.txtdate.Location = new System.Drawing.Point(539, 112);
      this.txtdate.Name = "txtdate";
      this.txtdate.Size = new System.Drawing.Size(155, 34);
      this.txtdate.TabIndex = 27;
      this.txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdate_KeyPress);
      this.txtdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtdate_MouseDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(448, 115);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(73, 29);
      this.label3.TabIndex = 26;
      this.label3.Text = "Date:";
      // 
      // txtnum
      // 
      this.txtnum.ForeColor = System.Drawing.Color.Red;
      this.txtnum.Location = new System.Drawing.Point(239, 112);
      this.txtnum.Name = "txtnum";
      this.txtnum.Size = new System.Drawing.Size(155, 34);
      this.txtnum.TabIndex = 25;
      this.txtnum.Text = "00001";
      this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 115);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(189, 29);
      this.label2.TabIndex = 24;
      this.label2.Text = "Invoice Number:";
      // 
      // lbllink
      // 
      this.lbllink.AutoSize = true;
      this.lbllink.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lbllink.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbllink.LinkColor = System.Drawing.Color.Yellow;
      this.lbllink.Location = new System.Drawing.Point(47, 38);
      this.lbllink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lbllink.Name = "lbllink";
      this.lbllink.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.lbllink.Size = new System.Drawing.Size(130, 29);
      this.lbllink.TabIndex = 23;
      this.lbllink.TabStop = true;
      this.lbllink.Text = "Website Us";
      this.lbllink.Click += new System.EventHandler(this.lbllink_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Image = global::Invoice_Print_Store.Properties.Resources.t1;
      this.pictureBox1.Location = new System.Drawing.Point(734, 21);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(165, 151);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 22;
      this.pictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.Font = new System.Drawing.Font("Arial", 26F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
      this.label1.ForeColor = System.Drawing.Color.Aqua;
      this.label1.Location = new System.Drawing.Point(284, 21);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(319, 49);
      this.label1.TabIndex = 21;
      this.label1.Text = "Invoice Store";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtprice
      // 
      this.txtprice.Location = new System.Drawing.Point(239, 275);
      this.txtprice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.txtprice.Name = "txtprice";
      this.txtprice.Size = new System.Drawing.Size(155, 34);
      this.txtprice.TabIndex = 43;
      this.txtprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // colcat
      // 
      this.colcat.HeaderText = "Category";
      this.colcat.Name = "colcat";
      this.colcat.ReadOnly = true;
      // 
      // colqty
      // 
      this.colqty.HeaderText = "Quantity";
      this.colqty.Name = "colqty";
      // 
      // colprice
      // 
      this.colprice.HeaderText = "Price";
      this.colprice.Name = "colprice";
      this.colprice.ReadOnly = true;
      // 
      // colsubtotal
      // 
      this.colsubtotal.HeaderText = "Total";
      this.colsubtotal.Name = "colsubtotal";
      this.colsubtotal.ReadOnly = true;
      // 
      // printDocument1
      // 
      this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
      // 
      // printPreviewDialog1
      // 
      this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
      this.printPreviewDialog1.Document = this.printDocument1;
      this.printPreviewDialog1.Enabled = true;
      this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
      this.printPreviewDialog1.Name = "printPreviewDialog1";
      this.printPreviewDialog1.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.ClientSize = new System.Drawing.Size(962, 633);
      this.Controls.Add(this.txtprice);
      this.Controls.Add(this.btnclose);
      this.Controls.Add(this.btnprint);
      this.Controls.Add(this.btnadd);
      this.Controls.Add(this.txttotal);
      this.Controls.Add(this.label9);
      this.Controls.Add(this.dgvinvoice);
      this.Controls.Add(this.cbxitems);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtqty);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txtpric);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtname);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtdate);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtnum);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbllink);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.White;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Invoice Print Store";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvinvoice)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnclose;
    private System.Windows.Forms.Button btnprint;
    private System.Windows.Forms.Button btnadd;
    private System.Windows.Forms.TextBox txttotal;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.DataGridView dgvinvoice;
    private System.Windows.Forms.ComboBox cbxitems;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtqty;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtpric;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtname;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtdate;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtnum;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.LinkLabel lbllink;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown txtprice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colcat;
    private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
    private System.Windows.Forms.DataGridViewTextBoxColumn colprice;
    private System.Windows.Forms.DataGridViewTextBoxColumn colsubtotal;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
  }
}

