using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace amir_mostafa.BL
{
    
    class buy_order
    {
        public void insert_buy_order(int id,int id2, DateTime date, string user_name, string total, string order_tybe,string paid,string rem)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@support_id", SqlDbType.Int);
            param[1].Value = id2;
            param[2] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@user_name", SqlDbType.VarChar,50);
            param[3].Value = user_name;
            param[4] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[4].Value = total;
            param[5] = new SqlParameter("@order_type", SqlDbType.VarChar,50);
            param[5].Value = order_tybe;
            param[6] = new SqlParameter("@paid", SqlDbType.NVarChar, 50);
            param[6].Value = paid;
            param[7] = new SqlParameter("@remaind", SqlDbType.NVarChar, 50);
            param[7].Value = rem;
            DAL.open();
            DAL.executenonquery("insert_buy_order_new", param);
            DAL.close();
        }
        public void update_buy_order(int id, int id2, DateTime date, string user_name, string total, string order_tybe, string paid, string rem)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@support_id", SqlDbType.Int);
            param[1].Value = id2;
            param[2] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[3].Value = user_name;
            param[4] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[4].Value = total;
            param[5] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[5].Value = order_tybe;
            param[6] = new SqlParameter("@paid", SqlDbType.NVarChar, 50);
            param[6].Value = paid;
            param[7] = new SqlParameter("@remaind", SqlDbType.NVarChar, 50);
            param[7].Value = rem;
            DAL.open();
            DAL.executenonquery("update_buy_order", param);
            DAL.close();
        }
        public void insert_operations(int id,int support_id,int product_id,
            string product_num,string product_price,DateTime date,string total,string user,string type )
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@support_id", SqlDbType.Int);
            param[1].Value = support_id;
            param[2] = new SqlParameter("@product_id", SqlDbType.Int);
            param[2].Value = product_id;
            param[3] = new SqlParameter("@product_number", SqlDbType.VarChar, 50);
            param[3].Value = product_num;
            param[4] = new SqlParameter("@product_price", SqlDbType.VarChar,50);
            param[4].Value = product_price;
            param[5] = new SqlParameter("@date_operation", SqlDbType.DateTime);
            param[5].Value = date;
            param[6] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[6].Value = total;
            param[7] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[7].Value = user;
            param[8] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[8].Value = user;
            DAL.open();
            DAL.executenonquery("insert_operations", param);
            DAL.close();
        }
        public void update_buy_operations(int id, int support_id, int product_id,
    string product_num, string product_price, DateTime date, string total, string user, string type)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@support_id", SqlDbType.Int);
            param[1].Value = support_id;
            param[2] = new SqlParameter("@product_id", SqlDbType.Int);
            param[2].Value = product_id;
            param[3] = new SqlParameter("@product_number", SqlDbType.VarChar, 50);
            param[3].Value = product_num;
            param[4] = new SqlParameter("@product_price", SqlDbType.VarChar, 50);
            param[4].Value = product_price;
            param[5] = new SqlParameter("@date_order", SqlDbType.DateTime);
            param[5].Value = date;
            param[6] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[6].Value = total;
            param[7] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[7].Value = user;
            param[8] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[8].Value = user;
            DAL.open();
            DAL.executenonquery("update_buy_operations", param);
            DAL.close();
        }
        public DataTable maax_buy_id()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt=DAL.selectdata("max_buy_id", null);
            return dt;
        }

        public void delete_buy_order(int x)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = x;
            DAL.open();
            DAL.executenonquery("delete_buy_order", param);
            DAL.close();
        }

        public DataTable all_buy_orders()

        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_buy_orders", null);
            return dt;
        }

        public DataTable all_remaind_buy_orders()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_remaind_buy_orders", null);
            return dt;
        }
        public DataTable all_supports_buy_order()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_supports_buy_order", null);
            return dt;
        }
        public DataTable all_buy_operations()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("all_buy_operations", null);
            return dt;
        }
        public DataTable select_product_by_id(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("select_product_by_id", param);
            return dt;
        }
        public void delete_buy_operations(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            DAL.open();
           DAL.executenonquery("delete_buy_operations", param);
           DAL.close();

        }
        public DataTable get_buy_order_by_id(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_buy_order_by_id", param);
            return dt;
        }
        public void update_buy(int id,string val)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@buy_price", SqlDbType.NVarChar,50);
            param[1].Value = val;
            DAL.open();
            DAL.executenonquery("update_product_price", param);
            DAL.close();
        }
        public DataTable get_operations_by_order_id(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_operations_by_order_id", param);
            return dt;
        }
        public DataTable searsh_buy__order(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_buy__order", param);
            return dt;
        }

        public DataTable searsh_remaind_buy_order(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_remaind_buy_order", param);
            return dt;
        }
        public DataTable searsh_operations(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_operations", param);
            return dt;
        }
    }
}
