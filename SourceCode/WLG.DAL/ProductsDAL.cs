using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using WLG.IDAL;
using WLG.Model;
using System.Data;

namespace WLG.DAL
{
    public class ProductsDAL : IProducts
    {
        /// <summary>
        /// 获取商品分类信息
        /// </summary>
        /// <returns></returns>
        public IList<Vshop_Categories> GetCategoryList()
        {
            try
            {
                DataTable dt = DataProvide.Query("select t.*, t.ParentCategoryId as _parentId  from  Vshop_Categories t");
                return TypeConvert.ToList<Vshop_Categories>(dt);
            }
            catch (Exception e)
            {
                throw new DALException("获取商品分类信息异常", e);
            }
        }
    }
}
