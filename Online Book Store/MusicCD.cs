using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class MusicCD
    {
        private string singer;
        enum Type { Romance, HardRock, Country }

        public string Singer { get => singer; set => singer = value; }
    }
}
