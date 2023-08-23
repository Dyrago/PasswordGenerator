using PasswordGenerator;
using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.UI
{
    public partial class Form1 : Form
    {
        private string _password;

        public Form1()
        {
            InitializeComponent();
        }

        private void PasswordField_TextChanged(object sender, EventArgs e)
        {
        }

        private void PassLenght_ValueChanged(object sender, EventArgs e)
        {
        }

        private void UpperCase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Digits_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void SpecialChars_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            GeneratePassword(ref _password);

            if (PasswordService.ValidatePassword(_password, UpperCase.Checked, Digits.Checked, SpecialChars.Checked))
                PasswordField.Text = _password;
            else
                Generate_Click(new object(), new EventArgs());
        }

        private void GeneratePassword(ref string password)
        {
            password = PasswordService.GeneratePassword(Convert.
                ToInt32(PassLenght.Value), UpperCase.Checked, Digits.Checked, SpecialChars.Checked);
        }
    }
}