
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS223_LabSession_4
{
    class Item
    { ArrayList m = new ArrayList();
        static List<Item> Products = new List<Item>();
        public int Number { get; set; }
        public String Date { get; set; }
        public int Sku { get; set; }
        public String ItemName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public bool ISAVA { get; set; }
        public String type { get; set; }
        //   public bool simple { get; set; }

        public void save()
        {
            /*m.Add(8);
             m.Add("N");
             m.Add(true);
             m.Add(new Item());
             Products.Add(this);
             */
             Products.Add(this);
            try
            {
               // MessageBox.Show(this.Date.ToString());
                String Query = "Insert into ItemPro values(" + this.Number.ToString() + "," +"'"+ this.Date.ToString() +"'"+ ","+this.Sku.ToString() + "," +"'"+ this.ItemName.ToString() +"'"+ "," + this.Quantity.ToString() + "," + this.Price.ToString() + "," + 1.ToString() + ")";
                String ConnectionString = "Data Source=DESKTOP-44OPTQE\\SQLEXPRESS;Initial Catalog=University;Integrated Security=true";
                SqlConnection sq = new SqlConnection(ConnectionString);
                sq.Open();
                SqlCommand cmd = new SqlCommand(Query, sq);
                int c = (int)cmd.ExecuteNonQuery();
                MessageBox.Show(c.ToString() + " Number of rows inserted Successfully");
                // MessageBox.Show("DB Connected");
                sq.Close();


            }
            catch (SqlException s)
            {
                MessageBox.Show(s.Message);
            }





            //            MessageBox.Show("Data Added Successfully ");




        }
            public static List<Item> getAllProducts() {
            List<Item> tempList = new List<Item>();
            String Query = "Select * from ItemPro ";
            String ConnectionString = "Data Source=DESKTOP-44OPTQE\\SQLEXPRESS;Initial Catalog=University;Integrated Security=true";
            SqlDataReader sd;
            SqlConnection sq = new SqlConnection(ConnectionString);
            sq.Open();
            SqlCommand cmd = new SqlCommand(Query, sq);
            //int c = (int)cmd.ExecuteNonQuery();
            //MessageBox.Show(c.ToString() + " Number of rows inserted");
            // MessageBox.Show("DB Connected");
            sd = cmd.ExecuteReader();
            int w = 0;
            while (sd.Read())
            {
                Item i = new Item();
                i.Number = (int)sd["number"];
                i.ItemName = sd["ProName"].ToString();
                i.Date = sd["date"].ToString();
                i.Sku = (int)sd["sku"];
                i.Quantity = (int)sd["qty"];
                i.Price = float.Parse(sd["price"].ToString());
               i.ISAVA = (bool)sd["isava"];
                //if (w == 0)
                //{
                //    i.ISAVA = true;
                //}
                //else
                //    i.ISAVA = false;
                tempList.Add(i);
            }

            sq.Close();


            return tempList;
            }
            public static Item Search(String name) {
                //Item p;
                // object c = 4;
                //object o=false;
                return Products.Find(p => p.ItemName == name);
            }

        } } 

