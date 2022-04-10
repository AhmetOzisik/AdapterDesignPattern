using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignExample
{
    public class IPlayerAdapter : IFormatOynatıcı
    {
        private Iplayer Iplayer;
        public IPlayerAdapter(Iplayer ıplayer)
        {
            this.Iplayer = ıplayer;
        }
        public void Oynat()
        {
            Iplayer.Oynat();
        }
    }
}
