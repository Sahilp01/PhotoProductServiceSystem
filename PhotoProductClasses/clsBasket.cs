﻿using System;

namespace PhotoProductClasses
{
    public class clsBasket
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Byte Image { get; set; }
        public int PointsReceived { get; set; }

        public void Add(clsBasket testItem)
        {
            throw new NotImplementedException();
        } 

        public bool Find(int ProductID)
        {
            return true;
        }

       
   
        public string Valid(string productID, string name, string quantity, string price, string pointsReceived)
        {
            return "";
        }
    }
}