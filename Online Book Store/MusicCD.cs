using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class MusicCD : Product
    {
        private int releaseDate;

        private string singer;
        private string isbn;
        private string content;

        enum Type { Pop, Rock, Klasik, Opera, Caz, Blues , Rap}

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                isbn = value;
            }
        }

        public string Singer
        {
            get
            {
                return singer;
            }

            set
            {
                singer = value;
            }
        }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }

            set
            {
                releaseDate = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public MusicCD(string id, string name, double price) : base(id, name, price) { }
    }
}
