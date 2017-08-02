using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGeminiTechTest
{
    class BasketItem
    {
        public string ItemName { get; private set; }
        public double ItemPrice { get; set; }
        public string Description { get; private set; }

        public BasketItem(string itemName)
        {
            this.ItemName = itemName;
            this.ItemPrice = GetDefaultPrice();
            this.Description = this.ItemName;
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
    }
}
