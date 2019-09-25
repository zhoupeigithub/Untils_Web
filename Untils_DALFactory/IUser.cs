using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using Untils_Model;

namespace Untils_DALFactory
{
    public interface IUser
    {
        DataTable GetAllData();//获得所有用户数据

        //int AddUser(BZ_User bu);//添加新数据
        //DataTable GetAllUserType();//取得所有用户类型数据
        //DataTable GetDetailsById(string zId);//根据Id获取用户详情
        //bool UpdateByZId(BZ_User bzu);//根据Id修改用户信息

    }

    public sealed partial class DataAccess
    {
        public static IUser CreateIUser()
        {
            string className = path + ".DALUser";
            return (IUser)Assembly.Load(path).CreateInstance(className);
        }
    }
}
