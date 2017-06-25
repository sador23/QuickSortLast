using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        private ItemList itemList;

        public Form1()
        {
            InitializeComponent();
            itemList = new ItemList();
            FillToSortList();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            sorted.Items.Clear();
            toSort.Items.Clear();
            itemList = new ItemList();
            FillToSortList();
        }


        private void FillToSortList()
        {
            foreach(int num in itemList.GetItems())
            {
                toSort.Items.Add(num);
            }
        }

        private void FillSortedList()
        {
            foreach (int num in itemList.GetSortedItems())
            {
                //filler
                sorted.Items.Add(num);
            }

        }

        private void sort_Click(object sender, EventArgs e)
        {
            FillSortedList();
        }
    }
}
