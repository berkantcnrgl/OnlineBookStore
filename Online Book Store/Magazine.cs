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

        public string Issue
        {
            get
            {
                return issue;
            }
            set
            {
                issue = value;
            }
        }

        enum Type { Gündem, Haber, Spor, Bilişim, Teknoloji, Siyaset , Bilim , Tarih, Yemek}

        public Magazine(string id, string name, double price) : base(id, name, price) { }
    }
}
