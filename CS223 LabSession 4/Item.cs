using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223_LabSession_4
{
    class Item
    {
        public int Number { get; set; }
        public String Date { get; set; }
        public int Sku { get; set; }
        public String ItemName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public void save() {
            MessageBox.Show("Data Added Successfully");

        }

    }
}
