namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txtLength.Text);
            double width = double.Parse(txtWidth.Text);
            double area = CalculateArea1(length, width);
            DisplayResult("Rectangle", area);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txtRadius.Text);
            double area = CalculateArea2(radius);
            DisplayResult("Circle", area);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double baseLength = double.Parse(txtBase.Text);
            double height = double.Parse(txtHeight.Text);
            double area = CalculateArea3(baseLength, height);
            DisplayResult("Triangle", area);

        }
        private double CalculateArea1(double length, double width)
        {
            return length * width;
        }

        private double CalculateArea2(double radius)
        {
            return Math.PI * radius * radius;
        }

        private double CalculateArea3(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        private void DisplayResult(string shape, double area)
        {
            string result = $"{shape}: {area}";
            listBox1.Items.Add(result);
            txtRecentResult.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
