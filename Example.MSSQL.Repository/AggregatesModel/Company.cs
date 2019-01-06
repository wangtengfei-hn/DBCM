using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    public class Company : Model
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 公司名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string Principal { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Introduction { get; set; }

    }
}
