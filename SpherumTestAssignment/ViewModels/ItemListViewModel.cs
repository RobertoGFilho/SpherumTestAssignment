using SpherumTestAssignment.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace SpherumTestAssignment.ViewModels
{
    public class ItemListViewModel : BaseViewModel
    {
        public ICommand GoToFormPageCommand { get; set; }
        public ObservableCollection<Models.ItemModel> Items { get; set; }
        public ICommand LoadMoreItemsCommand { get; set; }
        public ICommand ItemSelectedCommand { get; set; }
        
        private Models.ItemModel? _lastSelectedItem = null;

        public ItemListViewModel()
        {
            Items = new ObservableCollection<Models.ItemModel>();
            for (int i = 1; i <= 30; i++)
            {
                Items.Add(new Models.ItemModel
                {
                    Name = $"Item {i}",
                    Description = $"Description for Item {i}",
                    CreatedDate = DateTime.Now.AddDays(-i),
                    IsActive = i % 2 == 0,
                    Category = $"Category {i % 3}",
                    Price = i * 10.5m,
                    Quantity = i * 2,
                    Manufacturer = $"Manufacturer {i % 5}",
                    SKU = $"SKU-{i}",
                    Rating = (i % 5) + 1
                });
            }
            LoadMoreItemsCommand = new Command(LoadMoreItems);
            ItemSelectedCommand = new Command<Models.ItemModel>(OnItemSelected);
            GoToFormPageCommand = new Command(async () => await GoToFormPage());
        }

        void LoadMoreItems()
        {
            for (int i = 0; i < 10; i++)
            {
                Items.Add(new Models.ItemModel
                {
                    Name = $"Item {Items.Count + 1}",
                    Description = $"Description for Item {Items.Count + 1}",
                    CreatedDate = DateTime.Now.AddDays(-Items.Count),
                    IsActive = (Items.Count + 1) % 2 == 0,
                    Category = $"Category {(Items.Count + 1) % 3}",
                    Price = (Items.Count + 1) * 10.5m,
                    Quantity = (Items.Count + 1) * 2,
                    Manufacturer = $"Manufacturer {(Items.Count + 1) % 5}",
                    SKU = $"SKU-{Items.Count + 1}",
                    Rating = ((Items.Count + 1) % 5) + 1
                });
            }
        }

        async void OnItemSelected(Models.ItemModel? selectedItem)
        {
            if (selectedItem == null)
                return;

            if (_lastSelectedItem != null)
            {
                _lastSelectedItem.IsSelected = false;
            }

            selectedItem.IsSelected = true;
            _lastSelectedItem = selectedItem;

            if (Application.Current?.MainPage?.Navigation != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new ItemDetailPage(selectedItem));
            }

            selectedItem.IsSelected = false;
        }

        private async Task GoToFormPage()
        {
            await Shell.Current.GoToAsync(nameof(Views.FormPage));
        }
    }
}
