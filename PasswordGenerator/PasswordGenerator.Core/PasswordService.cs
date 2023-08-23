using System.Text;

namespace PasswordGenerator
{
    public static class PasswordService
    {
        private static string _lowerCase = "abcdefghijklmnoprstquwxyz";
        private static string _upperCase = _lowerCase.ToUpper();
        private static string _digits = "0123456789";
        private static string _specialChars = "!@#$%^&*()_+-={}[]:;'|><.,?";

        public static string GeneratePassword(int lenght = 8, bool upperCase = true, bool digits = true, bool specialChars = true)
        {
                StringBuilder password = new StringBuilder();

                for (int i = 0; i < lenght; i++)
                {
                    var listNumber = Random.Shared.Next(1, 5);

                    if (upperCase && listNumber == 2)
                    {
                        var nextChar = _upperCase[Random.Shared.Next(0, _upperCase.Length)];
                        password.Append(nextChar);
                    }
                    else if (digits && listNumber == 3)
                    {
                        var nextChar = _digits[Random.Shared.Next(0, _digits.Length)];
                        password.Append(nextChar);
                    }
                    else if (specialChars && listNumber == 4)
                    {
                        var nextChar = _specialChars[Random.Shared.Next(0, _specialChars.Length)];
                        password.Append(nextChar);
                    }
                    else
                    {
                        var nextChar = _lowerCase[Random.Shared.Next(0, _lowerCase.Length)];
                        password.Append(nextChar);
                    }
                }

                return password.ToString();
        }

        public static bool ValidatePassword(string password, bool upperCase, bool digits, bool specialChars)
        {
            if (password != null)
            {
                bool haveOneLower = false;
                bool haveOneUpper = false;
                bool haveOneDigit = false;
                bool haveOneSpecial = false;

                for (int i = 0; i < password.Length; i++)
                {
                    if (_lowerCase.ToArray().Any(w => w == password[i]))
                        haveOneLower = true;
                    if (!upperCase || _upperCase.ToArray().Any(x => x == password[i]))
                        haveOneUpper = true;
                    if (!digits || _digits.ToArray().Any(y => y == password[i]))
                        haveOneDigit = true;
                    if (!specialChars || _specialChars.ToArray().Any(z => z == password[i]))
                        haveOneSpecial = true;
                }

                if (haveOneLower && haveOneUpper && haveOneDigit && haveOneSpecial)
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}
