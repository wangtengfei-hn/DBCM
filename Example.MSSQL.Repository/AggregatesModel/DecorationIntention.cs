using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 装修意向-整体
    /// </summary>
    public class DecorationIntention:Model
    {
        /// <summary>
        /// 区域
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 风格
        /// </summary>
        public string Style { get; set; }
        /// <summary>
        /// 色调
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 功能
        /// </summary>
        public string Features { get; set; }
        /// <summary>
        /// 业主预估价格
        /// </summary>
        public int OwnerEstimatedPrice { get; set; }
        /// <summary>
        /// 施工预估价格
        /// </summary>
        public int EstimatedPrice { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid Community_ID { get; set; }
        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid Building_ID { get; set; }
        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid BuildingFloor_ID { get; set; }
        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid House_ID { get; set; }
    }
}
