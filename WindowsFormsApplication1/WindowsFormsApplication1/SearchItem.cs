﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class SearchItem
    {
        String itemName;
        String itemDescription;
        String itemPrice;
        String imageLocation;

        /// <summary>
        /// Search Item Object
        /// </summary>
        public SearchItem()
        {
            ItemName = "";
            ItemDesc = "";
            itemPrice = "0.00";
            ImageLocation = "";
        }

        /// <summary>
        /// Search Item Object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="image"></param>
        public SearchItem(String name, String description, String price, String image)
        {
            ItemName = name;
            ItemDesc = description;
            itemPrice = price;
            ImageLocation = image;
        }

        public String ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                itemName = value;
            }
        }

        public Decimal ItemPrice
        {
            get
            {
                return Convert.ToDecimal(itemPrice);
            }
            set
            {
                itemPrice = value.ToString();
            }
        }

        public String ItemDesc
        {
            get
            {
                return itemDescription;
            }
            set
            {
                itemDescription = value;
            }
        }

        public String ImageLocation
        {
            get
            {
                return imageLocation;
            }
            set
            {
                imageLocation = value;
            }
        }
    }
}
