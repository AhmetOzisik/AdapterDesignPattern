using System;

namespace AdapterDesignExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatOynatıcı formatOynatıcı = new IPlayerAdapter(new MP3Player());
            formatOynatıcı.Oynat();
            Console.WriteLine();
        }
    }
}
