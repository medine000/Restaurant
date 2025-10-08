namespace Restaurant
{
    public partial class Form1 : Form
    {
        string pizza = "Pizza";
        string pasta = "Pasta";
        string salad = "Salad";
        string dessert = "Dessert";
        string drink = "Drink";
        string appetizer = "Appetizer";
        string mainCourse = "Main Course";
        string seafood = "Seafood";
        string steak = "Steak";
        string vegetarian = "Vegetarian";
        string vegan = "Vegan";
        string glutenFree = "Gluten Free";

        double pizzaPrice = 8.99;
        double pastaPrice = 10.99;
        double saladPrice = 6.99;
        double dessertPrice = 4.99;
        double drinkPrice = 2.99;
        double appetizerPrice = 5.99;
        double mainCoursePrice = 12.99;
        double seafoodPrice = 15.99;
        double steakPrice = 18.99;
        double vegetarianPrice = 9.99;
        double veganPrice = 11.99;
        double glutenFreePrice = 13.99;
        double totalPrice = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            totalPrice += veganPrice;
            listBox1.Items.Add("Vegan :11.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            totalPrice += pizzaPrice;
            listBox1.Items.Add("Pizza :6");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            totalPrice += pastaPrice;
            listBox1.Items.Add("Pasta :10.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            totalPrice += saladPrice;
            listBox1.Items.Add("Salad :6.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            totalPrice += dessertPrice;
            listBox1.Items.Add("Dessert :4.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            totalPrice += drinkPrice;
            listBox1.Items.Add("Drink :2.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            totalPrice += appetizerPrice;
            listBox1.Items.Add("Appetizer :5.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            totalPrice += mainCoursePrice;
            listBox1.Items.Add("Main Course :12.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            totalPrice += seafoodPrice;
            listBox1.Items.Add("Seafood :15.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            totalPrice += steakPrice;
            listBox1.Items.Add("Steak :18.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            totalPrice += vegetarianPrice;
            listBox1.Items.Add("Vegetarian :9.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            totalPrice += dessertPrice;
            listBox1.Items.Add("Gluten Free :13.99");
            textBox1.Text = totalPrice.ToString("0.00");
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (textBox3.Text != "") 
            {
                try
                {
                    double odenis = Convert.ToDouble(textBox3.Text);
                    double umumi = totalPrice;

                    if (odenis >= umumi)
                    {
                        double qaliq = odenis - umumi;

                        textBox2.Text = qaliq.ToString("0.00");

                        listBox1.Items.Add("------------------");
                        listBox1.Items.Add("Ümumi: " + umumi.ToString("0.00") + " AZN");
                        listBox1.Items.Add("Ödəniş: " + odenis.ToString("0.00") + " AZN");
                        listBox1.Items.Add("Qalıq: " + qaliq.ToString("0.00") + " AZN");
                    }
                    else
                    {
                        MessageBox.Show("Pul çatmır!", "Diqqət");
                    }
                }
                catch
                {
                    MessageBox.Show("Zəhmət olmasa düzgün rəqəm yaz!");
                }
            }
            else
            {
                MessageBox.Show("Ödəniş məbləğini yazın!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            
            totalPrice = 0.0;
            textBox1.Text = "";  
            textBox2.Text = ""; 
            textBox3.Text = "";
        }
    }
}

