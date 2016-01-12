using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.Forms.RequestsDatabaseView;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public class RequestsModifierPresenter
    {
        private IRequestsModifierView _view;

        public RequestsModifierPresenter(IRequestsModifierView view)
        {
            _view = view;
            _view.Presenter = this;

            Init();
        }

        private void Init()
        {
            
        }
    }
}
