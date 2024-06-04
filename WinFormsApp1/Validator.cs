
namespace WinFormsApp1

{

    internal static partial class Program
    {
        /// <summary>
        /// Validator class for:
        ///     1) checking if textBoxes contain number
        ///     2} noting validation results
        ///     3) if both tetBoxes are valid -> returns boolean for enabling submit button
        /// </summary>
        public class Validator
        {
            private bool tb1Valid = false;
            private bool tb2Valid = false;

            /// <summary>
            /// Method for validating numbers in textBoxes, MessageBoxing alerts and deleting undesireable inputs. As well as noting validation reults for btn1_submitCalculation enabling/disabling.
            /// </summary>
            /// <param name="tbSender">Firing object from Form1 event.</param>
            /// <returns> Forms validation result for enablig or disabling submit button.</returns>
            public bool ValidateTextBox(object tbSender)
            {
                //variables used for tryParse methode, these are not used for anything else
                double _doub;
                int _intg;

                //variable to be passed into tbValidationNoter 
                bool booForTbValidation = false;

                // conversion from generic type object to specified TextBox object for handling later
                TextBox sender = (TextBox)tbSender;


                // validating text in texBox, removing undesired input and sending validation to tbValidationNoter.

                if (booForTbValidation = sender.Text == null || sender.Text == string.Empty)
                {
                    tbValidationNoter(sender, !booForTbValidation); //booForTbValidation is oposite of if-condition
                    sender.Text = string.Empty;
                }
                else if (booForTbValidation = !double.TryParse(sender.Text, out _doub) && !int.TryParse(sender.Text, out _intg))
                {
                    MessageBox.Show($"Box: {sender.Name} needs to contain only numbers.", "Alert!");
                    tbValidationNoter(sender, !booForTbValidation);
                    sender.Text = string.Empty;
                }
                else
                {

                    tbValidationNoter(sender, true);
                }

                // checking if both textBoxes have been validated and returning corresponding value.

                if (tb1Valid && tb2Valid)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //
            /// <summary>
            /// Method for switching textBox validation (tb1/2Val), for them to be used in submit button enabling/disabling.
            /// Depends on textBox's inner text validation from ValidateTextBox(). By sender.Name it knows which textBox is being validated.
            /// </summary>
            /// <param name="sender"> TextBox from Validation function</param>
            /// <param name="inBool">Bolean information from ValidateTextBox function.</param>
            private void tbValidationNoter(TextBox sender, bool inBool)
            {
                switch (sender.Name)
                {
                    case "tb1_":
                        tb1Valid = inBool;
                        break;
                    case "tb2_":
                        tb2Valid = inBool;
                        break;
                }

            }
        }//class Validator
    }
}