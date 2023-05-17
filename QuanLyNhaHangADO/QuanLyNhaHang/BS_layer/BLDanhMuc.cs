using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.BS_layer
{
    class BLDanhMuc
    {
        DAL db = null;
        public BLDanhMuc()
        {
            db = new DAL();
        }
        public DataSet LayDanhMuc()
        {
            return db.ExecuteQueryDataSet("select * from DanhMuc", CommandType.Text);
        }
        public DataSet TimKiemDanhMuc(string str)
        {
            return db.ExecuteQueryDataSet("select * from DanhMuc where TenDM like '%" + str + "%' ", CommandType.Text);
        }
        public bool ThemDanhMuc(string MaDM, string TenDM, ref string err)
        {
            string sqlString = "Insert Into DanhMuc Values(" + "'" +
            MaDM + "',N'" +
            TenDM + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool XoaDanhMuc(string MaDM, ref string err)
        {
            string sqlString = "Delete From DanhMuc Where MaDM='" + MaDM + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatDanhMuc(string MaDM, string TenDM, ref string err)
        {
            string sqlString = "Update DanhMuc Set TenDM=N'" +
            TenDM + "' Where MaDM='" + MaDM + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
