﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Diary_Version_2
{
    class UserDataAccess
    {
        DataAccess dataAccess;
        public UserDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM UserInfo WHERE [User Name]='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = dataAccess.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
        /*public int InsertCategory(User user)
        {
            string sql = "INSERT INTO Categories(CategoryName) VALUES('" + user.CategoryName + "')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }*/
    }
}
