using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class Magazine : Product
    {
        private string issue;

        public string Issue { get => issue; set => issue = value; }

        enum Type {Actual, News, Sport, Computer,Technology}


    }
}
