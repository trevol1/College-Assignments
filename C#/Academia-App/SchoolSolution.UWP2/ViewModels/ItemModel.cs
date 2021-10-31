using Registracio.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registracio.UWP.DataAccess;
using System.Diagnostics;

namespace Registracio.UWP.ViewModels
{
    public class ItemModel
    {
        public ObservableCollection<Items> Items { get; set; } = new ObservableCollection<Items>();
        private DataAccess.EmpDataAccess itemDataAccess = new DataAccess.EmpDataAccess();

       internal async Task LoadItemsAsync()
        {
            var items = await itemDataAccess.GetItemsAsync();

            foreach (Items item in items)
            {
                Items.Add(item);
                Debug.WriteLine(item);
            }
        }
    }
}

