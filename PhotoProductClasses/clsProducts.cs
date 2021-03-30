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
            String Error = "";
            if (productID.Length == 0)
            {
                Error = Error + "ProductID is blanked|| ";
            }

            if (productName.Length == 0)
            {
                Error = Error + "ProductName is blanked|| ";
            }

            if (productDescription.Length == 0)
            {
                Error = Error + "ProductDescription is blanked|| ";
            }

            if (productQuantity.Length == 0)
            {
                Error = Error + "ProductQuantity is blanked|| ";
            }

            if (productPrice.Length == 0)
            {
                Error = Error + "ProductPrice is blanked|| ";
            }
            return Error;
        }

        public void Find(int productID)
        {
            throw new NotImplementedException();
        }

        public void Add(clsProducts testItem)
        {
            throw new NotImplementedException();
        }
    }
}