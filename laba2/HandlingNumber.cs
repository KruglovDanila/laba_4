using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class HandlingNumber : IHandlingNumber
    {
        public string GetResultCountNumberSystem(int number, int numberSystem)
        {
            return GetResultValue(number, numberSystem);
        }
        public List<string> GetResultIndividualTask(int number, int numberSystem)
        {
            List<string> result = new List<string>();

            while (numberSystem > 1)
            {
               string resultValue = GetResultValue(number, numberSystem);
               int resultParse = int.Parse(resultValue.Substring(resultValue.Length - 1));

                if (resultParse == 2)
                {
                    result.Add(numberSystem.ToString());
                }
                numberSystem--;
            }
            return result;
        }

        private string GetResultValue(int number, int numberSystem)
        {
            string result = "";
            
            if (number > 0)
            {
                while (number >= (numberSystem - 1))
                {
                    int temp = number % numberSystem;
                    number = (number - temp) / numberSystem;
                    result = Convert.ToString(temp) + result;
                }
            }
            result = Convert.ToString(number) + result;
            return result;
        }
    }
}
