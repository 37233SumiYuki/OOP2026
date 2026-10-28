using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    internal class Take20Processor : ITextFileService {
        int count;

        public void Initialize(string filename) {
            count = 0;
        }
             

        public void Execute(string line) {
            if(count < 20) {
                Console.WriteLine(line);
                count++;
            }
        }

        public void Terminate() {

        }
    }
}


