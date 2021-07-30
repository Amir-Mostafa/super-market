using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class shok_clints
    {
        DAL.DataAccesLier DAL = new DAL.DataAccesLier();

        public void new_clint(string name)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@clint_name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            DAL.open();
            DAL.executenonquery("insert_shok_clint", param);
            DAL.close();
        }
        public void delete_shok_operation(int name)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = name;
            DAL.open();
            DAL.executenonquery("delete_shok_operation", param);
            DAL.close();
        }
        public DataTable show_operations_sho(int id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = id;
            return DAL.selectdata("show_operations_sho", param);
        }
        public DataTable all_clints()
        {
            return DAL.selectdata("get_all_clint_sho", null);
        }
        public void insert_sho_operaton(int id,DateTime date,string take ,string give,string notes,int order_id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@date_operation", SqlDbType.DateTime);
            param[1].Value = date;
            param[2] = new SqlParameter("@take", SqlDbType.VarChar,50);
            param[2].Value = take;
            param[3] = new SqlParameter("@give", SqlDbType.VarChar, 50);
            param[3].Value = give;
            param[4] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[4].Value = notes;
            param[5] = new SqlParameter("@order_id", SqlDbType.Int);
            param[5].Value = order_id;
            DAL.open();
            DAL.executenonquery("insert_sho_operaton", param);
            DAL.close();
        }

        public void upadte_sho_operaton(int id,int clint_id, DateTime date, string take, string give, string notes)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@clint_id", SqlDbType.Int);
            param[1].Value = clint_id;
            param[2] = new SqlParameter("@date_operation", SqlDbType.DateTime);
            param[2].Value = date;
            param[3] = new SqlParameter("@take", SqlDbType.VarChar, 50);
            param[3].Value = take;
            param[4] = new SqlParameter("@give", SqlDbType.VarChar, 50);
            param[4].Value = give;
            param[5] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[5].Value = notes;
            DAL.open();
            DAL.executenonquery("update_shokak_operation", param);
            DAL.close();
        }

        public DataTable searsh_clints(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar,50);
            param[0].Value = id;
            return DAL.selectdata("searsh_clints", param);
        }
        public DataTable get_shokak_op(int order_id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@order_id", SqlDbType.Int);
            param[0].Value = order_id;
            return DAL.selectdata("get_shokak_by_order_id", param);
        }


        public void insert_clint_points(string name)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@clint_name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            DAL.open();
            DAL.executenonquery("insert_clint_points", param);
            DAL.close();
        }
        public DataTable total_shokak()
        {

            return DAL.selectdata("total_shokak", null);
        }



    }
}
