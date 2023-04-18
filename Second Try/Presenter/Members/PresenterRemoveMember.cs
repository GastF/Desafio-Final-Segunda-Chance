using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Members
{
    public class PresenterRemoveMember
    {
        private readonly ILibrary library;
        private readonly IRemoveMemberView view;

        public PresenterRemoveMember(ILibrary library, IRemoveMemberView view)
        {
            this.library = library;
            this.view = view;

        }
        public void RemoveMemberFromLibrary(int id)
        {
            try
            {
                Member member = library.SearchMemberById(id);
                if (member != null)
                {

                    library.RemoveMember(id);
                    view.ShowMessage("El Miembro fue removido con exito.");
                }
                else { view.ShowMessage("No se encotro al miembro dentro de la biblioteca"); }

            }
            catch (Exception ex)
            {
                view.ShowMessage("No se pudo remover al miembro.");
            }
        }
    }
}
