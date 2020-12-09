using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
{
    class NumberSystemPresenter
    {
        private INumberSystemView view;
        private IHandlingNumber handlingNumber;

        public NumberSystemPresenter(INumberSystemView view, IHandlingNumber handlingNumber)
        {
            this.view = view;
            this.handlingNumber = handlingNumber;
        }

        public void CheckInputNumbers(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        public void CountNumberSystem(int number, int numberSystem)
        {
            string result = handlingNumber.GetResultCountNumberSystem(number, numberSystem); 
            view.ShowResultCounting(result);
        }

        public void CountIndividualTask(int number, int numberSystem)
        {
            var result = handlingNumber.GetResultIndividualTask(number,numberSystem);

            view.ShowIndividualTask(HandleResultIndividualTask(result));
        }

        private List<string> HandleResultIndividualTask(List<string> listValues)
        {
            if (listValues.Count == 0)
            {
                listValues.Add("Пусто!");
                return listValues;
            }

            List<string> result = new List<string>();

            for (int i = listValues.Count - 1; i >= 0; i--)
            {
                if (i == 1)
                {
                    result.Add(listValues[i] + ", ");
                }
                else
                {
                    result.Add(listValues[i]);
                }
            }
            return result;
        }
    }
}