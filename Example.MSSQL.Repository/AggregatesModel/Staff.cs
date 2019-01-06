using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 员工
    /// </summary>
    public class Staff :Model
    {

        /// <summary>
        /// 职位
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 基本工资
        /// </summary>
        public int BasicWage { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 定制提成
        /// </summary>
        public string[] MadeCommission { get; set; }
        /// <summary>
        /// 硬装提成
        /// </summary>
        public string[] BasicsCommission { get; set; }

        /// <summary>
        /// 公司
        /// </summary>
        public Guid Company_ID { get; set; }
    }
}
