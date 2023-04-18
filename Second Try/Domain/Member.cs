using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Member
    {
        private string name;
        private string lastName;
        private int id;
        private int bookMax;
        private List<Copy> borrowedCopies;
        public int BorrowedCopiesCount;

        public Member(string name, string lastName, int id, bool vipMember)
        {
            this.name = name;
            this.lastName = lastName;
            this.id = id;
            borrowedCopies = new List<Copy>();
            bookMax = vipMember ? 3 : 1;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int BookMax { get => bookMax; set => bookMax = value; }
        public List<Copy> BorrowedCopies { get => borrowedCopies; set => borrowedCopies = value; }

        #region Methods
        public bool AskAvailableQuota()
        {
            return BorrowedCopiesCount <= bookMax;
        }

        public void Borrow(Copy copy)
        {
           
            if (AskAvailableQuota() && !copy.IsAvailable())
            {
                
                    borrowedCopies.Add(copy);
                    copy.Borrow();
                
            }
            else { Console.WriteLine("No se pudo prestar el ejemplar"); }
        }

        public void ReturnCopy(Copy copy)
        {
            if (borrowedCopies.Contains(copy))
            {
                borrowedCopies.Remove(copy);
                copy.Return();
            }
        }
       
        #endregion
    }
}
