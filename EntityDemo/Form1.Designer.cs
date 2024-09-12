namespace EntityDemo
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
            this.grdCategories = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grdProducts = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCategories
            // 
            this.grdCategories.AllowUserToAddRows = false;
            this.grdCategories.AllowUserToDeleteRows = false;
            this.grdCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategories.Location = new System.Drawing.Point(0, 115);
            this.grdCategories.Name = "grdCategories";
            this.grdCategories.ReadOnly = true;
            this.grdCategories.RowHeadersWidth = 62;
            this.grdCategories.RowTemplate.Height = 28;
            this.grdCategories.Size = new System.Drawing.Size(1287, 223);
            this.grdCategories.TabIndex = 0;
            this.grdCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellClick);
            this.grdCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellContentClick);
            this.grdCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCategories_CellDoubleClick);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1060, 0);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(210, 46);
            this.btnQuery.TabIndex = 1;
            this.btnQuery.Text = "Query Syntax ";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(844, 0);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(210, 46);
            this.btnMethod.TabIndex = 2;
            this.btnMethod.Text = "Method Syntex";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grdProducts
            // 
            this.grdProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducts.Location = new System.Drawing.Point(0, 356);
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowHeadersWidth = 62;
            this.grdProducts.RowTemplate.Height = 28;
            this.grdProducts.Size = new System.Drawing.Size(1287, 207);
            this.grdProducts.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(1097, 52);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(173, 51);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New Category";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 566);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.grdCategories);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCategories;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grdProducts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNew;
    }
}

