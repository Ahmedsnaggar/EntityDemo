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
    public partial class frmNewCategory : Form
    {
        NorthWindEntities _db = new NorthWindEntities();
        public int CategoryID { get; set; } = 0;
        public frmNewCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CategoryID == 0)
            {
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    Category category = new Category();
                    category.CategoryName = txtName.Text;
                    category.Description = txtDescription.Text;
                    _db.Categories.Add(category);
                    _db.SaveChanges();
                    
                }
            }
            else
            {
                Category oldCategory = _db.Categories.FirstOrDefault(x => x.CategoryID == CategoryID);
                oldCategory.CategoryName = txtName.Text;
                oldCategory.Description = txtDescription.Text;
                _db.SaveChanges();

            }
            this.Close();
        }

        private void frmNewCategory_Load(object sender, EventArgs e)
        {
            txtId.Text = CategoryID.ToString();
            if (CategoryID > 0) 
            { 
                var category = _db.Categories.FirstOrDefault(x=> x.CategoryID == CategoryID);
                txtName.Text = category.CategoryName;
                txtDescription.Text = category.Description;
            }
        }
    }
}
