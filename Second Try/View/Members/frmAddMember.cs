using Domain;
using Presenter.Members;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Members
{
    public partial class frmAddMember : Form,IAddMemberView
    {
        private readonly PresenterAddMember presenter;
        public frmAddMember(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterAddMember(library,this);
            txtMonthlyFee.Text = "0";
            txtMonthlyFee.Enabled= false;

        }

       
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            bool validateName = Utilities.ValidateField(txtName, "string");
            bool validateLastName = Utilities.ValidateField(txtLastName, "string");
            bool validateId = Utilities.ValidateField(txtId, "int");
            bool validateMonthlyFee = Utilities.ValidateField(txtMonthlyFee, "decimal");

            if (!validateName || !validateId || !validateMonthlyFee || !validateLastName) { MessageBox.Show("Alguno de los parametros ingresados es erroneo"); return; }
            else
            {
                string name = txtName.Text;
                string lastName = txtLastName.Text;
                int id = int.Parse(txtId.Text);
                decimal monthlyFee = decimal.Parse(txtMonthlyFee.Text);

                if (btnVip.Checked && monthlyFee == 0) { ShowMessage("Un miembro VIP necesita una cuota mayor a 0"); return; }
                presenter.AddMemberToLibrary(name, lastName, id, monthlyFee);

                txtName.Text = "";
                txtLastName.Text = "";
                txtId.Text = "";
                txtMonthlyFee.Text = "0";
            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
        private void btnVip_CheckedChanged(object sender, EventArgs e)
        {
            if(btnVip.Checked)
            {
                txtMonthlyFee.Enabled = true;
               
            }
            else { txtMonthlyFee.Enabled=false; txtMonthlyFee.Text = "0"; }
        }

        private void btnStandart_CheckedChanged(object sender, EventArgs e)
        {

            if (btnStandart.Checked)
            {
                txtMonthlyFee.Enabled = false;
                txtMonthlyFee.Text = "0";
            }
            else { txtMonthlyFee.Enabled = true; }
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
