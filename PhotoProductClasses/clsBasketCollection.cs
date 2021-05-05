using System;
using System.Collections.Generic;

namespace PhotoProductClasses
{
    public class clsBasketCollection
    {
        List<clsBasket> mBasketList = new List<clsBasket>();
        clsBasket mThisBasket = new clsBasket();
        public List<clsBasket> BasketList
        {
            get
            {
                return mBasketList;
            }
            set
            {
                mBasketList = value;
            }
        }
        public int Count
        {
            get
            {
                return mBasketList.Count;
            }
            set
            {

            }
        }
        public clsBasket ThisBasket
        {
            get
            {
                return mThisBasket;
            }
            set
            {
                mThisBasket = value;
            }
        }
             
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisBasket.ProductID);
            DB.AddParameter("@Name", mThisBasket.Name);
            DB.AddParameter("@Quantity", mThisBasket.Quantity);
            DB.AddParameter("@Price", mThisBasket.Quantity * mThisBasket.Price);
            DB.AddParameter("@PointsReceived", mThisBasket.PointsReceived * mThisBasket.Quantity);

            return DB.Execute("sproc_tblBasket_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", mThisBasket.ProductID);
            DB.Execute("sproc_tblBasket_Delete");
        }

        public clsBasketCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblBasket_SelectAll");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mBasketList = new List<clsBasket>();
            while (Index < RecordCount)
            {
                clsBasket AnBasket = new clsBasket();
                AnBasket.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnBasket.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnBasket.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnBasket.Price = Convert.ToDecimal(DB.DataTable.Rows[Index]["Price"]);
                AnBasket.PointsReceived = Convert.ToInt32(DB.DataTable.Rows[Index]["PointsReceived"]);


                mBasketList.Add(AnBasket);
                Index++;

            }
        }


    
    }
}
