using Domain;
using Presenter.BooksAndCopies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Members
{
    public class PresenterAddMember
    {
        private readonly ILibrary library;
        private readonly IAddMemberView view;

        public PresenterAddMember(ILibrary library, IAddMemberView view)
        {
            this.library = library;
            this.view = view;

        }
        public void AddMemberToLibrary(string name, string lastName, int id, decimal monthlyInstallment = 0)
        {
            try
            {
                    
                foreach (Member member in library.GetMember())
                {
                    if (member.Id == id)
                    {
                        view.ShowMessage("No puede agregarse un miembro con el mismo ID que otro miembro");
                        return;
                    }
                }
                library.AddMember(name, lastName, id, monthlyInstallment);
                view.ShowMessage("El Miembro fue agregado con exito!");
            }
            catch 
            {
                view.ShowMessage("No pudo agregarse al miembro.");
            }
        }
        
    }
}
