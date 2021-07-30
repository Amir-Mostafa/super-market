using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class orders
    {

        public void sp_delete_to_update(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DAL.executenonquery("sp_delete_to_update", param);
            DAL.close();
        }
        public void delete_borrow_product(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DAL.executenonquery("delete_borrow_product", param);
            DAL.close();
        }
        public DataTable sp_get_order_by_id(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_get_order_by_id", param);
            return dt;
        }
        public DataTable sp_get_operations_by_id(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_get_operations_by_id", param);
            return dt;
        }
        public DataTable select(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_name", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_fill_order", param);
            return dt;
        }
        public DataTable sp_delete_borrow(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_delete_borrow", param);
            return dt;
        }
        public DataTable sp_get_porrow_products(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@clint_id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_get_porrow_products", param);
            return dt;
        }
        public DataTable select_supp()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_upports_mony", null);
            return dt;
        }
        public DataTable sp_all_operations()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_all_operations", null);
            return dt;
        }
        public void update_sup_money(string basee,string add,string tax)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@base", SqlDbType.VarChar, 50);
            param[0].Value = basee;
            param[1] = new SqlParameter("@add", SqlDbType.VarChar, 50);
            param[1].Value = add;
            param[2] = new SqlParameter("@tax", SqlDbType.VarChar, 50);
            param[2].Value = tax;
            DAL.open();
            DAL.executenonquery("sp_update_supp_mony", param);
            DAL.close();
        }
        public void sp_insert_borrow_product(int id, string @taken, string @total, string @explaint, DateTime @date_operation)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@taken", SqlDbType.VarChar, 50);
            param[1].Value = @taken;
            param[2] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[2].Value = @total;
            param[3] = new SqlParameter("@explaint", SqlDbType.VarChar, 50);
            param[3].Value = @explaint;
            param[4] = new SqlParameter("@date_operation", SqlDbType.DateTime);
            param[4].Value = @date_operation;
            DAL.open();
            DAL.executenonquery("sp_insert_borrow_product", param);
            DAL.close();
        }

        public void insert_borrow(int clint_id,int product_id,string num,string total,string name,DateTime date,string price)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = clint_id;
            param[1] = new SqlParameter("@product_id", SqlDbType.Int);
            param[1].Value = product_id;
            param[2] = new SqlParameter("@product_number", SqlDbType.VarChar, 50);
            param[2].Value = num;
            param[3] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[3].Value = total;
            param[4] = new SqlParameter("@taken_name", SqlDbType.VarChar,50);
            param[4].Value = name;
            param[5] = new SqlParameter("@date_operation", SqlDbType.DateTime);
            param[5].Value = date;
            param[6] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[6].Value = price;
            DAL.open();
            DAL.executenonquery("insert_borrow", param);
            DAL.close();
        }
        public void insert_money(int clint_id, int order_id, string mony, DateTime date)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = clint_id;
            param[1] = new SqlParameter("@order_id", SqlDbType.Int);
            param[1].Value = order_id;
            param[2] = new SqlParameter("@monet", SqlDbType.NVarChar, 50);
            param[2].Value = mony;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            DAL.open();
            DAL.executenonquery("insert_money", param);
            DAL.close();
        }
        public DataTable select_one_product(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_name", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_select_one_product", param);
            return dt;
        }
        public DataTable sp_select_one_product_by_barcode(decimal id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@barcod", SqlDbType.Decimal);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_select_one_product_by_barcode", param);
            return dt;
        }
        public DataTable get_borrow_peoduct(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_borrow_peoduct", param);
            return dt;
        }
        public DataTable sp_get_products_name()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_get_products_name", null);
            return dt;
        }
        public DataTable max_id()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_max_id", null);
            return dt;
        }
        public DataTable searsh_order(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_order", param);
            return dt;
        }
        public DataTable searsh_in_operations(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_in_operations", param);
            return dt;
        }
        public DataTable sp_searsh_borrow_product(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@clint_name", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_searsh_borrow_product", param);
            return dt;
        }
        public DataTable select_all_orders()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_sll_orders", null);
            return dt;
        }
        public DataTable remaind_sell_orders()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("remaind_sell_orders", null);
            return dt;
        }
        public DataTable searsh_remaind_sell_order(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_remaind_sell_order", param);
            return dt;
        }
        public DataTable sp_all_borrow()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_all_borrow", null);
            return dt;
        }
        public void insert_order(int id, DateTime date, int clint_id, string total, int sons_number, int cards_number,string points,string support,string user_name,string remaind_support,string require_mony,
            string add_support,string base_support,string tax_card,string weight)

        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@order_date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[2].Value = clint_id;
            param[3] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[3].Value = total;
            param[4] = new SqlParameter("@sons_number", SqlDbType.Int);
            param[4].Value = sons_number;
            param[5] = new SqlParameter("@cards_number", SqlDbType.Int);
            param[5].Value = cards_number;
            param[6] = new SqlParameter("@points_bread", SqlDbType.VarChar, 50);
            param[6].Value = points;
            param[7] = new SqlParameter("@support", SqlDbType.VarChar, 50);
            param[7].Value = support;
            param[8] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[8].Value = user_name;
            param[9] = new SqlParameter("@remaind_support", SqlDbType.VarChar, 50);
            param[9].Value = remaind_support;
            param[10] = new SqlParameter("@require_money", SqlDbType.VarChar, 50);
            param[10].Value = require_mony;
            param[11] = new SqlParameter("@add_support", SqlDbType.VarChar, 50);
            param[11].Value = add_support;
            param[12] = new SqlParameter("@base_support", SqlDbType.VarChar, 50);
            param[12].Value = base_support;
            param[13] = new SqlParameter("@tax_cars", SqlDbType.VarChar, 50);
            param[13].Value = tax_card;
            param[14] = new SqlParameter("@weight", SqlDbType.VarChar, 50);
            param[14].Value = weight;
            DAL.open();
            DAL.executenonquery("sp_insert_order", param);
            DAL.close();
        }
        public void sp_update_order(int id, DateTime date, int clint_id, string total, int sons_number, int cards_number, string points, string support, string user_name, string remaind_support, string require_mony,
    string add_support, string base_support, string tax_card ,string weight )
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[15];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@order_date", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[2].Value = clint_id;
            param[3] = new SqlParameter("@total", SqlDbType.VarChar, 50);
            param[3].Value = total;
            param[4] = new SqlParameter("@sons_number", SqlDbType.Int);
            param[4].Value = sons_number;
            param[5] = new SqlParameter("@cards_number", SqlDbType.Int);
            param[5].Value = cards_number;
            param[6] = new SqlParameter("@points_bread", SqlDbType.VarChar, 50);
            param[6].Value = points;
            param[7] = new SqlParameter("@support", SqlDbType.VarChar, 50);
            param[7].Value = support;
            param[8] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[8].Value = user_name;
            param[9] = new SqlParameter("@remaind_support", SqlDbType.VarChar, 50);
            param[9].Value = remaind_support;
            param[10] = new SqlParameter("@require_money", SqlDbType.VarChar, 50);
            param[10].Value = require_mony;
            param[11] = new SqlParameter("@add_support", SqlDbType.VarChar, 50);
            param[11].Value = add_support;
            param[12] = new SqlParameter("@base_support", SqlDbType.VarChar, 50);
            param[12].Value = base_support;
            param[13] = new SqlParameter("@tax_cars", SqlDbType.VarChar, 50);
            param[13].Value = tax_card;
            param[14] = new SqlParameter("@weight", SqlDbType.VarChar, 50);
            param[14].Value = weight;
            DAL.open();
            DAL.executenonquery("sp_update_order", param);
            DAL.close();
        }
        public void insert_operation(int @order_id, int @clint_id, int @product_id, string @product_number, string @product_price,
            string @total, string @profit, DateTime @date_operation, string user_name, string @parcode,string notes,float weight)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = @order_id;
            param[1] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[1].Value = @clint_id;
            param[2] = new SqlParameter("@product_id", SqlDbType.Int);
            param[2].Value = @product_id;
            param[3] = new SqlParameter("@product_number", SqlDbType.VarChar,50);
            param[3].Value = @product_number;
            param[4] = new SqlParameter("@product_price", SqlDbType.VarChar,50);
            param[4].Value = @product_price;
            param[5] = new SqlParameter("@total", SqlDbType.VarChar,50);
            param[5].Value = @total;
            param[6] = new SqlParameter("@profit", SqlDbType.VarChar, 50);
            param[6].Value = @profit;
            param[7] = new SqlParameter("@date_operation", SqlDbType.DateTime);
            param[7].Value = @date_operation;
            param[8] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[8].Value = user_name;
            param[9] = new SqlParameter("@parcode", SqlDbType.VarChar, 50);
            param[9].Value = @parcode;
            param[10] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[10].Value =notes;
            param[11] = new SqlParameter("@weight", SqlDbType.Float);
            param[11].Value = weight;
            DAL.open();
            DAL.executenonquery("sp_insert_all_operations", param);
            DAL.close();
        }
        public DataTable slect_product(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@product_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_get_profit", param);
            return dt;
        }
        public DataTable sp_delete_order(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_delete_order", param);
            return dt;
        }
        public DataTable select_product_id(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("select_product_id", param);
            return dt;
        }
        public DataTable get_id_bu_name(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ame", SqlDbType.VarChar,50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_id_bu_name", param);
            return dt;
        }
        public DataTable get_details_for_print(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_details_for_print", param);
            return dt;
        }
        public DataTable calc_weight(int from,int to)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@from", SqlDbType.Int);
            param[0].Value = from;
            param[1] = new SqlParameter("@to", SqlDbType.Int);
            param[1].Value = to;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("calc_weight", param);
            return dt;
        }

    }
}
