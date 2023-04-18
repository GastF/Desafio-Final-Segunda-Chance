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
    public partial class frmListMembers : Form,IMemberListView
    {
        private readonly PresenterMemberList presenter;
        public frmListMembers(ILibrary library)
        {
            InitializeComponent();
            presenter = new PresenterMemberList(library, this);
            presenter.ShowMemberList();
        }

        public void ShowMemberList(string memberList)
        {
            txtList.Text = memberList;
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            presenter.ShowMemberList();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
