using System.Linq;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string numbers)
        {
            var splitNumbers = numbers.split(',');
            if(!splitNumbers.Any())
            {
                return 0;
            } 
            if(splitNumbers.length == 1)
            {
                if(splitNumbers[0].length==0)
                {
                    return 0;
                }
                return int.parse(splitNumbers[0]);
            }
            return int.parse(splitNumbers[0] + int.parse(splitNumbers[1]));
        }
    }
}