using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 楼宇楼层
    /// </summary>
    public class BuildingFloor : Model
    {
        /// <summary>
        /// 别名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 楼层
        /// </summary>
        public int Floor { get; set; }

        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid Community_ID { get; set; }
        /// <summary>
        /// 绑定房屋
        /// </summary>
        public Guid Building_ID { get; set; }
    }
}
