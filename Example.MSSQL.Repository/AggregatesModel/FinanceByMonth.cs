using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    public class FinanceByMonth: Model
    {
        /// <summary>
        /// 施工造价
        /// </summary>
        public int ConstructionPrice { get; set; }
        /// <summary>
        /// 施工支出
        /// </summary>
        public int ConstructionExpenditure { get; set; }
        /// <summary>
        /// 定制收入
        /// </summary>
        public int Made { get; set; }
        /// <summary>
        /// 硬装收入
        /// </summary>
        public int Basics { get; set; }
        /// <summary>
        /// 客户已支付
        /// </summary>
        public int OwnerPaid { get; set; }
        /// <summary>
        /// 发放工资
        /// </summary>
        public decimal StaffWage { get; set; }
        /// <summary>
        /// 其他支出
        /// </summary>
        public decimal OtherIncome { get; set; }
        /// <summary>
        /// 其他收入
        /// </summary>
        public decimal OtherExpenditure { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid Company_ID { get; set; }
    }
}
