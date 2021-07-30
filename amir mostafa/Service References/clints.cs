using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace amir_mostafa.BL
{
    class clints
    {
        public DataTable clint_search(string id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = id;
            DataTable dt = new DataTable();
            dt = DAL.selectdata("clint_search", param);
            return dt;
        }
        public DataTable all_clints()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("sp_all_clints", null);
            return dt;
        }
            public DataTable clints_name_id()
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("clints_name_id", null);
            return dt;
        }
        public void New(string name, int sons, string card, string ssna, string pass, string sup, string notes,int city)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@clint_name", SqlDbType.VarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@sons_number", SqlDbType.Int);
            param[1].Value = sons;

            param[2] = new SqlParameter("@nuber_card", SqlDbType.VarChar, 50);
            param[2].Value = card;
            param[3] = new SqlParameter("@national_id", SqlDbType.VarChar, 50);
            param[3].Value = ssna;
            param[4] = new SqlParameter("@secrit_number", SqlDbType.VarChar, 50);
            param[4].Value = pass;
            param[5] = new SqlParameter("@support", SqlDbType.VarChar, 50);
            param[5].Value = sup;
            param[6] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[6].Value = notes;
            param[7] = new SqlParameter("@city", SqlDbType.Int);
            param[7].Value = notes;
            DAL.open();
            DAL.executenonquery("sp_new_clint", param);
            DAL.close();
        }
        public void delete(int id)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            DAL.open();
            DAL.executenonquery("delete_clint", param);
            DAL.close();
        }
        public void update(int id,string name, int sons, string card, string ssna, string pass, string sup, string notes,int city)
        {
            DAL.DataAccesLier DAL = new DAL.DataAccesLier();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@clint_name", SqlDbType.VarChar, 50);
            param[1].Value = name;

            param[2] = new SqlParameter("@sons_number", SqlDbType.Int);
            param[2].Value = sons;

            param[3] = new SqlParameter("@number_card", SqlDbType.VarChar, 50);
            param[3].Value = card;
            param[4] = new SqlParameter("@national_id", SqlDbType.VarChar, 50);
            param[4].Value = ssna;
            param[5] = new SqlParameter("@secrit_number", SqlDbType.VarChar, 50);
            param[5].Value = pass;
            param[6] = new SqlParameter("@support", SqlDbType.VarChar, 50);
            param[6].Value = sup;
            param[7] = new SqlParameter("@notes", SqlDbType.VarChar, 50);
            param[7].Value = notes;
            param[8] = new SqlParameter("@city", SqlDbType.Int);
            param[8].Value = city;
            DAL.open();
            DAL.executenonquery("sp_update_clint", param);
            DAL.close();
            pl.clints_form.clints_formm.dataGridView1.DataSource = DAL.selectdata("sp_all_clints", null);
        }
    }
}
