using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace amir_mostafa.BL
{
    class city
    {
        public void insert(string name)
        {
             DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar,50);
            param[0].Value = name;
            DAL.open();
            DAL.executenonquery("insert_city", param);
            DAL.close();
            
        }
        public DataTable all()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_city", null);
            return dt;
        }
        public DataTable city_report(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("report_city", param);
            return dt;
        }
    }
}
