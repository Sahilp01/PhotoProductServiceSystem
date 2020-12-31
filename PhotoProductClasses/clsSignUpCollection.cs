using System;
using System.Collections.Generic;

namespace PhotoProductClasses
{
    public class clsSignUpCollection
    {
        List<clsSignUp> mSignUpList = new List<clsSignUp>();
        clsSignUp mThisSignUp = new clsSignUp();

        public List<clsSignUp> SignUpList
        {
            get
            {
                return mSignUpList;
            }
            set
            {
                mSignUpList = value;
            }
        }

        public clsSignUp ThisSignUp
        {
            get
            {
                return mThisSignUp;
            }
            set
            {
                mThisSignUp = value;
            }
        }



        public int Add()
        {
            mThisSignUp.CustomerID = 12;
            return mThisSignUp.CustomerID;

           
        
           /* clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", mThisSignUp.FirstName);
            DB.AddParameter("@LastName", mThisSignUp.LastName);
            DB.AddParameter("@EmailAddress", mThisSignUp.EmailAddress);
            DB.AddParameter("@Password", mThisSignUp.Password);
            DB.AddParameter("@Address", mThisSignUp.Address);
            DB.AddParameter("@PostCode", mThisSignUp.PostCode);
            return DB.Execute("sproc_tblSignUp_Insert");*/
        }
        

        /* public clsSignUpCollection()
         {
             Int32 Index = 0;
             Int32 RecordCount = 0;
             clsDataConnection DB = new clsDataConnection();
             DB.Execute("sproc_tblSignUp_SelectAll");
             RecordCount = DB.Count;
             while (Index < RecordCount)
             {
                 clsSignUp AnSignUp = new clsSignUp();
                 AnSignUp.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                 AnSignUp.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                 AnSignUp.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                 AnSignUp.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                 AnSignUp.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                 AnSignUp.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                 mSignUpList.Add(AnSignUp);
                 Index++;

             }*/

        }
    }