namespace SpherumTestAssignment.Views;

public partial class ItemListPage : ContentPage
{
	public ItemListPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.ItemListViewModel();
    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Models.ItemModel selectedItem)
        {
            var viewModel = BindingContext as ViewModels.ItemListViewModel;
            viewModel?.ItemSelectedCommand.Execute(selectedItem);
        }
    }
}