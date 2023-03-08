using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    public class StreamLogger : Logger
    {

        private readonly StreamWriter writer;

        public StreamLogger()
        {
        }

        public StreamLogger(StreamWriter writer) 
        {
            this.writer = writer;
        }

        public override void Log(string message)
        {
            this.writer.WriteLine(message);
            this.writer.Flush();
        }
    }
}
