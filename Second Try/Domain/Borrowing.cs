using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Borrowing
    {
        private Copy copy;
        private Member member;
        private DateTime borrowingdDate;
        private DateTime returnDate;

        public Borrowing(Member member, Copy copy)
        {
            this.member = member;
            this.copy = copy;
            borrowingdDate = DateTime.Today;
        }

        public Copy Copy { get => copy; set => copy = value; }
        public Member Member { get => member; set => member = value; }
        public DateTime BorrowingdDate { get => borrowingdDate; set => borrowingdDate = value; }
        public DateTime ReturnDate { get => returnDate; set => returnDate = value; }

        public bool IsExpired()
        {
            DateTime expirationDate = borrowingdDate.AddDays(5);
            return DateTime.Today > expirationDate;
        }
        public void ReturnCopy()
        {
            ReturnDate = DateTime.Now;
        }
    }
}
