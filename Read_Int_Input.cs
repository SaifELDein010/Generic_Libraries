
using System;

namespace Generic_Libraries
{
    class Read_Int_Input
    {

        public static bool IsNumber(string number)
        {

            return int.TryParse(number, out int i);

        }


        public static int ReadNumber(string errorMessage = "Not vaild number, Enter a vaild number: ")
        {

            int number = 0;
            string textNumber = Console.ReadLine();

            while(!IsNumber(textNumber))
            {

                Console.Write(errorMessage);
                textNumber = Console.ReadLine();

            }

            number = Convert.ToInt32(textNumber);

            return number;

        }


        public static int ReadNumber(string message, string errorMessage = "Not vaild number, Enter a vaild number: ")
        {

            Console.Write(message);
            return ReadNumber(errorMessage);

        }
        





    }
}
