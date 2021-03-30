using System;
using System.Collections.Generic;

namespace PhotoProductClasses
{
    public class clsProductsCollection
    {
        List<clsProducts> mProductsList = new List<clsProducts>();
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

        public clsProducts ThisProduct { get; set; }

        public clsProductsCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblProducts_SelectAll");

            RecordCount = DB.Count;
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