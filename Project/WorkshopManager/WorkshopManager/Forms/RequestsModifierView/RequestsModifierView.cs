using System.Windows.Forms;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public partial class RequestsModifierView : Form, IRequestsModifierView
    {
        public RequestsModifierPresenter Presenter { private get; set; }

        public RequestsModifierView()
        {
            InitializeComponent();
            new RequestsModifierPresenter(this);
        }

        public string OwnerTextBox
        {
            get { return ownerTextBox.Text; }
            set { ownerTextBox.Text = value; }
        }

        public string CarModelTextBox
        {
            get { return carModelTextBox.Text; }
            set { carModelTextBox.Text = value; }
        }

        public string DescriptionTextBox
        {
            get { return descriptionTextBox.Text; }
            set { descriptionTextBox.Text = value; }
        }
    }
}
