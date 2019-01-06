using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.MSSQL.Repository.AggregatesModel
{
    /// <summary>
    /// 房屋
    /// </summary>
    public class House : Model
    {
        /// <summary>
        /// 门牌号
        /// </summary>
        public string HouseNumber { get; set; }
        /// <summary>
        /// 别名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 户型
        /// </summary>
        public string HouseType { get; set; }
        /// <summary>
        /// 建筑面积
        /// </summary>
        public int BuildingArea { get; set; }
        /// <summary>
        /// 使用面积
        /// </summary>
        public int UsageArea { get; set; }
        /// <summary>
        /// 装潢状态(毛坯，在装，完工)
        /// </summary>
        public int DecorationState { get; set; }
        /// <summary>
        /// 电话推广反馈（重点，意向，忽略）
        /// </summary>
        public string PhonePromotionFeedback { get; set; }
        /// <summary>
        /// 定金
        /// 只可以输入一次，输入后自动添加一条支付记录
        /// </summary>
        public int EarnestMoney { get; set; }
        /// <summary>
        /// 参与活动
        /// </summary>
        public string Participate { get; set; }
        /// <summary>
        /// 跟踪状态（装前跟踪，装修跟踪，售后跟踪）
        /// </summary>
        public int TrackState { get; set; }
        /// <summary>
        /// 装修前图片资料
        /// </summary>
        public string[] RoughPicture { get; set; }
        /// <summary>
        /// 装修后图片资料
        /// </summary>
        public string[] BeautifulPicture { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 设计
        /// </summary>
        public Guid Design { get; set; }
        /// <summary>
        /// 销售
        /// </summary>
        public Guid Salesman { get; set; }
        /// <summary>
        /// 监视
        /// </summary>
        public Guid Supervisor { get; set; }
        /// <summary>
        /// 施工造价
        /// 增加施工同时累加，输入后生成财务信息
        /// </summary>
        public int ConstructionPrice { get; set; }
        /// <summary>
        /// 施工支出
        /// 增加施工同时累加，输入后生成财务信息
        /// </summary>
        public int ConstructionExpenditure { get; set; }
        /// <summary>
        /// 定制费用
        /// 手动输入，可以多条，可以扣除，输入后管理员工增加业绩，输入后生成财务信息
        /// </summary>
        public int Made { get; set; }
        /// <summary>
        /// 硬装费用
        /// 手动输入，可以多条，可以扣除，输入后管理员工增加业绩，输入后生成财务信息
        /// </summary>
        public int Basics { get; set; }
        /// <summary>
        /// 已支付
        /// 手动输入，可以多条，可以扣除，输入后生成财务信息
        /// </summary>
        public int Paid { get; set; }
        /// <summary>
        /// 未支付
        /// 自动计算，输入后生成财务信息
        /// </summary>
        public int Unpaid { get; set; }

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

    }
}
