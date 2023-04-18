using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ILibrary
    {
        List<Book> GetBooks();
        List<Borrowing> GetBorrowings();
        List<Member> GetMember();
        Borrowing GetBorrowingByCopy(Copy copy);
        
        Book SearchBookByTitle(string title);
        Member SearchMemberById(int id);
       

        void AddBook(Book book);
        void RemoveBook(Book book);
        void AddCopy(Book copy,int edition, string location);
        void RemoveCopy(Copy copy);
        void AddMember(string name, string lastName, int id, decimal monthlyInstallment = 0);
        void RemoveMember(int id);
        void AddBorrowing(Borrowing borrowing);
        void RemoveBorrowing(Borrowing borrowing);

        string ListBooksAndCopies();
        string ListBorrowedBooks();
        string ListMembers();
    }
}
