using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDX_Extended
{
    internal class TDX_APIRateLimit
    {

        private DateTime _resetTime;
        private int _currentCallNum;
        private int MaxCalls;
        private int Period;

        public TDX_APIRateLimit(int maxCalls, int seconds)
        {
            _resetTime = DateTime.Now;
            _currentCallNum = 0;
            MaxCalls = maxCalls;
            Period = seconds;
        }

        public Task CheckRateLimit()
        {

            Console.WriteLine("Checking Rate Limit at {0}.  Count is now: {1}.  Reset time is {2}.", DateTime.Now, _currentCallNum, _resetTime);
            if (_resetTime <= DateTime.Now)
            {
                _currentCallNum = 0;
                _resetTime = DateTime.Now.AddSeconds(Period);
            }

            _currentCallNum++;
            if (_currentCallNum > MaxCalls & _resetTime > DateTime.Now)
            {
                Thread.Sleep(_resetTime - DateTime.Now);
                _currentCallNum = 1;
                _resetTime = DateTime.Now.AddSeconds(Period+1);
            }
            Console.WriteLine("Check completed at {0}.  Count is now: {1}.  Reset time is {2}.", DateTime.Now, _currentCallNum, _resetTime);
            return Task.CompletedTask;
        }
    }
}
