using Domain;
using Presenter.BooksAndCopies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Borrowings
{
    public class PresenterBorrowingsList
    {
        private readonly ILibrary library;
        private readonly IBorrowingsView view;
        public PresenterBorrowingsList(ILibrary library, IBorrowingsView view)
        {
            this.view = view;
            this.library = library;

        }
        public void ShowBorrowingsList()
        {
            var borrowings = library.GetBorrowings();
            string borrowingList = library.ListBorrowedBooks();
            view.ShowBorrowingsList(borrowingList);
        }

    }
}
