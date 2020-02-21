using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BestGame_Classes
{
    public class clsOrder
    {

        private int mOrder_ID;
        private DateTime mDateAdded;
        private bool mStatus;
        private string mInfo;


        public bool o_status
        {
            get
            {
                return mStatus;
            }

            set
            {
                mStatus = value;
            }
        }


        public DateTime o_date
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }


        public int o_id
        {
            get
            {
                return mOrder_ID;
            }
            set
            {
                mOrder_ID = value;
            }
        }


        public string o_information
        {
            get
            {
                return mInfo;
            }

            set
            {
                mInfo = value;
            }
        }

        public bool Find(int o_id)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@o_id", o_id);

            DB.Execute("sproc_tblOrder_FilterByOrderNo");

            if (DB.Count == 1)
            {
                mOrder_ID = Convert.ToInt32(DB.DataTable.Rows[0]["o_id"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["o_date"]);
                mStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["o_status"]);
                mInfo = Convert.ToString(DB.DataTable.Rows[0]["o_information"]);

                return true;
            }

            else
            {
                return false;
            }

            //mInfo = "as";
            //mOrder_ID = 21;
            //mDateAdded = Convert.ToDateTime("16/09/2019");
            //mStatus = true;
            //return true;

        }


        public void Delete(Int32 o_id)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@o_id", o_id);
            DB.Execute("sproc_tblOrder_Delete");
        }


    }
}