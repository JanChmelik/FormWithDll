
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        internal Program.Validator validator;
        internal Form1Helpers helper;
        public Form1()
        {
            validator = new Program.Validator();
            helper = new Form1Helpers();
            InitializeComponent();
            btn1_submitCalculation.Enabled = false;

        }
        
        // Event 
        private async void btn1_submitCalculation_Click(object sender, EventArgs e)
        {
           // calling library with async methodes for mathematical calculations to fill label4 with solution.
            lb4_solValue.Text =(await Calculator.Calculations.Addition(helper.DoubleFromText(tb1_.Text), helper.DoubleFromText(tb2_.Text))).ToString();

        }
        #region textBox_TextChange events
        // on text_change event the Validation of text content is being called for both textBoxes.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btn1_submitCalculation.Enabled = validator.ValidateTextBox(sender);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btn1_submitCalculation.Enabled = validator.ValidateTextBox(sender);

        }
        #endregion textBox_TextChange events
    }
}
