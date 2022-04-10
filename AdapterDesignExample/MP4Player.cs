using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignExample
{
    public class MP4Player : Iplayer
    {
        public void Oynat()
        {
            Console.WriteLine("MP4 oynatildi.");
        }
    }
}
