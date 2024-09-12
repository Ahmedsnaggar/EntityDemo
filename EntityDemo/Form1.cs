using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityDemo
{
    public partial class Form1 : Form
    {
        NorthWindEntities _db = new NorthWindEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var Categories = from c in _db.Categories
                             select c;
            //var Categories = from c in _db.Customers
            //                select new { c.ContactName, c.CompanyName};
            grdCategories.DataSource = Categories.ToList();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            var categories = _db.Categories;
            //var categories = _db.Categories.Select(c=> new {c.CategoryName, c.Description});
            grdCategories.DataSource = categories.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grdCategories.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] ints = new int[5] { 10, 10, 5, 10, 10};
            var result = ints.Any(a=> a.Equals(5));
            MessageBox.Show(result.ToString());
        }

        private void grdCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grdCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var cell = grdCategories.Rows[row].Cells[0];
            //var Products = _db.Products.Where(p => p.CategoryID == (int)(cell.Value));
            var Products = from p in _db.Products
                           where p.CategoryID == (int)cell.Value
                           select p;
            grdProducts.DataSource = Products.ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewCategory frm = new frmNewCategory();
            frm.ShowDialog();
            var Categories = from c in _db.Categories
                             select c;
            //var Categories = from c in _db.Customers
            //                select new { c.ContactName, c.CompanyName};
            grdCategories.DataSource = Categories.ToList();
        }

        private void grdCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var cell = grdCategories.Rows[row].Cells[0];
            frmNewCategory frm = new frmNewCategory();
            frm.CategoryID = (int)cell.Value;
            frm.ShowDialog();
            _db = new NorthWindEntities();
            var Categories = from c in _db.Categories
                             select c;
            //var Categories = from c in _db.Customers
            //                select new { c.ContactName, c.CompanyName};
            grdCategories.DataSource = Categories.ToList();
        }
    }
}
