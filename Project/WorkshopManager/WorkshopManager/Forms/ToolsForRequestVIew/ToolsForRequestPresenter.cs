namespace WorkshopManager.Forms.ToolsForRequestView
{
    public class ToolsForRequestPresenter
    {
        private IToolsForRequestView _view;

        public ToolsForRequestPresenter(IToolsForRequestView view)
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
