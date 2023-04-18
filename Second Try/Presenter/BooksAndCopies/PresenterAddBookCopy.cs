using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Presenter.BooksAndCopies
{
    public class PresenterAddBookCopy 
    {
        private readonly ILibrary library;
        private readonly IAddBookCopyView view;
        
        public PresenterAddBookCopy(ILibrary library,IAddBookCopyView view)
        {
            this.library = library;
            this.view = view;
            
        }

        public void AddBookToLibrary(string title,int isbn, string author)
        {


            try
            {

                library.AddBook(new Book(title, isbn, author));

                view.ShowMessage("Libro agregado con exito!");
            }
            catch {
                view.ShowMessage("Hubo algun fallo al intentar agregar el libro");
            }
           
        }
        public void AddCopyToBook(Book book, int edition, string location)
        {
            try
            {
                library.AddCopy(book, edition, location);
                view.ShowMessage("Ejemplar agregado con exito!");
            }
            catch (Exception ex)
            {
                view.ShowMessage(ex.Message);
            }
        }
        public Book SearchBookByTitle(string title)
        {
            try
            {
                return library.SearchBookByTitle(title);
            }
            catch 
            {
                view.ShowMessage("No puedo encontrarse el titulo");
                return null;
            }
        }


    }
}
