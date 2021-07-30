using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class users
    {
        DAL.DataAccesLier DAL = new DAL.DataAccesLier();
        public DataTable select()
        {
            DAL.open();
            return DAL.selectdata("sp_all_users", null);
            DAL.close();
        }
        public void insert(string user, string pass, string type)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[0].Value = user;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = pass;
            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = type;
            DAL.open();
            DAL.executenonquery("new_user", param);
            DAL.close();
        }
        public void update(string user, string pass, string type)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[0].Value = user;
            param[1] = new SqlParameter("@password", SqlDbType.VarChar, 50);
            param[1].Value = pass;
            param[2] = new SqlParameter("@type", SqlDbType.VarChar, 50);
            param[2].Value = type;
            DAL.open();
            DAL.executenonquery("update_user", param);
            DAL.close();
        }
        public void delete(string user)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[0].Value = user;
            DAL.open();
            DAL.executenonquery("delete_user", param);
            DAL.close();
        }
    }
}
