using EVotingTesting.Constants;

namespace EVotingTesting.Validation
{
    public class GenderValidation
    {
        /// <summary>
        /// Validates the Gender if it contains the accurate gender values
        /// </summary>
        /// <param name="value">The value here represents the gender</param>
        /// <returns>True if the gender is valid otherwise false if the gender is invalid</returns>
        public bool IsValid(object value)
        {
            string Gender = (string)value;

            if (Gender == null || Gender.Equals(Config.Male) || Gender.Equals(Config.Female))
            {
                return true;
            }

            return false;
        }
    }
}