using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpherumTestAssignment.ViewModels
{
    public class FormViewModel : BaseViewModel
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0.0m;
        public int Quantity { get; set; } = 0;
        public string Manufacturer { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public double Rating { get; set; } = 0.0;
        public ICommand SendCommand { get; set; }

        public FormViewModel()
        {
            SendCommand = new Command(async () => await SendData());
        }

        async Task SendData()
        {
            await Application.Current.MainPage.DisplayAlert("Sending", "Data is being sent...", "OK");
            await Shell.Current.GoToAsync("..");
        }
    }

}
