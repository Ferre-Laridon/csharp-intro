using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    public class FileLogger : StreamLogger
    {

        private readonly FileStream stream;

        private FileLogger(FileStream stream) : base(new StreamWriter(stream))
        {
            this.stream = stream;
        }

        public static Logger Create(string fileName)
        {
            var stream = File.OpenWrite(fileName);

            return new FileLogger(stream);
        }

        public override void Close()
        {
            this.stream.Close();
        }

    }
}
