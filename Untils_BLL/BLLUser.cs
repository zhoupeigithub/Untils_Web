using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Untils_DALFactory;
using Untils_Model;

namespace Untils_BLL
{
    public class BLLUser
    {
        private IUser iu;
        public BLLUser()
        {
            iu = DataAccess.CreateIUser();
        }

        /// <summary>
        /// 获取所有的用户信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllData()
        {
            return iu.GetAllData();
        }

        ///// <summary>
        ///// 获取所有用户类型
        ///// </summary>
        ///// <returns></returns>
        //public DataTable GetAllUserType() 
        //{
        //    return iu.GetAllUserType();
        //}

        ///// <summary>
        ///// 添加用户
        ///// </summary>
        ///// <param name="bu"></param>
        ///// <returns></returns>
        //public int Add(BZ_User bu)//添加
        //{
        //    int result = iu.AddUser(bu);
        //    return result;
        //}

        ///// <summary>
        ///// 获取详情
        ///// </summary>
        ///// <param name="zId"></param>
        ///// <returns></returns>
        //public DataTable GetDetailsById(string zId)
        //{
        //    return iu.GetDetailsById(zId);
        //}

        ///// <summary>
        ///// 修改详情
        ///// </summary>
        ///// <param name="bzu">实体模型</param>
        ///// <returns></returns>
        //public bool UpdateByZId(BZ_User bzu)
        //{
        //    return iu.UpdateByZId(bzu);
        //}
       
    }
}
