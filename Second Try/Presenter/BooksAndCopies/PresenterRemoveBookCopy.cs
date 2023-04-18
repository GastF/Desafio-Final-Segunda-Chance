using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.BooksAndCopies
{
    public class PresenterRemoveBookCopy
    {
        private readonly ILibrary library;
        private readonly IRemoveBookCopyView view;

        public PresenterRemoveBookCopy(ILibrary library, IRemoveBookCopyView view)
        {
            this.library = library;
            this.view = view;

        }

        public void RemoveBookFromLibrary(string title)
        {
            try
            {
                Book book = library.SearchBookByTitle(title);
                if (book != null)
                {

                    library.RemoveBook(book);
                    view.ShowMessage("El libro fue removido con exito.");
                }
                else { view.ShowMessage("No se encotro el libro dentro de la biblioteca"); }
                
            }
            catch(Exception ex)
            {
                view.ShowMessage("No se pudo remover el libro.");
            }
        }
        public void RemoveCopy(string bookTitle, int edition)
        {
            try
            {
                // Search for the book by title
                Book book = library.SearchBookByTitle(bookTitle);

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
                    view.ShowMessage ($"El ejemplar edicion: {edition} no fue encontrado para el libro {bookTitle}");
                }

                // Remove the copy from the library
                library.RemoveCopy(copy);

                view.ShowMessage("El Ejemplar fue removido con exito!");
            }
            catch 
            {
                view.ShowMessage("No se pudo remover el ejemplar deseado");
            }
        }

    }
}
