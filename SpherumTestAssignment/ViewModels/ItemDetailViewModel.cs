using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpherumTestAssignment.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Models.ItemModel Item { get; set; }
        public ItemDetailViewModel(Models.ItemModel item)
        {
            Item = item;
        }
    }
}
