using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Item : ReactiveObject
    {

        public Item()
        {

        }

        private string _Name = "";
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _Name, value);
            }
        }

        private double _Price = 0.0;
        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _Price, value);
                
            }
        }


    }
}
