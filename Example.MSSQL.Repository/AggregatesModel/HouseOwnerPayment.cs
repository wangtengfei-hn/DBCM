using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 业主付款记录
    /// </summary>
   public class HouseOwnerPayment:Model
    {
        /// <summary>
        /// 金额
        /// </summary>
        public int Money { get; set; }
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
