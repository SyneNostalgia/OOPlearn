namespace OOPlearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product p1 = new product();
            p1.Name = "ปากกา";
            p1.Price = 10;

            textBox1.Text = p1.Name;
            textBox2.Text = p1.Price.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            product p1 = new product();
            p1.Name = "ดาบศักดิ์สิทธิ์";
            p1.Price = 500000;

            textBox1.Text = p1.Name;
            textBox2.Text = p1.Price.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product2 p2 = new Product2();
            //p2.Name = "คณะหมอลำซิ่ง";
            //p2.Price = 2400000;
            //p2.UnitInStock = 7;
            //p2.Unit = "คณะ";/

            textBox1.Text = p2.Name;
            textBox2.Text = p2.Price.ToString();
            textBox3.Text = p2.UnitInStock.ToString();
            textBox4.Text = p2.Unit;

            string msg = p2.Name + " " + p2.Price.ToString() + Environment.NewLine;
            msg += "คงเหลือ " + p2.UnitInStock.ToString() + " " + p2.Unit;
            MessageBox.Show(msg, "สินค้าใน stock");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            product p1 = new product("สินค้าหมดอายุ", 2000);

            textBox1.Text = p1.Name;
            textBox2.Text = p1.Price.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ThaiDate tt = new ThaiDate();
            //string msg = "ปี ค.ศ. " + tt.GetCurrentYear().ToString() + Environment.NewLine;
            //msg += "ปี พ.ศ. " + tt.GetCurrentThaiYear().ToString();
            //MessageBox.Show(msg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string msg = "ปี ค.ศ. " + ThaiDate.GetCurrentYear().ToString() + Environment.NewLine;
            msg += "ปี พ.ศ. " + ThaiDate.GetCurrentThaiYear().ToString();
            MessageBox.Show(msg);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ThaiDate.ThaiDayName x = ThaiDate.ThaiDayName.จันทร์;
            MessageBox.Show(x.ToString());

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Type t = typeof(ThaiDate.ThaiDayName);
            string[] tday = Enum.GetNames(t);

            listBox1.Items.AddRange(tday);
        }
    }
}
