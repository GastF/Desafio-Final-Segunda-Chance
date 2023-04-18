using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.BooksAndCopies
{
    public class PresenterBookCopyList 
    {
        private readonly ILibrary library;
        private readonly IBookCopyListView view;
        public PresenterBookCopyList(ILibrary library,IBookCopyListView view) 
        { 
            this.view = view;
            this.library= library;
            
        }
        public void ShowBookList()
        {
            var books = library.GetBooks();
            string bookList = library.ListBooksAndCopies();
            view.ShowBookList(bookList);
        }

    }
}
