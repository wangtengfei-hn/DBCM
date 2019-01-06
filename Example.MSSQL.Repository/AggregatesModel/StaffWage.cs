using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 
    /// </summary>
    public class StaffWage:Model
    {

        /// <summary>
        /// 基本工资
        /// </summary>
        public int BasicWage { get; set; }
        /// <summary>
        /// 定制业绩
        /// </summary>
        public decimal Made { get; set; }
        /// <summary>
        /// 硬装业绩
        /// </summary>
        public decimal Basics { get; set; }
        /// <summary>
        /// 定制提成
        /// </summary>
        public decimal MadeCommission { get; set; }
        /// <summary>
        /// 硬装提成
        /// </summary>
        public decimal BasicsCommission { get; set; }
        /// <summary>
        /// 奖励
        /// </summary>
        public decimal Bonus { get; set; }
        /// <summary>
        /// 扣除
        /// </summary>
        public decimal Deduction { get; set; }
        /// <summary>
        /// 实发
        /// 大于0时已发放
        /// </summary>
        public decimal Actual { get; set; }
        /// <summary>
        /// 员工
        /// </summary>
        public Guid Staff_ID { get; set; }
    }
}
