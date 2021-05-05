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

        public int Count
        {
            get
            {
                return mProductsList.Count;
            }
            set
            {

            }
        
        }

        public void ReportByProductID(string ProductID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductID", ProductID);
            DB.Execute("sproc_tblProducts_FilterByProductID");
            PopulateArray(DB);
        }

        /*clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblProducts_FilterByProductName");
            PopulateArray(DB);*/


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
                AnProducts.ProductPoints = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductPoints"]);

                mProductsList.Add(AnProducts);
                Index++;

            }
        }

        public void ReportByProductName(string ProductName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ProductName", ProductName);
            DB.Execute("sproc_tblProducts_FilterByProductName");
            PopulateArray(DB);
        }
    }

}