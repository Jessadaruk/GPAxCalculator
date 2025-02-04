namespace Gpax
{
    public partial class Form1 : Form
    {

        GPACalculator gPACalculator;
        public Form1()
        {

            InitializeComponent();
            gPACalculator = new GPACalculator();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                double input = double.Parse(this.tbInputGPA.Text);
                gPACalculator.setGPA(input);

                // แสดงผล GPA เฉลี่ย
                this.tbGPAx.Text = gPACalculator.getGPAX().ToString();

                // แสดงผล GPA สูงสุด
                this.tbMaxGPA.Text = gPACalculator.getMaxGPA().ToString();

                // แสดงผล GPA ต่ำสุด
                this.tbMinGPA.Text = gPACalculator.getMinGPA().ToString();

                this.tbTotalPeople.Text = gPACalculator.getTotalPeople().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ตัวเลขไม่ถูกต้อง");
                this.tbInputGPA.Text = String.Empty;
            }

        }
        
    }
}





