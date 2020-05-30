using Business;
using Data;
using System;
using System.Windows.Forms;

namespace products
{
    /// <summary>
    /// Main form1 which shows the main idea of the project
    /// </summary>
    public partial class Form1 : Form
    {
        
        private readonly ProductContext dbContext;
       
        // Constructor
        public Form1()
        {
            InitializeComponent();
            dbContext = new ProductContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         // Button showing all the parfumes
        private void Perfumes_Click(object sender, EventArgs e)
        {
            PerfumeRepository perfumeRepository = new PerfumeRepository();
            dataGridView2.DataSource = perfumeRepository.GetAll();

        }
        // Button showing all the creams
        private void Creams_Click(object sender, EventArgs e)
        {
            CreamRepository creamRepository = new CreamRepository();
            dataGridView2.DataSource = creamRepository.GetAll();
        }

        // Button showing all the makeUps
        private void MakeUp_Click(object sender, EventArgs e)
        {
            MakeUpRepository makeUpRepository = new MakeUpRepository();
            dataGridView2.DataSource = makeUpRepository.GetAll();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Adds products to the cart
        private void Add_Click_1(object sender, EventArgs e)
        {
            var item = dataGridView2.SelectedRows[0].Cells;
            var id = item[0].Value.ToString();
            var name = item[1].Value.ToString();
            decimal price = decimal.Parse(item[2].Value.ToString());

            Cart cart = new Cart(id, name, price);
            using (var context = new ProductContext())
            {
                context.Cart.Add(cart);
                context.SaveChanges();
            }
        }

        // Opens the next form which shows us the cart
        private void Cart_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            CartRepository cartRepository = new CartRepository();
            f2.dataGridView1.DataSource = cartRepository.GetAll();
            this.Hide();
        }
       

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
   




       
