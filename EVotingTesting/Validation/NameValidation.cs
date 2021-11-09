namespace EVotingTesting.Validation
{
    public class NameValidation
    {
        /// <summary>
        /// Validates the name if its empty or contains non alphabetical letters
        /// </summary>
        /// <param name="value">The value here represents the name</param>
        /// <returns>True if the name is valid otherwise false if the name is invalid</returns>
        public bool IsValid(object value)
        {
            string Name = (string)value;

            if (Name == null || Name.Length == 0 || Name.Length > 15)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (IsLetter(Name[i]) == false)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsLetter(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                return true;
            }
            return false;
        }
    }
}