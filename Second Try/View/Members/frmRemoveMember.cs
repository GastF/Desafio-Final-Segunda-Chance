using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenter.Members;
using System.Xml.Linq;

namespace View.Members
{
    public partial class frmRemoveMember : Form,IRemoveMemberView
    {
        private readonly PresenterRemoveMember presenter;
        public frmRemoveMember(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterRemoveMember(library,this);
        }



        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            bool validateId = Utilities.ValidateField(txtId, "int");


            if (!validateId) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                int id = int.Parse(txtId.Text);

                presenter.RemoveMemberFromLibrary(id);

                txtId.Text = "";
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

        private void frmRemoveMember_Load(object sender, EventArgs e)
        {

        }
    }
}
