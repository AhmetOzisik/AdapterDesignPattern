using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignExample
{
    public class AviPlayer : IFormatOynatıcı
    {
        public void Oynat()
        {
            Console.WriteLine("AviPlayer oynatildi.");
        }
    }
}
