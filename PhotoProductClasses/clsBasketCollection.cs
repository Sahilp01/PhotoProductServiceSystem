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
    }
}