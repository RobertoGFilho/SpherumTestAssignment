using SpherumTestAssignment.ViewModels;

namespace SpherumTestAssignment.Views;

public partial class FormPage : ContentPage
{
	public FormPage()
	{
		InitializeComponent();
        BindingContext = new FormViewModel();
    }
}