using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class cls_supports
    {
        public DataTable select()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            return DAL.selectdata("all_supports", null);
        }
        public void insert(string name, string addres, string phone, string bankn, string bankname)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@support_name", SqlDbType.VarChar, 50);
            param[0].Value = name;
            param[1] = new SqlParameter("@address", SqlDbType.VarChar, 50);
            param[1].Value = addres;
            param[2] = new SqlParameter("@phone_number", SqlDbType.VarChar, 50);
            param[2].Value = phone;
            param[3] = new SqlParameter("@banq_number", SqlDbType.VarChar, 50);
            param[3].Value = bankn;
            param[4] = new SqlParameter("@banke_name", SqlDbType.VarChar, 50);
            param[4].Value = bankname;
            DAL.open();
            DAL.executenonquery("new_support", param);
            DAL.close();
        }
        public void update(int id, string name, string address, string phone, string bank_num, string panq_name)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@support_id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@support_name", SqlDbType.VarChar, 50);
            param[1].Value = name;
            param[2] = new SqlParameter("@address", SqlDbType.VarChar, 50);
            param[2].Value = address;
            param[3] = new SqlParameter("@phone_number", SqlDbType.VarChar, 50);
            param[3].Value = phone;
            param[4] = new SqlParameter("@banq_number", SqlDbType.VarChar, 50);
            param[4].Value = bank_num;
            param[5] = new SqlParameter("@banq_name", SqlDbType.VarChar, 50);
            param[5].Value = panq_name;
            DAL.open();
            DAL.executenonquery("update_support", param);
            DAL.close();
        }
        public void delete(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@support_id", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DAL.executenonquery("delete_support", param);
            DAL.close();
        }
        public DataTable searsh_supply(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("searsh_support", param);
            return dt;
        }
    }
}
