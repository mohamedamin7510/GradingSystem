using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal class GradingSystem : IGradingSystem
    {
        public void ViewGradingInfo(
            List<Student> studs, Func<List<int>, double> CalcAvg,
            Predicate<double> CheckIfPassed,
            Action<Student, double, bool> viewInfo)
        {
            foreach (var stud in studs)
            {
                var avg = CalcAvg.Invoke(stud.Grades);
                bool status = CheckIfPassed.Invoke(avg);
                viewInfo.Invoke(stud, avg, status);

            }



        }
    }
}
