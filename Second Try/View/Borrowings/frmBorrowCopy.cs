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
using System.Xml.Linq;

namespace View.Borrowings
{
    public partial class frmBorrowCopy : Form, IBorrowCopyView
    {
        private readonly PresenterBorrowCopy presenter;
        public frmBorrowCopy(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterBorrowCopy(library,this);
        }

       

        private void btnBorrowCopy_Click(object sender, EventArgs e)
        {
            bool validateName = Utilities.ValidateField(txtBookName, "string");
            bool validateId = Utilities.ValidateField(txtMemberId, "int");
            bool validateEdition = Utilities.ValidateField(txtCopyEdition, "int");

            if (!validateName || !validateId || !validateEdition) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                string bookName = txtBookName.Text;
                int memberId = int.Parse(txtMemberId.Text);
                int edition = int.Parse(txtCopyEdition.Text);
                presenter.BorrowBook(bookName, memberId, edition);
            }
        }
       
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
