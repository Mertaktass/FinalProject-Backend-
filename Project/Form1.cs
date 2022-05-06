using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          

        }

        private void gbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductBayCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch 
            {

            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategory();
            ListProduct();
        }

        private void ListCategory()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                cbxCategory.DataSource = context.Categories.ToList();
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";

            }
        }


        private void ListProduct()
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                dgwProduct.DataSource = context.Products.ToList();
              
            }
        }


        private void ListProductBayCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
            }

        }

        private void ListProductBayProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }

        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string k = tbxSearch.Text;

            if (string.IsNullOrEmpty(k))
            {
                ListProduct();


            }
           
            else
            {
                ListProductBayProductName(tbxSearch.Text);

            }

        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }
    }
}
