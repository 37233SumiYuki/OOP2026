using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TextFileProcessorDI {
    internal class TextFileProcessor {
        private ITextFileService _servies;

        public TextFileProcessor (ITextFileService service) {
            _servies = service;
        }

        public void Run(string fileName) {
            _servies.Initialize(fileName);
            var lines = File.ReadLines(fileName);
            foreach(var line in lines) {
                _servies.Execute(line);
            }
            _servies.Terminate();
        }
    }
}
