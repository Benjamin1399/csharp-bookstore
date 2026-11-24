using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_bookstore
{
    public class ConsoleOperations
    {
        public string GetStringInput(string message)
        {
            DisplayMessage(message);

            return Console.ReadLine();
        }

        public int GetIntInput(string message)
        {
            DisplayMessage(message);

            string intText = Console.ReadLine();

            bool validInt = int.TryParse(intText, out int value);

            if (validInt)
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        public decimal GetDecimalInput(string message)
        {
            DisplayMessage(message);

            string intText = Console.ReadLine();

            bool validDecimal = Decimal.TryParse(intText, out decimal value);

            if (validDecimal)
            {
                return value;
            }
            else
            {
                return 0;
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
