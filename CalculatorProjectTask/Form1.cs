namespace CalculatorProjectTask
{
    public partial class Form1 : Form
    {

        string op="";
        double rst = 0;
        int isop = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0" || isop > 0)
            {
                textBox1.Clear();
            }
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }
            }
            else
                textBox1.Text = textBox1.Text + btn.Text;
            isop = 0;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op = btn.Text;
            rst = double.Parse(btn.Text);
            isop += 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    rst = rst + double.Parse(textBox1.Text);
                    textBox1.Text = rst.ToString(); 
                    break;
                case "-":
                    rst = rst - double.Parse(textBox1.Text);
                    textBox1.Text = rst.ToString();
                    break;
                case "÷":
                    rst = rst / double.Parse(textBox1.Text);
                    textBox1.Text = rst.ToString();
                    break;
                case "×":
                    rst = rst * double.Parse(textBox1.Text);
                    textBox1.Text = rst.ToString();
                    break;
                default:
                    textBox1.Text = "0";
                    break;
            }
        }
    }
}