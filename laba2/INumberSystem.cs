using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    interface INumberSystemView
    {
        void ShowResultCounting(string result);

        void ShowIndividualTask(List<string> result);
    }
}
