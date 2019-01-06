using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 社区
    /// </summary>
    public class Community : Model
    {
        /// <summary>
        /// 小区名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 地理位置
        /// </summary>
        public string ADCode { get; set; }
        /// <summary>
        /// 均价
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 交付时间
        /// </summary>
        public DateTime DeliverDate { get; set; }
        /// <summary>
        /// 小区简介
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 施工房屋
        /// </summary>
        public int ConstructionHouse { get; set; }
        /// <summary>
        /// 完工房屋
        /// </summary>
        public int CompleteHouse { get; set; }
        /// <summary>
        /// 物业公司
        /// </summary>
        public string HousekeeperName { get; set; }
        /// <summary>
        /// 物业电话
        /// </summary>
        public string HousekeeperPhone { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string HousekeeperPrincipal { get; set; }
        /// <summary>
        /// 负责人电话
        /// </summary>
        public string HousekeeperPrincipalPhone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid Company_ID { get; set; }
    }
}
