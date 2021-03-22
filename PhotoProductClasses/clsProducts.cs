using System;

namespace PhotoProductClasses
{
    public class clsProducts
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public decimal ProductPrice { get; set; }

        public string Valid(string productID, string productName, string productDescription, string productQuantity, string productPrice)
        {
            return "";
        }
    }
}