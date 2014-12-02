using ModalHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ResultModalList
    {
        private List<ModalHelper.CulturalRelicModal> list = new List<ModalHelper.CulturalRelicModal>();
        private string sql = "select * from TableX where 年代=@CulturalRelicDataTime and 名称=@CulturalRelicName";
        public List<ModalHelper.CulturalRelicModal> getResult(string sql,List<string> sqlParams)
        {
            DataTable dataTable = ModalHelper.SqlHelper.ExecuteDataTabel(sql, new SqlParameter("@CulturalRelicDataTime",sqlParams[0]),
                                                                              new SqlParameter("@CulturalRelicName",sqlParams[1]));

            int rowCount = dataTable.Rows.Count;
            if (rowCount <= 0)
            {
                return list;
            }
            else
            {
                for (int i = 0; i < rowCount;i++ )
                {
                    CulturalRelicModal culturalRelicModal = new CulturalRelicModal();
                    DataRow dataRow=dataTable.Rows[i];
                    culturalRelicModal.imagePath = dataRow["imagePath"].ToString();
                    culturalRelicModal.culturalRelicName = dataRow["culturalRelicName"].ToString();
                    culturalRelicModal.englishiName = dataRow["englishiName"].ToString();
                    culturalRelicModal.cultrualRelicClassify = dataRow["cultrualRelicClassify"].ToString();
                    culturalRelicModal.culturalRelicCode = dataRow["culturalRelicCode"].ToString();
                    culturalRelicModal.culturalRelicMaterrial = dataRow["culturalRelicMaterrial"].ToString();
                    culturalRelicModal.culturalRelicPosition = dataRow["culturalRelicPosition"].ToString();
                    culturalRelicModal.culturalRelicBirthPlace = dataRow["culturalRelicBirthPlace"].ToString();
                    culturalRelicModal.cultrualRelicBirthDataTime = dataRow["cultrualRelicBirthDataTime"].ToString();
                    culturalRelicModal.culturalRelicDataofFigura = dataRow["culturalRelicDataofFigura"].ToString();
                    culturalRelicModal.culturalRelicBrief = dataRow["culturalRelicBrief"].ToString();
                    list.Add(culturalRelicModal);
                }
                    return list;
            }
        }
        
    }
}
