using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    internal static class CustomerInterface
    {
        private static List<string> customerType = new List<string> { "picky", "choosy", "average", "friendly", "kind" };
        private static Random rand = new Random();

        public static void RandomizeCustomer(List<bool> custTrueFalse)
        {
            string custPersonality = customerType[rand.Next(customerType.Count)];
            if (custPersonality == "picky")
            {
                custTrueFalse.Add(false);
                custTrueFalse.Add(false);
            }
            else if (custPersonality == "choosy")
            {
                custTrueFalse.Add(false);
            }
            else if (custPersonality == "friendly")
            {
                custTrueFalse.Add(true);
            }
            else if (custPersonality == "kind")
            {
                custTrueFalse.Add(true);
                custTrueFalse.Add(true);
            }
            else
            {
                bool additionalOption = custTrueFalse[rand.Next(custTrueFalse.Count)];
                custTrueFalse.Add(additionalOption);
            }

        }

    }
}
