using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModalHelper
{
     public class CulturalRelicModal
    {

        #region 名称要和数据库里面的名称一致--->便于识别
        /// <summary>
        /// 图片路径
        /// </summary>
        public string imagePath { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string culturalRelicName { get; set; }
        /// <summary>
        /// EnlishName
        /// </summary>
        public string englishiName { get; set; }
        /// <summary>
        /// 产状分类
        /// </summary>
        public string cultrualRelicClassify { get; set; }
        /// <summary>
        /// 编码
        /// </summary>
        public string culturalRelicCode { get; set; }
        /// <summary>
        /// 材质
        /// </summary>
        public string culturalRelicMaterrial { get; set; }
        /// <summary>
        /// 展位
        /// </summary>
        public string culturalRelicPosition { get; set; }
        /// <summary>
        ///产地
        /// </summary>
        public string culturalRelicBirthPlace { get; set; }
        /// <summary>
        /// 制造日期
        /// </summary>
        public string cultrualRelicBirthDataTime { get; set; }
        /// <summary>
        /// 出土日期
        /// </summary>
        public string culturalRelicDataofFigura { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string culturalRelicBrief { get; set; } 
        #endregion
    }
}
