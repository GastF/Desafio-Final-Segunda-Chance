using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Borrowings
{
    public class PresenterReturnCopy
    {
        private readonly ILibrary library;
        private readonly IReturnCopyView view;

        public PresenterReturnCopy(ILibrary library, IReturnCopyView view)
        {
            this.library = library;
            this.view = view;
        }

        public void ReturnBook(string title, int memberId, int edition, string location)
        {
            try
            {
                // Search for the book in the library
                Book book = library.SearchBookByTitle(title);

                // Search for the member in the library
                Member member = library.SearchMemberById(memberId);

                // Search for the copy by edition
                Copy copy = null;
                foreach (Copy c in book.Copies)
                {
                    if (c.Edition == edition)
                    {
                        copy = c;
                        break;
                    }
                }

                // If the copy is not found, throw an exception
                if (copy == null)
                {
                    view.ShowMessage($"No hay ejemplares disponibles");
                }

                // Find the borrowing for this copy
                Borrowing borrowing = library.GetBorrowingByCopy(copy);

                // Remove the borrowing and return the copy to the library
                library.RemoveBorrowing(borrowing);
                member.BorrowedCopies.Remove(copy);
                member.BorrowedCopiesCount--;
                library.AddCopy(book, edition, location);

                view.ShowMessage("Se devolvio el ejemplar con exito!");
            }
            catch 
            {
                view.ShowMessage("No se pudo devolver el ejemplar");
            }
        }
      
          
        
    }
}
