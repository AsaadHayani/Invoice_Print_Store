using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Print_Store
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnclose_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void lbllink_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.google.com");
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txtdate.Text = DateTime.Now.ToString("yyyy/MM/dd");

      Dictionary<int, string> itemsdata = new Dictionary<int, string>();
      itemsdata.Add(2500, "Asus");
      itemsdata.Add(1000, "HP");
      itemsdata.Add(2000, "Dell");
      itemsdata.Add(1500, "Lenovo");
      itemsdata.Add(900, "MSI");
      itemsdata.Add(3500, "Apple");
      cbxitems.DataSource = new BindingSource(itemsdata, null);
      cbxitems.DisplayMember = "value";
      cbxitems.ValueMember = "key";

      txtprice.Text = cbxitems.SelectedValue.ToString();

      txtname.Focus();
      txtname.Select();
      txtname.SelectAll();
    }

    private void txtdate_KeyPress(object sender, KeyPressEventArgs e)
    {
      e.Handled = true;
    }

    private void txtdate_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        txtdate.ContextMenu = new ContextMenu();
      }
    }

    private void txtname_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        cbxitems.Focus();
      }
    }

    private void cbxitems_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        txtqty.Focus();
        txtqty.SelectAll();
      }
    }

    private void cbxitems_SelectedIndexChanged(object sender, EventArgs e)
    {
      txtprice.Text = cbxitems.SelectedValue.ToString();
    }

    private void btnadd_Click(object sender, EventArgs e)
    {
      if (cbxitems.SelectedIndex <= -1) return;

      string item = cbxitems.Text;
      int qty = Convert.ToInt32(txtqty.Text);
      int price = Convert.ToInt32(txtprice.Text);
      int subtotal = qty * price;
      object[] row = { item, qty, price, subtotal };
      dgvinvoice.Rows.Add(row);
      txttotal.Text = (Convert.ToInt32(txttotal.Text) + subtotal).ToString();
    }

    private void txtqty_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        btnadd.PerformClick();
        cbxitems.Focus();
      }
    }

    private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    string oldqty = "1";

    private void dgvinvoice_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
    {
      if (dgvinvoice.CurrentRow != null)
      {
        oldqty = dgvinvoice.CurrentRow.Cells["colqty"].Value + "";
      }
    }

    private void dgvinvoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
      if (dgvinvoice.CurrentRow != null)
      {
        string newqty = dgvinvoice.CurrentRow.Cells["colqty"].Value + "";
        if (oldqty == newqty) return;
        if (!Regex.IsMatch(newqty, "^\\d+$"))
        {
          dgvinvoice.CurrentRow.Cells["colqty"].Value = oldqty;
        }
        else
        {
          int p = (int)dgvinvoice.CurrentRow.Cells["colprice"].Value;
          int q = Convert.ToInt32(newqty);
          dgvinvoice.CurrentRow.Cells["colsubtotal"].Value = (q * p);

          int newtotal = 0;
          foreach (DataGridViewRow r in dgvinvoice.Rows)
          {
            newtotal += Convert.ToInt32(r.Cells["colsubtotal"].Value);
          }
          txttotal.Text = newtotal + "";
        }
      }
    }

    private void btnprint_Click(object sender, EventArgs e)
    {
      ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
      if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
      {
        printDocument1.Print();
      }
    }

    private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
      float margin = 40;
      Font f = new Font("arial", 18, FontStyle.Bold);

      string strno = "#NO " + txtnum.Text;
      string strdate = "Date: " + txtdate.Text;
      string strname = "Wanted By MR: " + txtname.Text;

      SizeF fontsizeno = e.Graphics.MeasureString(strno, f);
      SizeF fontsizedate = e.Graphics.MeasureString(strdate, f);
      SizeF fontsizename = e.Graphics.MeasureString(strname, f);

      e.Graphics.DrawImage(Properties.Resources.t1, 25, 25, 200, 200);
      e.Graphics.DrawString(strno, f, Brushes.Red, (e.PageBounds.Width - fontsizeno.Width) / 2, margin);
      e.Graphics.DrawString(strdate, f, Brushes.Black, (e.PageBounds.Width - fontsizedate.Width - margin), margin + fontsizeno.Height);
      e.Graphics.DrawString(strname, f, Brushes.Navy, (e.PageBounds.Width - fontsizename.Width - margin), margin + fontsizeno.Height + fontsizedate.Height);

      float preheight = margin + fontsizeno.Height + fontsizedate.Height + fontsizename.Height + 110;

      e.Graphics.DrawRectangle(Pens.Black, margin, preheight, e.PageBounds.Width - margin * 2, e.PageBounds.Height - margin - preheight);

      float colheight = 60;
      float col1width = 300;
      float col2width = 125 + col1width;
      float col3width = 125 + col2width;
      float col4width = 125 + col3width;

      e.Graphics.DrawLine(Pens.Black, margin, preheight + colheight, e.PageBounds.Width - margin, preheight + colheight);

      e.Graphics.DrawString("Category", f, Brushes.OrangeRed, e.PageBounds.Width - margin * 2 - col1width, preheight);
      e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col1width, preheight, e.PageBounds.Width - margin * 2 - col1width, e.PageBounds.Height - margin);

      e.Graphics.DrawString("Quantity", f, Brushes.OrangeRed, e.PageBounds.Width - margin * 2 - col2width, preheight);
      e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col2width, preheight, e.PageBounds.Width - margin * 2 - col2width, e.PageBounds.Height - margin);

      e.Graphics.DrawString("Price", f, Brushes.OrangeRed, e.PageBounds.Width - margin * 2 - col3width, preheight);
      e.Graphics.DrawLine(Pens.Black, e.PageBounds.Width - margin * 2 - col3width, preheight, e.PageBounds.Width - margin * 2 - col3width, e.PageBounds.Height - margin);

      e.Graphics.DrawString("Total", f, Brushes.OrangeRed, e.PageBounds.Width - margin * 2 - col4width, preheight);

      //invoice content
      float rowsheight = 60;
      for (int x = 0; x < dgvinvoice.Rows.Count; x += 1)
      {
        e.Graphics.DrawString(dgvinvoice.Rows[x].Cells[0].Value.ToString(), f, Brushes.Green, e.PageBounds.Width - margin * 2 - col1width, preheight + rowsheight);

        e.Graphics.DrawString(dgvinvoice.Rows[x].Cells[1].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col2width, preheight + rowsheight);

        e.Graphics.DrawString(dgvinvoice.Rows[x].Cells[2].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col3width, preheight + rowsheight);

        e.Graphics.DrawString(dgvinvoice.Rows[x].Cells[3].Value.ToString(), f, Brushes.Black, e.PageBounds.Width - margin * 2 - col4width, preheight + rowsheight);

        e.Graphics.DrawLine(Pens.Black, margin, preheight + rowsheight + colheight, e.PageBounds.Width - margin, preheight + rowsheight + colheight);

        rowsheight += 60;
      }

      e.Graphics.DrawString("Total", f, Brushes.Red, e.PageBounds.Width - margin * 2 - col3width, preheight + rowsheight);

      e.Graphics.DrawString(txttotal.Text, f, Brushes.Blue, e.PageBounds.Width - margin * 2 - col4width, preheight + rowsheight);

      e.Graphics.DrawLine(Pens.Black, margin, preheight + rowsheight + colheight, e.PageBounds.Width - margin, preheight + rowsheight + colheight);
    }
  }
}
