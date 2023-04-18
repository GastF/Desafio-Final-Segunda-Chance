using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Copy
    {
        private Book book;
        private int edition;
        private string location;
        private bool isBorrowed;

        public Book Book { get => book; set => book = value; }
        public int Edition { get => edition; set => edition = value; }
        public string Location { get => location; set => location = value; }

        public Copy(Book book, int edition, string location)
        {
            this.book = book;
            this.edition = edition;
            this.location = location;

        }
        #region Methods
        public bool IsAvailable()
        {
            return !isBorrowed;
        }

        public void Borrow()
        {
            isBorrowed = true;
        }

        public void Return()
        {
            isBorrowed = false;
        }
        #endregion
    }
}