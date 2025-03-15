
using System;

namespace Generic_Libraries
{
    class Read_Int_Input
    {

        public static bool IsIntNumber(string number)
        {

            return int.TryParse(number, out int i);

        }


        





    }
}
