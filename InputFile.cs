using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_лаба_номер_2
{
    class InputFile
    {
        StreamReader reader;
        public InputFile()
        {
            ReadInputData();
        }
        private void ReadInputData()
        {
            reader = new StreamReader("DataTxt.txt");

            int count = File.ReadAllLines("DataTxt.txt").Length;
            reader.ReadToEnd().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < count; i++)
            {
                //reader.Read(reader, i,);
            }
        }

    }
}
