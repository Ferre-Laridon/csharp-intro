using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    public class LogBroadcaster : Logger
    {

        private readonly IList<Logger> loggers;

        public LogBroadcaster(IEnumerable<Logger> loggers) 
        {
            this.loggers = loggers.ToList();
        }

        public override void Log(string message)
        {
            foreach (var log in loggers)
            {
                log.Log(message);
            }
        }

        public override void Close()
        {
            foreach (var log in loggers)
            {
                log.Close();
            }
        }
    }
}
