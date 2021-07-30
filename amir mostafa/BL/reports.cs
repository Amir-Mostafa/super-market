using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace amir_mostafa.BL
{
    
    class reports
    {
        DAL.DataAccesLier DAL = new DAL.DataAccesLier();
        public DataTable report_sell(DateTime date1,DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[0].Value = date1;
            param[1] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[1].Value = date2;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("report_sell", param);
            return dt;
        }
        
        public DataTable get_buy_operatoin_in_date(DateTime date1, DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[0].Value = date1;
            param[1] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[1].Value = date2;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_buy_operatoin_in_date", param);
            return dt;
        }
        public DataTable money_repory(DateTime date1, DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[0].Value = date1;
            param[1] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[1].Value = date2;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("money_repory", param);
            return dt;
        }
        public DataTable get_operations_for_clint(int clint_id, DateTime date1, DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = clint_id;
            param[1] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[1].Value = date1;
            param[2] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[2].Value = date2;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_operations_for_clint", param);
            return dt;
        }
        public DataTable get_buy_operatoin_in_date_for_supplay(int clint_id, DateTime date1, DateTime date2)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = clint_id;
            param[1] = new SqlParameter("@date1", SqlDbType.DateTime);
            param[1].Value = date1;
            param[2] = new SqlParameter("@date2", SqlDbType.DateTime);
            param[2].Value = date2;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_buy_operatoin_in_date_for_supplay", param);
            return dt;
        }

        public DataTable all_products_by_id(int clint_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = clint_id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_products_by_id", param);
            return dt;
        }

        public DataTable all_products_by_id_from_borrow(int clint_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = clint_id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_products_by_id_from_borrow", param);
            return dt;
        }

        public DataTable all_products_from_buy_operations(int clint_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = clint_id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_products_from_buy_operations", param);
            return dt;
        }
        public DataTable collect_report(int start, int end)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@start", SqlDbType.Int);
            param[0].Value = start;
            param[1] = new SqlParameter("@end", SqlDbType.Int);
            param[1].Value = end;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("collect_mony", param);
            return dt;
        }
        public DataTable collect_product(int start, int end)
        {
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@start", SqlDbType.Int);
            param[0].Value = start;
            param[1] = new SqlParameter("@end", SqlDbType.Int);
            param[1].Value = end;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("collect_product", param);
            return dt;
        }

        public DataTable calc_money()
        {   
            DataTable dt = new DataTable();
            dt = DAL.selectdata("calc_money", null);
            return dt;
        }

        public DataTable calc_buy()
        {
            DataTable dt = new DataTable();
            dt = DAL.selectdata("calc_buy", null);
            return dt;
        }

    }
}
