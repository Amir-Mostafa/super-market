using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class products

    {

        public void update(int id,string name, decimal parcode, string buy, string sell, string profit, string notes,float weight)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@product_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@product_name", SqlDbType.VarChar, 50);
            param[1].Value = name;
            param[2] = new SqlParameter("@parcode", SqlDbType.Decimal);
            param[2].Value = parcode;
            param[3] = new SqlParameter("@buy_price", SqlDbType.VarChar, 50);
            param[3].Value = buy;
            param[4] = new SqlParameter("@sell_price", SqlDbType.VarChar, 50);
            param[4].Value = sell;
            param[5] = new SqlParameter("@profit", SqlDbType.VarChar, 50);
            param[5].Value = profit;
            param[6] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[6].Value = notes;
            param[7] = new SqlParameter("@weight", SqlDbType.Float);
            param[7].Value = weight;
            DAL.open();
            DAL.executenonquery("sp_update_product", param);
            DAL.close();
        }
        public void insert(string name, string parcode, string buy, string sell, string profit, string notes,double weight)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@procuct_name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@parcode", SqlDbType.VarChar,50);
            param[1].Value = parcode;
            param[2] = new SqlParameter("@buy_price", SqlDbType.VarChar, 50);
            param[2].Value = buy;
            param[3] = new SqlParameter("@sell_price", SqlDbType.VarChar, 50);
            param[3].Value = sell;
            param[4] = new SqlParameter("@profit", SqlDbType.VarChar, 50);
            param[4].Value = profit;
            param[5] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[5].Value = notes;
            param[6] = new SqlParameter("@weight", SqlDbType.Float);
            param[6].Value = weight;
            DAL.open();
            DAL.executenonquery("sp_insert_product", param);
            DAL.close();
        }
        public DataTable all_products()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            return DAL.selectdata("sp_all_products", null);
        }
        public DataTable get_parcode()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            return DAL.selectdata("get_parcode", null);
        }
        public DataTable searsh_products(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_searsh_products", param);
            return dt;
        }
        public DataTable all_product_by_barcode(decimal id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@bar", SqlDbType.Decimal);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_product_by_barcode", param);
            return dt;
        }

        public DataTable insert_barcode(decimal id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@b", SqlDbType.Decimal);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("insert_barcode", param);
            return dt;
        }
        public void delete(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DAL.executenonquery("sp_delete_product", param);
            DAL.close();
        }
        public void delete_shokak(DateTime start,DateTime end,int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@date_start", SqlDbType.DateTime);
            param[0].Value = start;
            param[1] = new SqlParameter("@date_end", SqlDbType.DateTime);
            param[1].Value = end;
            param[2] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[2].Value = id;
            DAL.open();
            DAL.executenonquery("delete_shokak", param);
            DAL.close();
        }

        public DataTable shokak_with_date(DateTime start, DateTime end, int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@date_start", SqlDbType.DateTime);
            param[0].Value = start;
            param[1] = new SqlParameter("@date_end", SqlDbType.DateTime);
            param[1].Value = end;
            param[2] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[2].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("shokak_with_date", param);
            return dt;
        }
    }
}
