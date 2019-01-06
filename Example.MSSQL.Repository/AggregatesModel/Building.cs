using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 楼宇
    /// </summary>
    public class Building : Model
    {
        /// <summary>
        /// 别名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 楼号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 单元
        /// </summary>
        public int Unit { get; set; }
        /// <summary>
        /// 进入密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 总楼层
        /// </summary>
        public int TotalFloor { get; set; }
        /// <summary>
        /// 总户数
        /// </summary>
        public int TotalHouse { get; set; }
        /// <summary>
        /// 已录入楼层
        /// </summary>
        public int InputFloor { get; set; }
        /// <summary>
        /// 已录入户数
        /// </summary>
        public int InputHouse { get; set; }
        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid Community_ID { get; set; }
    }
}
