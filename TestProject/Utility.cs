using System;
namespace TestProject
{
    public class Utility
    {
        public static int GetInt(string argInt)
        {
            bool lvSuccess = Int32.TryParse(argInt, out int lvResult);
            return lvSuccess ? lvResult : 0;
        }
    }
}
