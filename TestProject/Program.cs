namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var lvTestFunctions = new TestFunctions();
            lvTestFunctions.TestFunction1();

            //

            /*
             * Write TestFunction2
             * it should take 2 arguments.
             *      arg1 = a string that tells the function what filename to write or append to
             *      arg2 = a string that is appended to the file on a new line
             * 
             * TestFunction2 should write arg2 to the end of file arg1           
            */

            /*
             * Write TestFunction3
             * it should take 3 arguments.
             *      arg1 = a string that tells the function what filename to write or append to
             *      arg2 = a string that is appended to the file on a new line
             *      arg3 = an int that determines the number of times arg2 should be appended to the file
             * 
             * TestFunction3 should write arg2 to file arg1, arg3 times
            */

            /*
             * Write TestFunction4
             * it should take 2 arguments.
             *      arg1 =  a string that tells the function what filename to write or append to
             *      arg2 =  an int that is added on to the last number written to the file. This result should
             *              be appended to the file on a new line. If there are no numbers yet, assume you are adding onto 0
             * 
             * TestFunction4 should add the last entry in file arg1 onto arg2 and store it at the end of the file
             * 
             * HINT::   A helper method called GetInt has been defined in Utility.cs. TestFunctions.cs includes access 
             *          to this file and its methods should you need to call them           
            */
        }
    }
}
