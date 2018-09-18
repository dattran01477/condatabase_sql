using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conndatabase.data
{

    class connect
    {
        private string ipName;
        private string user;
        private string pass;

        public connect(string ipName, string user, string pass)
        {
            this.ipName = ipName;
            this.user = user;
            this.pass = pass;
        }
        private SqlConnection con;
        public string IpName { get => ipName; set => ipName = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }

        public void conn()
        {
            //Data Source = 192.168.137.172; Initial Catalog = sinhvien; User ID = thanhvien1
            
            String cn = @"Data Source="+IpName+";User ID="+User+";Password="+Pass+"";
            try
            {
                con = new SqlConnection(cn);
                con.Open();
                MessageBox.Show("Kết nối thành công", "Ahihi");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Console.ReadLine();
        }
        public List<string> getDataName()
        {
            List<string> dataName = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        dataName.Add(dr[0].ToString());
                    }
                }
            }
            return dataName;
        }
        public List<string> getTableName(string dataName)
        {
            List<string> tableName = new List<string>();
            using (SqlCommand cmd = new SqlCommand("use " + dataName+";"+"SELECT name from sys.Tables", con))
            {
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tableName.Add(dr[0].ToString());
                    }
                }
            }
            return tableName;
        }
        public DataTable getDataTable(string tableName,string dataName)
        {
            string sql = "use "+dataName+";select * from "+tableName+"";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);
            return dt;
        }
    }
}
