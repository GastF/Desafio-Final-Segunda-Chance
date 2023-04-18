using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Members
{
    public class PresenterMemberList
    {
        private readonly ILibrary library;
        private readonly IMemberListView view;

        public PresenterMemberList(ILibrary library, IMemberListView view)
        {
            this.library = library;
            this.view = view;

        }
        public void ShowMemberList()
        {
            var members = library.GetMember();
            string memberList = library.ListMembers();
            view.ShowMemberList(memberList);
        }
    }
}
