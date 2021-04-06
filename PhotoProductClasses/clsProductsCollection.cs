using System;
using System.Collections.Generic;

namespace PhotoProductClasses
{
    public class clsProductsCollection
    {
        List<clsProducts> mProductsList = new List<clsProducts>();
        clsProducts mThisProduct = new clsProducts();
        public List<clsProducts> ProductsList
        {
            get
            {
                return mProductsList;
            }
            set
            {
                mProductsList = value;
            }
        }

        public clsProducts ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }


        public void ReportByProductID(string ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblProducts_FilterByProductID");
            PopulateArray(DB);
        }


        public clsProductsCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProducts_SelectAll");
            PopulateArray(DB);
        }


    


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mProductsList = new List<clsProducts>();
            while (Index < RecordCount)
            {
                clsProducts AnProducts = new clsProducts();
                AnProducts.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnProducts.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AnProducts.ProductDescription = Convert.ToString(DB.DataTable.Rows[Index]["ProductDescription"]);
                AnProducts.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                AnProducts.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);

                mProductsList.Add(AnProducts);
                Index++;

            }
        }
    }

}