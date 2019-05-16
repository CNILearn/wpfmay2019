using System;

namespace UnitTestSample
{
    public class DeepThought
    {
        public int TheAnswerOfTheUniverse() => 42;

        public string SomeString(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            string result;
            if (input.Length > 3)
            {
                result = input.ToUpper();
            }
            else
            {
                result = input.ToLower();
            }
            return result;
        }
    }
}
