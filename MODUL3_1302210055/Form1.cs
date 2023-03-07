namespace MODUL3_1302210055
{
    public partial class Form1 : Form
    {
        private int sum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button2.Text;
            //this.label1.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button3.Text;
            //this.label1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button4.Text;
            //this.label1.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button5.Text;
            //this.label1.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button6.Text;
            // this.label1.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button7.Text;
            //this.label1.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button8.Text;
            //this.label1.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button9.Text;
            //this.label1.Text += 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button11.Text;
            // this.label1.Text += 0;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(this.label1.Text);
            this.label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sum += Convert.ToInt32(this.label1.Text);
            this.label1.Text = " " + sum;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}