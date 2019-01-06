using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 待办事项
    /// </summary>
    public class Upcoming : Model
    {
        /// <summary>
        /// 提醒时间
        /// </summary>
        public DateTime RemindTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 绑定事件
        /// </summary>
        public int Identity { get; set; }
        /// <summary>
        /// 绑定事件ID
        /// </summary>
        public Guid Identity_ID { get; set; }

        /// <summary>
        /// 绑定员工
        /// </summary>
        public Guid Staff_ID { get; set; }
    }
}
