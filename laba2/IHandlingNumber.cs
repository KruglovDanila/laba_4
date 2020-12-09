using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    interface IHandlingNumber
    {
        string GetResultCountNumberSystem(int number, int numberSystem);

        List<string> GetResultIndividualTask(int number, int numberSystem);
    }
}
