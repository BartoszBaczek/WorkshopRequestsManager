using System.Collections.Generic;
using System.Linq;
using WorkshopManager.DatabasePresenter;

namespace WorkshopManager.Forms.ToolsForRequestView
{
    public class ToolsForRequestPresenter
    {
        private IToolsForRequestView _view;
        private IPartsDatabaseAdapter _dataBase;

        public ToolsForRequestPresenter(IToolsForRequestView view)
        {
            _view = view;
            _view.Presenter = this;

            _dataBase = new DatabasePresenter.DatabasePresenter();
            Init();
        }

        private void Init()
        {
            LoadAllToolsListBox();
        }

        private void LoadAllToolsListBox()
        {
            List<Part> allParts = _dataBase.GetAll();
            List<string> partsNames = allParts.Select(part => part.Name).ToList();
            _view.AllToolsListBox = partsNames;
        }
    }
}
