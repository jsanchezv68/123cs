namespace Calculadora_Examen
{
    public partial class Calculadora : Form
    {
        double primernum;
        double segundonum;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.ClassSuma obj = new Clases.ClassSuma();
        Clases.ClassResta obj2 = new Clases.ClassResta();
        Clases.ClassMult obj3 = new Clases.ClassMult();
        Clases.ClassDivi obj4 = new Clases.ClassDivi();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
                textBox1.Text = "";
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primernum = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primernum = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primernum = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primernum = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            segundonum = double.Parse(textBox1.Text);

            double Sum;
            double Rest;
            double Mul;
            double Div;

            switch(operacion)
            {
                case "+":
                    Sum = obj.Suma((primernum), (segundonum));
                    textBox1.Text = Sum.ToString();
                    break;
                case "-":
                    Rest = obj2.Resta((primernum), (segundonum));
                    textBox1.Text = Rest.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primernum), (segundonum));
                    textBox1.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Division((primernum), (segundonum));
                    textBox1.Text = Div.ToString();
                    break;
            }
        }
    }
}