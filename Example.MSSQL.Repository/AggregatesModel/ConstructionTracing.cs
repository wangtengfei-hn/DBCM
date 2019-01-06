using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 施工跟踪
    /// </summary>
    public class ConstructionTracing : Model
    {
        /// <summary>
        /// 施工开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 施工结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 项目
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 施工类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 施工方
        /// </summary>
        public string Constructor { get; set; }
        /// <summary>
        /// 施工方电话
        /// </summary>
        public string ConstructorPhone { get; set; }
        /// <summary>
        /// 施工订单号
        /// </summary>
        public int ConstructionOrderNumber { get; set; }
        /// <summary>
        /// 施工图
        /// </summary>
        public string[] ConstructionPicture { get; set; }
        /// <summary>
        /// 造价，输入后更改房屋施工信息生成财务信息
        /// </summary>
        public int Price { get; set; }
        /// <summary>
        /// 支出，输入后更改房屋施工信息生成财务信息
        /// </summary>
        public int Expenditure { get; set; }
        /// <summary>
        /// 材料
        /// </summary>
        public string Material { get; set; }
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
