using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Forms.RequestsDatabaseView;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public abstract class RequestsModifierPresenter
    {
        protected IRequestsModifierView _view;

        protected RequestsModifierPresenter(IRequestsModifierView view)
        {
            _view = view;
            _view.Presenter = this;
        }
    }
}
