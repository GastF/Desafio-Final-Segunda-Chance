
using View.Borrowings;
using View.Members;
using View.BooksAndCopies;
using Presenter.BooksAndCopies;
using Domain;

namespace View
{
    public partial class frmLibrary : Form
    {
        ILibrary library = new Library();

        public frmLibrary()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Book Copy Buttons
        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
             
             
             frmAddBookCopy addBookCopy = new frmAddBookCopy(library);
             addBookCopy.Show();
        }

        private void btnBookCopyList_Click(object sender, EventArgs e)
        {
            
            frmBookCopyList bookCopyList = new frmBookCopyList(library);
            bookCopyList.Show();
        }
        
        private void btnRemoveBookCopy_Click(object sender, EventArgs e)
        {
            frmRemoveBookCopy removeBookCopy = new frmRemoveBookCopy(library);
            removeBookCopy.Show();
        }
        #endregion
        #region Member Buttons Region
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember addMember = new frmAddMember(library);
            addMember.Show();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            frmListMembers memberList = new frmListMembers(library);
            memberList.Show();
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            frmRemoveMember removeMember = new frmRemoveMember(library);
            removeMember.Show();
        }
        #endregion
        #region Borrowings Buttons Region
        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrowCopy borrowCopy = new frmBorrowCopy(library);
            borrowCopy.Show();
        }

        private void btnBorrowingList_Click(object sender, EventArgs e)
        {
            frmBorrowingsList borrowingsList = new frmBorrowingsList(library);
            borrowingsList.Show();
        }

        private void btnReturnCopy_Click(object sender, EventArgs e)
        {
            frmReturnCopy returnCopy = new frmReturnCopy(library);
            returnCopy.Show();
        }
        #endregion
    }
}
