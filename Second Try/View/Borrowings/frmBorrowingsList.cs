using Domain;
using Presenter.Borrowings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Borrowings
{
    public partial class frmBorrowingsList : Form,IBorrowingsView
    {
        PresenterBorrowingsList presenter;
        public frmBorrowingsList(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterBorrowingsList(library, this);
            presenter.ShowBorrowingsList();
        }

       
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            presenter.ShowBorrowingsList();
        }
        public void ShowBorrowingsList(string borrowingList)
        {
            txtList.Text = borrowingList;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
