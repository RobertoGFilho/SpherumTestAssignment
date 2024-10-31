using SpherumTestAssignment.ViewModels;
namespace SpherumTestAssignment.Views;

public partial class ItemDetailPage : ContentPage
{
    public ItemDetailPage(Models.ItemModel item)
    {
        InitializeComponent();
        BindingContext = new ItemDetailViewModel(item);
    }

}