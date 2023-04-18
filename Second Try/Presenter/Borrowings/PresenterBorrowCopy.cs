using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Borrowings
{
    public class PresenterBorrowCopy
    {
        private readonly ILibrary library;
        private readonly IBorrowCopyView view;

        public PresenterBorrowCopy(ILibrary library, IBorrowCopyView view)
        {
            this.library = library;
            this.view = view;
        }

        public void BorrowBook(string title, int memberId,int edition)
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


                if (member is VipMember && member.BorrowedCopiesCount >= 3)
                {
                    view.ShowMessage("El miembro ya tiene el máximo de ejemplares prestados permitidos.");
                    return;
                }
                if (member is Member && member.BorrowedCopiesCount >= 1 && !(member is VipMember))
                {
                    view.ShowMessage("El miembro ya tiene el máximo de ejemplares prestados permitidos.");
                    return;
                }
                

                // Realiza el préstamo
                Borrowing borrowing = new Borrowing(member, copy);
                member.BorrowedCopies.Add(copy);
                library.AddBorrowing(borrowing);
                member.BorrowedCopiesCount++;
                library.RemoveCopy(copy);

                view.ShowMessage("El ejemplar se prestó con éxito.");
            }
            catch 
            {
                view.ShowMessage("No se pudo prestar el ejemplar");
            }
        }
    }
}
