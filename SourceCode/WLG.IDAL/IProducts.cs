using System.Collections;
using System.Collections.Generic;
using WLG.Model;

namespace WLG.IDAL
{
    public interface IProducts
    {
        /// <summary>
        /// 获取商品分类信息
        /// </summary>
        /// <returns></returns>
        IList<Vshop_Categories> GetCategoryList();
    }
}
