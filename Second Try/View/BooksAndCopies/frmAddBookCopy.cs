using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Presenter.BooksAndCopies;

namespace View.BooksAndCopies
{
    public partial class frmAddBookCopy : Form,IAddBookCopyView
    {
       
        private readonly PresenterAddBookCopy presenter;
        public frmAddBookCopy(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterAddBookCopy(library,this);
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }


        public void btnAddBook_Click(object sender, EventArgs e)
        {
            
            bool validateName = Utilities.ValidateField(txtName, "string");
            bool validateIsbn = Utilities.ValidateField(txtISBN, "int");
            bool validateAuthor = Utilities.ValidateField(txtAuthor, "string");

            if (!validateName || !validateIsbn || !validateAuthor) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                string name = txtName.Text;
                int isbn = int.Parse(txtISBN.Text);
                string author = txtAuthor.Text;
                presenter.AddBookToLibrary(name, isbn, author);
                txtName.Text = "";
                txtAuthor.Text = "";
                txtISBN.Text = "";
            }
        }
       

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            
            bool validateBookTitle = Utilities.ValidateField(txtBookCopy, "string");
            bool validateEdition = Utilities.ValidateField(txtCopyEdition, "int");
            bool validateLocation = Utilities.ValidateField(txtCopyLocation, "string");

            if (!validateBookTitle || !validateEdition || !validateLocation) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                int edition = int.Parse(txtCopyEdition.Text);
                string location = txtCopyLocation.Text;
                string bookTitle = txtBookCopy.Text;

                Book selectedBook = presenter.SearchBookByTitle(bookTitle);
                if (selectedBook == null)
                {
                    ShowMessage($"El libro '{bookTitle}' no se encuentra en la biblioteca.");
                    return;
                }
                presenter.AddCopyToBook(selectedBook, edition, location);
            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

     
    }
}
