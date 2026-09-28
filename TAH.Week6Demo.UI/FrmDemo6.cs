namespace TAH.Week6Demo.UI
{
    public partial class FrmDemo6 : Form
    {
        public FrmDemo6()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the application
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //makes a variable to hold the age
            int score = 0;

            //validates the input
            if (string.IsNullOrWhiteSpace(txtInput.Text) || !int.TryParse(txtInput.Text, out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Error: Invalid integer.");
                return;
            }

            //Converts the input to a letter grade and shows it on the label
            if (score >= 90)
            {
                //only if true will this code would fire
                lblResult.Text = "A";
            }
            else if (score >= 80)
            {
                lblResult.Text = "B";
            }
            else if (score >= 70)
            {
                lblResult.Text = "C";
            }
            else if (score >= 60)
            {
                lblResult.Text = "D";
            }
            else
            {
                lblResult.Text = "F";
            }
        }
    }
}
