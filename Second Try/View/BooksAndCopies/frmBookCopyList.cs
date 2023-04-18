using Domain;
using Presenter.BooksAndCopies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.BooksAndCopies
{
    public partial class frmBookCopyList : Form,IBookCopyListView
    {
        PresenterBookCopyList presenter;
        public frmBookCopyList(ILibrary library)
        {
            
            InitializeComponent();
            presenter = new PresenterBookCopyList(library, this);
            presenter.ShowBookList();
        }


        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            presenter.ShowBookList();
         
        }
        public void ShowBookList(string bookList)
        {
            txtList.Text = bookList;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

       
    }
}
