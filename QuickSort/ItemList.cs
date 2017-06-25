using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class ItemList
    {

        private List<int> items;

        public ItemList()
        {
            items = new List<int>();
            InitList();
            
        }

        public void InitList()
        {
            Random random = new Random();
            for(int i = 0; i<random.Next(10, 30);i++)
            {
                items.Add(random.Next(30));
            }
        }

        public List<int> GetItems()
        {
            return items;
        }

        public List<int> GetSortedItems()
        {
            return SortList();
        }

        //we need a pivot, which can be any of the values from the list
        //So we need it's position.
        public List<int> SortList()
        {
            List<int> NewItems = this.items;
            RecursiveSort( 0, items.Count-1, NewItems);
            return NewItems;

        }

        private void RecursiveSort(int left, int right, List<int> items)
        {
            int index = partition(items, left, right);
            if (left < index - 1)
                RecursiveSort(left, index - 1, items);
            if (index < right)
                RecursiveSort(index, right,items);
        }

        private int partition(List<int> items, int left, int right)
        {
            int i = left, j = right;
            int tmp;
            int pivot = items[(left + right) / 2];
            while (i <= j)
            {
                while (items[i] < pivot)
                    i++;
                while (items[j] > pivot)
                    j--;
                if (i <= j)
                {
                    tmp =items[i];
                    items[i] = items[j];
                    items[j] = tmp;
                    i++;
                    j--;
                }
            };
            return i;
        }
    }
}
