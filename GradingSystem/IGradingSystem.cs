using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    internal interface IGradingSystem
    {

        public void ViewGradingInfo(
            List<Student> studs , 
            Func< List<int> , double> CalcAvg  , 
            Predicate<double> CheckIfPassed  , Action<Student , double  , bool > viewInfo);

    }
}
