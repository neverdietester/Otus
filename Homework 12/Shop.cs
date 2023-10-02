using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Homework_12
{
    class Shop
    {
        public ObservableCollection<Item> Items { get; set; }

        public Shop()
        {
            Items = new ObservableCollection<Item>();
            Items.CollectionChanged += Items_CollectionChanged;
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public void Remove(Item item)
        {
            Items.Remove(item);
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var newItem in e.NewItems)
                {
                    DateTime date = DateTime.Now;
                    Console.WriteLine($"Дата:{date} Добавлен товар: {((Item)newItem).Name} (id: {((Item)newItem).Id})");
                }
            }

            if (e.OldItems != null)
            {
                foreach (var oldItem in e.OldItems)
                {
                    Console.WriteLine($"Удален товар: {((Item)oldItem).Name} (id: {((Item)oldItem).Id})");
                }
            }
        }
    }
}
