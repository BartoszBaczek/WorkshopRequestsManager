﻿using System.Windows.Forms;
using WorkshopManager.Forms.RequestsDatabaseView;

namespace WorkshopManager.Forms.RequestsModifierView
{
    public partial class RequestsModifierView : Form, IRequestsModifierView
    {
        public RequestsModifierPresenter Presenter { private get; set; }
        public RequestsCategory RequestCategory { get; private set; }


        public RequestsModifierView(RequestsCategory requestCategory)
        {
            RequestCategory = requestCategory;
            InitializeComponent();
            Presenter = new RequestAdderPresenter(this);
        }

        //jako argument bedzie struktura posiadajaca informacje o request
        public RequestsModifierView(object requestToModify)
        {
            InitializeComponent();
            Presenter = new RequestEditorPresenter(this, requestToModify);
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

        public string CarMarkTextBox
        {
            get { return carMarkTextBox.Text; }
            set { carMarkTextBox.Text = value; }
        }

        public string DescriptionTextBox
        {
            get { return descriptionTextBox.Text; }
            set { descriptionTextBox.Text = value; }
        }

        public void CloseForm()
        {
            Close();
        }

        private void acceptButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnAddRequesButtonClicked();
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnCancelButtonClicked();
        }

        private void toolsForRequestButton_Click(object sender, System.EventArgs e)
        {
            Presenter.OnToolsForRequestButtonClicked();
        }
    }
}
