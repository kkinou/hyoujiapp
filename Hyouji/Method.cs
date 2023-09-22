using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyouji
{
    internal class Method
    {
        string filePath = "SaveText.txt";
        public void Savetext(string TextContents)
        {
            using(StreamWriter Writer = new StreamWriter(filePath,true))
            {
                Writer.WriteLine(TextContents);
            }
        }
    }
}
