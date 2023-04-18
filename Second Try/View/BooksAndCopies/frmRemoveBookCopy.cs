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
    public partial class frmRemoveBookCopy : Form, IRemoveBookCopyView
    {
        private readonly PresenterRemoveBookCopy presenter;
        public frmRemoveBookCopy(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterRemoveBookCopy(library, this);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            
            bool validateName = Utilities.ValidateField(txtName, "string");


            if (!validateName) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                string name = txtName.Text;
                presenter.RemoveBookFromLibrary(name);

                txtName.Text = "";
            }
        }
      
        

        private void btnRemoveCopy_Click(object sender, EventArgs e)
        {

            bool validateName = Utilities.ValidateField(txtName, "string");
            bool validateEdition = Utilities.ValidateField(txtCopyEdition, "int");

            if (!validateName || !validateEdition) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                string name = txtBookCopy.Text;
                int edition = int.Parse(txtCopyEdition.Text);
                presenter.RemoveCopy(name, edition);

                txtBookCopy.Text = "";
                txtCopyEdition.Text = "";
            }        
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
