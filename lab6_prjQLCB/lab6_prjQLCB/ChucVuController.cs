using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace lab6_prjQLCB
{
    class ChucVuController
    {
        public List<ChucVuModel.ChucVu> GetChucVu()
        {
            List<ChucVuModel.ChucVu> listChucVu = new List<ChucVuModel.ChucVu>();

            try
            {
                if (!Database.OpenConnection())
                    throw new Exception("Error: Unable to open database connection");

                string query = "SELECT MaCV, TenCV FROM ChucVu";
                SqlCommand command = new SqlCommand(query, Database.con);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ChucVuModel.ChucVu chucVu = new ChucVuModel.ChucVu();
                    chucVu._maCV = reader.GetInt32(0);
                    chucVu._tenCV = reader.GetString(1);
                    listChucVu.Add(chucVu);
                }
                Database.CloseConnection();
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return listChucVu;
        }
    }
}
