﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace CS223_LabSession_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(String str)
        {
            InitializeComponent();
            lbl_profile.Text = str;
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
            String pat = @"([0-9]{2}.[0-9]{2})$";
            Regex  re= new Regex(pat);

            bool exist = false;
            Item it = new Item();
            //validation through message box    
           
            if (String.IsNullOrEmpty(txt_price.Text)) { MessageBox.Show("ERROR! Price should be listed"); }
            // if(txt_itemName.Text.Length<3) { MessageBox.Show("ERROR! Item name must not be less than three letters!"); }
            else
            {
                exist = true;
            }

            if (String.IsNullOrEmpty(txt_itemName.Text)) { errorProvider1.SetError(txt_itemName, "Item name must not be empty");
                exist = false;
            }
            else if (!re.IsMatch(txt_price.Text))
            {
                MessageBox.Show("Price value should be like av.ds when a,v,d,s are integers!!");
                exist = false;
            }
            
            // if () { }

            //else if (dtp.Text != "7/12/2022") { errorProvider1.SetError(dtp, "Date should be Current date!"); }
            if (exist)
                {
                    errorProvider1.Clear();
                    it.Number = int.Parse(txt_Number.Text);
                    it.Date = dtp.Text;
                    it.ItemName = txt_itemName.Text;
                    it.Price = float.Parse(txt_price.Text);
                    it.Quantity = int.Parse(txt_qty.Text);
                    it.Sku = int.Parse(txt_Sku.Text);
                it.ISAVA = cb_avb.Checked;
                if (radioButton1.Checked)
                    it.type = radioButton1.Text;
                else it.type = radioButton2.Text;
          //      it.simple = false;
                it.save();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Item.getAllProducts();
            

               


                
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {txt_itemName.Text}");
            this.Close();
            Form opened;
          //  opened = Form.ActiveForm;
//if(opened!=null)
  //          opened.Close();


            //Console.WriteLine(Item.getAllProducts());

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String message="";
            foreach (var item in checkedListBox1.CheckedItems) {
                if (checkedListBox1.CheckedItems.Count == 0) { MessageBox.Show("NO ITEMS FOUND!"); }
                else message += item.ToString();

            }
            MessageBox.Show(message);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_srch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_srch.Text) || tb_srch.Text.Equals("Enter Item Name")) {
                MessageBox.Show("Enter What to search(Item Name)");
                return;
            }
            else
            { Item i = Item.Search(tb_srch.Text);
                if (i != null)
                {
                    MessageBox.Show($"Found {tb_srch.Text}." +
                        $" Automatically filled the form according to the Search!");
                    txt_itemName.Text = i.ItemName;
                    txt_Number.Text = i.Number.ToString();
                    txt_price.Text = i.Price.ToString();
                    txt_qty.Text = i.Quantity.ToString();
                    txt_Sku.Text = i.Sku.ToString();
                    dtp.Text = i.Date;

                }
                else
                    MessageBox.Show("Sorry Item not found!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Display d = new Display();
            d.Show();
            //ItemFill p = new ItemFill();
            //p.Show();
   




        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Item.getAllProducts();
        }
    }
}
