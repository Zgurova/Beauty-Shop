using Business;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace products
{
    /// <summary>
    /// Second form2 which shows the cart
    /// </summary>
    public partial class Form2 : Form
    {
        private ProductBusiness productBusiness = new ProductBusiness();

        // Constructor
        public Form2()
        {
            InitializeComponent();
        }
       
        // Updates the grid when an operation is done
        private void UpdateGrid()
        {
            dataGridView1.DataSource = productBusiness.GetAll();
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // When the operations with the selected item finishes, this button makes it unselected
        private void ResetSelect()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Enabled = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        // Opens the next form which shows if the order is successful
        
        private void Order_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            CartRepository cartRepository = new CartRepository();
            List<Cart> cart = cartRepository.GetAll();
            for (int i = 0; i < cart.Count; i++)
            {
                cartRepository.Remove(cart[i].Id);
            }
            cart.Clear();
            this.Hide();
            UpdateGrid();

        }

        // Removes an item from the cart
        private void Remove_Click(object sender, EventArgs e)
        {
            var item = dataGridView1.SelectedRows[0].Cells;
            var id = item[0].Value.ToString();
            CartRepository cartRepository = new CartRepository();
            cartRepository.Remove(id);
            dataGridView1.Update();
            UpdateGrid();
            ResetSelect();

        }

        // Opens the previous form - form 1
        private void Back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }       

        // Shows the total price
        private void label1_Click(object sender, EventArgs e)
        {
            string totalPrice = productBusiness.TotalPrice();

            label1.Text = $"Total price: {totalPrice} lv.";
            UpdateGrid();
        }
    }
}
