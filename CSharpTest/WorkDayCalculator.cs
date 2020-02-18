using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            DateTime currDate = startDate;
            int currDay = currDate.Day;
            while(dayCount != 0){
                if(currDay != startDate.Day && currDay < weekEnds[0].StartDate.Day && currDay > weekEnds[0].EndDate.Day) {
                    currDay++;
                    dayCount--;
                }
                
            }
            
            DateTime endD = currDate; 
            return endD;
        }
    }
}
