using System;

namespace PhotoProductClasses
{
    public class clsProducts
    {
        private Int32 mProductID;
        public int ProductID
        {
            get
            {
                return mProductID;
            }
            set
            {
                mProductID = value;
            }
        }
        private string mProductName;
        public string ProductName
        {
            get
            {
                return mProductName;
            }
            set
            {
                mProductName = value;
            }
        }

        private string mProductDescription;
        public string ProductDescription
        {
            get
            {
                return mProductDescription;
            }
            set
            {
                mProductDescription = value;
            }
        }

        private Int32 mProductQuantity;
        public int ProductQuantity
        {
            get
            {
                return mProductQuantity;
            }
            set
            {
                mProductQuantity = value;
            }
        }

        private decimal mProductPrice;
        public decimal ProductPrice
        {
            get
            {
                return mProductPrice;
            }
            set
            {
                mProductPrice = value;
            }
        }

        private Int32 mProductPoints;
        public int ProductPoints
        {
            get
            {
                return mProductPoints;
            }
            set
            {
                mProductPoints = value;
            }
        }

        public string Valid(string productID, string productName, string productDescription, string productQuantity, string productPrice, string productPoints)
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

            if (productPoints.Length == 0)
            {
                Error = Error + "ProductPoints is blanked|| ";
            }
            return Error;
          }

       
       

        public void Add(clsProducts testItem)
        {
            throw new NotImplementedException();
        }

        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblProducts_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mProductDescription = Convert.ToString(DB.DataTable.Rows[0]["ProductDescription"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                mProductPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["ProductPrice"]);
                mProductPoints = Convert.ToInt32(DB.DataTable.Rows[0]["ProductPoints"]);
                return true;
            }

            else
            {
                return false;
            }
            
        }

        
        
    }
}