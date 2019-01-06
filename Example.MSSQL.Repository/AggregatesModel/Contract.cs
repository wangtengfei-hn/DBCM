using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 合同价格
    /// </summary>
    public class Contract : Model
    {
        /// <summary>
        /// 硬装金额，可以未负数，输入后更改房屋信息生成财务信息
        /// </summary>
        public int BasicsMoney { get; set; }
        /// <summary>
        /// 定制金额，可以未负数，输入后更改房屋信息生成财务信息
        /// </summary>
        public int MadeMoney { get; set; }
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
