using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223_LabSession_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            //lblname.Text = txt_name.Text+" Occupied It";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Item it = new Item();
            it.Number = int.Parse(txt_Number.Text);
            it.Date = dtp.Text;
            it.ItemName = txt_itemName.Text;
            it.Price = int.Parse(txt_price.Text);
            it.Quantity = int.Parse(txt_qty.Text);
            it.Sku = int.Parse(txt_Sku.Text);
            it.save();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {txt_itemName.Text}");
            this.Close();

        }
    }
}
