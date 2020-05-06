using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class logger
    {
        private static logger _logger;
        private string FileName;
        private static bool instatieted=false;

        public static void SetInstance(string a)
        {
            if (instatieted) {
                throw new Exception("Alerady instieted");
            }
            
            _logger = new logger(a);
            instatieted = true;
            

        } 
        public static logger GetInstance()
        {
            if (instatieted )
            {
          
                return _logger;

            }
           else
            {
                throw new Exception("not instatieted");
            }


        }
        public void log(string text)
        {
            using (StreamWriter sw = File.AppendText(this.FileName))
            {
                sw.WriteLine(text);

             
            }
        }
        public static void logstatic(string text)
        {
            using (StreamWriter sw = File.AppendText(GetInstance().FileName)) 
            {
                sw.WriteLine(text);


            }

        }
        public logger()
        {
                
        }
        public logger(string a)
        {
            FileName = a;

        }
    }
}
