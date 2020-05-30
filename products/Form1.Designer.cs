using System;

namespace products
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Creams = new System.Windows.Forms.Button();
            this.MakeUp = new System.Windows.Forms.Button();
            this.Perfumes = new System.Windows.Forms.Button();
            this.Cart = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(397, 123);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(412, 218);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // Creams
            // 
            this.Creams.Location = new System.Drawing.Point(169, 125);
            this.Creams.Name = "Creams";
            this.Creams.Size = new System.Drawing.Size(124, 40);
            this.Creams.TabIndex = 2;
            this.Creams.Text = "Creams";
            this.Creams.UseVisualStyleBackColor = true;
            this.Creams.Click += new System.EventHandler(this.Creams_Click);
            // 
            // MakeUp
            // 
            this.MakeUp.Location = new System.Drawing.Point(169, 197);
            this.MakeUp.Name = "MakeUp";
            this.MakeUp.Size = new System.Drawing.Size(124, 40);
            this.MakeUp.TabIndex = 3;
            this.MakeUp.Text = "MakeUp";
            this.MakeUp.UseVisualStyleBackColor = true;
            this.MakeUp.Click += new System.EventHandler(this.MakeUp_Click);
            // 
            // Perfumes
            // 
            this.Perfumes.Location = new System.Drawing.Point(169, 271);
            this.Perfumes.Name = "Perfumes";
            this.Perfumes.Size = new System.Drawing.Size(124, 40);
            this.Perfumes.TabIndex = 4;
            this.Perfumes.Text = "Perfumes";
            this.Perfumes.UseVisualStyleBackColor = true;
            this.Perfumes.Click += new System.EventHandler(this.Perfumes_Click);
            // 
            // Cart
            // 
            this.Cart.Location = new System.Drawing.Point(169, 375);
            this.Cart.Name = "Cart";
            this.Cart.Size = new System.Drawing.Size(124, 40);
            this.Cart.TabIndex = 5;
            this.Cart.Text = "Cart";
            this.Cart.UseVisualStyleBackColor = true;
            this.Cart.Click += new System.EventHandler(this.Cart_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(693, 401);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(116, 40);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::products.Properties.Resources.pUQiPgljEz;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(968, 533);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Cart);
            this.Controls.Add(this.Perfumes);
            this.Controls.Add(this.MakeUp);
            this.Controls.Add(this.Creams);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion      
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Creams;
        private System.Windows.Forms.Button MakeUp;
        private System.Windows.Forms.Button Perfumes;
        private System.Windows.Forms.Button Cart;
        private System.Windows.Forms.Button Add;

        public EventHandler Remove_Click { get; private set; }
        public EventHandler Add_Click { get; private set; }
    }
}

