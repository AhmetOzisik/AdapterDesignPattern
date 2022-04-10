using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignExample
{
    public class MP3Player : Iplayer
    {
        public void Oynat()
        {
            Console.WriteLine("MP3 oynatildi.");
        }
    }
}
