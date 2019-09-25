using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Untils_DALFactory;
using Untils_DALProfile;
using Untils_Model;

namespace Untils_DALSQLServer
{
    public class DALUser : DbBaseRes, IUser
    {
        /// <summary>
        /// 获取所有的用户信息
        /// </summary>
        /// <returns>所有用户数据集</returns>
        public DataTable GetAllData()
        {
            string sqlstr = " select * from [dbo].[bz_Data] ";
            DataTable dt = DB_UntilsHelper.ExecuteTable(CommandType.Text, sqlstr, null);
            return dt;
        }

        ///// <summary>
        ///// 获取所有的用户类别
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetAllUserType()
        //{
        //    string sqlstr = "select * from UserType ";
        //    DataTable dt = DB_UntilsHelper.ExecuteTable(CommandType.Text, sqlstr, null);
        //    return dt;
        //}

        ///// <summary>
        ///// 添加用户
        ///// </summary>
        ///// <param name="bu"></param>
        ///// <returns></returns>
        //public int AddUser(BZ_User bu)
        //{
        //    string sqls = "Select * from BZ_User where Z_UserName=@UserName";
        //    SqlParameter psql = new SqlParameter("@UserName", bu.Z_UserName);
        //    DataTable dt = DB_UntilsHelper.ExecuteTable(CommandType.Text, sqls, psql);
        //    if (dt.Rows.Count > 0)
        //    {
        //        return 2;
        //    }
        //    else
        //    {
        //        string sql = "Insert into BZ_User(Z_UserName,Z_NickName,Z_Password,Z_UserType) values(@UserName,@NickName,@Password,@UType)";
        //        SqlParameter[] parm = new SqlParameter[14];
        //        parm[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 100);
        //        parm[0].Value = bu.Z_UserName;
        //        parm[1] = new SqlParameter("@NickName", SqlDbType.NVarChar, 100);
        //        parm[1].Value = bu.Z_NickName;
        //        parm[2] = new SqlParameter("@Password", SqlDbType.NVarChar, 100);
        //        parm[2].Value = bu.Z_Password;
        //        parm[3] = new SqlParameter("@UType", SqlDbType.NVarChar, 100);
        //        parm[3].Value = bu.Z_UserType;
        //        return DB_UntilsHelper.ExecuteNonQuery(CommandType.Text, sql, parm);
        //    }
        //}


        ///// <summary>
        ///// 获取某个的详细信息
        ///// </summary>
        ///// <param name="zId"></param>
        ///// <returns></returns>
        //public DataTable GetDetailsById(string zId)
        //{

        //    string sql = "select * from  dbo.BZ_User where Z_Id =@Uid";
        //    string UserId = "@Uid";
        //    SqlParameter[] vale = new SqlParameter[]
        //    {
        //        new SqlParameter(UserId,zId),
        //    };
        //    DataTable dt = DB_UntilsHelper.ExecuteTable(CommandType.Text, sql, vale);
        //    return dt;
        //}

        ///// <summary>
        ///// 修改--根据Id修改用户信息
        ///// </summary>
        ///// <param name="bzu"></param>
        ///// <returns></returns>
        //public bool UpdateByZId(BZ_User bzu)
        //{
        //    string sqlcommand = @"Update BZ_User set 
        //                                Z_UserName=@UserName ,
        //                                Z_NickName=@NickName ,
        //                                Z_Password=@Password ,
        //                                Z_UserType=@UserType 
        //                                where Z_Id=@UserID ";
        //    SqlParameter[] parameters = {  
        //                                   new SqlParameter("@UserName",bzu.Z_UserName),
        //                                   new SqlParameter("@NickName",bzu.Z_NickName),
        //                                   new SqlParameter("@Password",bzu.Z_Password),
        //                                   new SqlParameter("@UserType",bzu.Z_UserType),
        //                                   new SqlParameter("@UserID",bzu.Z_Id)
        //                               };
        //    try
        //    {
        //        int count = DB_UntilsHelper.ExecuteNonQuery(CommandType.Text, sqlcommand, parameters);
        //        if (count > 0)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
    }
}