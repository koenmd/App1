using System;
using System.Collections.Generic;
using System.Text;

using ReactiveUI;
using Xamvvm;
using App1.Models;

namespace App1.ViewModels
{
    public class XamListViewPageModel : BasePageModelRxUI
    {


        public XamListViewPageModel()
        {
            ItemViewModelList = GetDemoItems();
        }

        ReactiveList<Item> itemViewModelList;
        public ReactiveList<Item> ItemViewModelList
        {
            get { return itemViewModelList; }
            set { this.RaiseAndSetIfChanged(ref itemViewModelList, value); }
        }


        private ReactiveList<Item> GetDemoItems()
        {
            ReactiveList<Item> _items = new ReactiveList<Item>();

            _items.Add(new Item() { Name = "Test 1", Price = 2.63 });
            _items.Add(new Item() { Name = "Test 2", Price = 5.12 });
            _items.Add(new Item() { Name = "Test 3", Price = 10.52 });
            _items.Add(new Item() { Name = "Test 4", Price = 1.25 });
            _items.Add(new Item() { Name = "Test 5", Price = 2.85 });
            _items.Add(new Item() { Name = "Test 6", Price = 8.12 });
            _items.Add(new Item() { Name = "Test 7", Price = 3.63 });
            _items.Add(new Item() { Name = "Test 8", Price = 4.25 });
            _items.Add(new Item() { Name = "Test 9", Price = 9.45 });
            _items.Add(new Item() { Name = "Test 10", Price = 7.85 });

            return _items;
        }

}
}