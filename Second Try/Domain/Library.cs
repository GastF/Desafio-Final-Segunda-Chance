using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Library : ILibrary
    {

        private List<Member> members;
        private List<Book> books;
        private List<Borrowing> borrowings;
        private List<Copy> copies;
   

        public Library()
        {
            members = new List<Member>();
            books = new List<Book>();
            borrowings = new List<Borrowing>();
           
        }

        #region Methods for Adding or Removing elements
        public void AddMember(string name, string lastName, int id, decimal monthlyInstallment = 0)
        {
            if (monthlyInstallment > 0)
            {
                members.Add(new VipMember(name, lastName, id, monthlyInstallment));
            }
            else
            {
                members.Add(new Member(name, lastName, id, false));
            }
        }
        public void RemoveMember(int id)
        {
            Member memberToRemove = null;
            foreach (Member member in members)
            {
                if (member.Id == id)
                {
                    memberToRemove = member;
                    break;
                }
            }
            if (memberToRemove != null)
            {
                members.Remove(memberToRemove);
            }
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

       
        public void AddCopy(Book book, int edition, string location)
        {
            // Find the book in the list of books
            Book existingBook = null;
            foreach (Book b in books)
            {
                if (b.codeISBN == book.codeISBN)
                {
                    existingBook = b;
                    break;
                }
            }

            // If the book is not found, throw an exception
            if (existingBook == null)
            {
                throw new Exception($"Book with ID {book.codeISBN} not found in library");
            }

            // Create a new copy of the book
            Copy copy = new Copy(existingBook, edition, location);

            // Add the copy to the book's list of copies
            existingBook.AddCopy(copy);
        }
        public void RemoveCopy(Copy copy)
        {
            // Find the book that the copy belongs to
            Book book = null;
            foreach (Book b in books)
            {
                if (b.Copies.Contains(copy))
                {
                    book = b;
                    break;
                }
            }

            // If the book is not found, throw an exception
            if (book == null)
            {
                throw new Exception($"Copy with ID {copy.Book.codeISBN}-{copy.Edition} not found in library");
            }

            // Remove the copy from the book's list of copies
            book.Copies.Remove(copy);
        }

        public void AddBorrowing(Borrowing borrowing)
        {
            borrowings.Add(borrowing);
        }
        public void RemoveBorrowing(Borrowing borrowing)
        {
            borrowings.Remove(borrowing);
        }

        public Member SearchMemberById(int id)
        {
            foreach (Member member in members)
            {
                if (member.Id == id)
                {
                    return member;
                }
            }

            return null;
        }
        public Book SearchBookByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.name == title)
                {
                    return book;
                }
            }

            return null;
        }
        public Borrowing GetBorrowingByCopy(Copy copy)
        {
            foreach (Borrowing borrowing in borrowings)
            {
                if (borrowing.Copy == copy && borrowing.ReturnDate == null)
                {
                    return borrowing;
                }
            }
            return null;
        }

        #endregion
        #region Methods for displaying list

        public string ListMembers()
        {
            string memberList = "";
            foreach (Member member in members)
            {
                if (member is VipMember)
                {
                    memberList += ($"(VIP)\nNombre: {member.Name}\nApellido: {member.LastName}\nID:{member.Id}\nEjemplares en posesion:{member.BorrowedCopiesCount}\n\n");
                }
                else
                {
                    memberList += ($"(STANDART)\nNombre: {member.Name}\nApellido: {member.LastName}\nID:{member.Id}\nEjemplares en posesion:{member.BorrowedCopiesCount}\n\n");
                }
            }
            return memberList;
        }
        public string ListBooksAndCopies()
          {
              string bookListString = "Lista de libros:\n\n";
              foreach (Book book in books)
              {
                  bookListString += $"Título: {book.name}\n" +
                                    $"Autor: {book.author}\n" +
                                    $"ISBN: {book.codeISBN}\n\n"+
                                    $"Copias: {book.Copies.Count}\n\n";

                if (book.Copies.Count > 0)
                {
                    bookListString += "Lista de copias:\n";
                    foreach (Copy copy in book.Copies)
                    {
                        bookListString += $"Edición: {copy.Edition}\n" +
                                          $"Ubicación: {copy.Location}\n\n";
                    }
                }

                bookListString += "\n";
            }

              return bookListString;
          }
        public string ListBorrowedBooks()
        {
            string borrowedBooksList = "";
            foreach (Borrowing borrowing in borrowings)
            {
                borrowedBooksList += ($"Miembro:{borrowing.Member.Name} {borrowing.Member.LastName}\n Ejemplar en posesion:{borrowing.Copy.Book.name} - {borrowing.Copy.Book.author}\n Fecha del prestamo:{borrowing.BorrowingdDate.ToString("dd/MM/yyyy")}\n\n");
            }
            return borrowedBooksList;
        }
        public List<Member> GetMember()
        {
            return members;
        }
        public List<Book> GetBooks()
        {
            return books;
        }
        public List<Borrowing> GetBorrowings()
        {
            return borrowings;
        }
       
        #endregion  
    }
}
