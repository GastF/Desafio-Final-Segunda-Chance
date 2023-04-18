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
    
    public partial class frmReturnCopy : Form,IReturnCopyView
    {
        private readonly PresenterReturnCopy presenter;
        public frmReturnCopy(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterReturnCopy(library, this);
        }

  
        private void btnReturnCopy_Click(object sender, EventArgs e)
        {
            bool validateName = Utilities.ValidateField(txtBookName, "string");
            bool validateLocation = Utilities.ValidateField(txtCopyLocation, "string");
            bool validateId = Utilities.ValidateField(txtMemberId, "int");
            bool validateEdition = Utilities.ValidateField(txtCopyEdition, "int");

            if (!validateName || !validateId || !validateEdition || !validateLocation) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                string bookName = txtBookName.Text;
                string location = txtCopyLocation.Text;
                int memberId = int.Parse(txtMemberId.Text);
                int edition = int.Parse(txtCopyEdition.Text);
                presenter.ReturnBook(bookName, memberId, edition, location);
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
