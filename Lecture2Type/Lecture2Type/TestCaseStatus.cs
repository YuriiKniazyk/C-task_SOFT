using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Type
{
    class TestCaseStatus
    {
        public void GetStatus()
        {
            var test1Status = (int) TestCaseStatusEnum.Pass;

            Console.WriteLine($"TestCaseStatus enum {test1Status}");
            Console.WriteLine();
        }
    }
}
