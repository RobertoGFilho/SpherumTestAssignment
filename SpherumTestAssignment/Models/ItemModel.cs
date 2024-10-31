namespace SpherumTestAssignment.Models
{
    public class ItemModel : BaseModel
    {
        public required string Name { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public string Category { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0.0m;
        public int Quantity { get; set; } = 0;
        public string Manufacturer { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public double Rating { get; set; } = 0.0;
        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        public string BorderColor => IsSelected ? "LightBlue" : "WhiteSmoke";
    }
}
