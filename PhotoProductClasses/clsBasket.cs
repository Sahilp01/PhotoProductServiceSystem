using System;

namespace PhotoProductClasses
{
    public class clsBasket
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

        private string mName;
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        private Int32 mQuantity;
        public int Quantity 

            {
                get
            {
                    return mQuantity;
                }
                set
            {
                    mQuantity = value;
                }
            }

        private decimal mPrice;
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        //public Byte Image { get; set; }
        private Int32 mPointReceived;
        public int PointsReceived
        {
            get
            {
                return mPointReceived;
            }
            set
            {
                mPointReceived = value;
            }
        }

        public void Add(clsBasket testItem)
        {
            throw new NotImplementedException();
        } 

        public bool Find(int ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblBasket_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mQuantity= Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mPointReceived = Convert.ToInt32(DB.DataTable.Rows[0]["PointsReceived"]);
                
                return true;
            }

            else
            {
                return false;
            }
        }

       
   
        public string Valid(string productID, string name, string quantity, string price, string pointsReceived)
        {
            return "";
        }
    }
}