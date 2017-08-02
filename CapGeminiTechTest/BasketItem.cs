using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGeminiTechTest
{
    class BasketItem
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public BasketItem(string itemName)
        {
            this.ItemName = itemName;
            this.ItemPrice = GetDefaultPrice();
        }

        private double GetDefaultPrice()
        {
            double price = 0;

            switch (this.ItemName)
            {
                case "Apple":
                    price = 0.60;
                    break;

                case "Orange":
                    price = 0.25;
                    break;
            }

            return price;
        }

        public string Description
        {
            get
            {
                return string.Format("{0}  ({1})", this.ItemName, this.ItemPrice.ToString("F"));
            }
        }
    }
}
