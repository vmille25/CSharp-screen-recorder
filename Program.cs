using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Captura;

namespace screen_recorder
{
    class Program
    {
        static void Main(string[] args)
        {
            var rec = new Recorder(new RecorderParams("out.avi", 10, SharpAvi.KnownFourCCs.Codecs.MotionJpeg, 70));
            Console.WriteLine("Press any key to Stop...");
            Console.ReadKey();

            // Finish Writing
            rec.Dispose();
        }
    }
}
