using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class cls_login
    {
        public DataTable login(string id,string password)
        {
            DAL.DataAccesLier DAL=new DAL.DataAccesLier();
            SqlParameter[]param=new SqlParameter[2];
            param[0]=new SqlParameter("@user_name",SqlDbType.VarChar,50);
            param[0].Value=id;
            param[1]=new SqlParameter("@password",SqlDbType.VarChar,50);
            param[1].Value=password;
            DAL.open();
            return DAL.selectdata("sp_login", param);
            DAL.close();

            
        }
    }
}
