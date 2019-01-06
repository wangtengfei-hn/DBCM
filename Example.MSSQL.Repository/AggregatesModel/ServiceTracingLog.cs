using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 售后跟踪记录
    /// </summary>
    public class ServiceTracingLog : Model
    {
        /// <summary>
        /// 售后服务
        /// 业主报修
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 处理时间
        /// </summary>
        public DateTime HandleTime { get; set; }
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

        /// <summary>
        /// 绑定员工
        /// </summary>
        public Guid Staff_ID { get; set; }

        /// <summary>
        /// 添加员工
        /// </summary>
        public Guid Add_Staff_ID { get; set; }

    }
}
