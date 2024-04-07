using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Database
{
    public static SqlConnection con;

    public static bool OpenConnection()
    {
        try
        {
            con = new SqlConnection("Server=MEE\\MYB2014996;database=QLCB;uid=mylogin;pwd=mylogin");
            con.Open();
        }
        catch (Exception)
        {
            return false;
        }
        return true;
    }

    public static bool CloseConnection()
    {
        try
        {
            con.Close();
        }
        catch(Exception) {
            return false;
        }
        return true;
    }
}