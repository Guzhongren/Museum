using ModalHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DAL
{
    public class ResultModalList
    {
        private List<ModalHelper.CulturalRelicModal> list = new List<ModalHelper.CulturalRelicModal>();
        private string sql = "select * from historicalrelic where cultrualrelicbirthdatatime =@CulturalRelicDataTime and culturalrelicname =@CulturalRelicName";
        //private string sql = "select * from historicalrelic where convert(nvarchar(255),cultrualrelicbirthdatatime) =@CulturalRelicDataTime and convert(nvarchar(255),culturalrelicname)=@CulturalRelicName";
        public List<ModalHelper.CulturalRelicModal> getResult(List<string> sqlParams)
        {
            DataTable dataTable = ModalHelper.SqlHelper.ExecuteDataTabel(sql, new NpgsqlParameter("@CulturalRelicDataTime", sqlParams[0]),
                                                                              new NpgsqlParameter("@CulturalRelicName", sqlParams[1]));
            //sql写死执行
            //DataTable dataTable = ModalHelper.SqlHelper.ExecuteDataTableTest();s
            int rowCount = dataTable.Rows.Count;
            if (rowCount <= 0)
            {
                return list;
                //return null;
            }
            else
            {
                for (int i = 0; i < rowCount;i++ )
                {
                    CulturalRelicModal culturalRelicModal = new CulturalRelicModal();
                    DataRow dataRow=dataTable.Rows[i];
                    culturalRelicModal.imagePath = fromDbNull(dataRow["imagepath"].ToString()).ToString();
                    culturalRelicModal.culturalRelicName = dataRow["culturalrelicname"].ToString();
                    culturalRelicModal.englishiName = dataRow["englishiname"].ToString();
                    culturalRelicModal.cultrualRelicClassify = dataRow["cultrualrelicclassify"].ToString();
                    culturalRelicModal.culturalRelicCode = dataRow["culturalreliccode"].ToString();
                    culturalRelicModal.culturalRelicMaterrial = dataRow["culturalrelicmaterrial"].ToString();
                    culturalRelicModal.culturalRelicPosition = dataRow["culturalrelicposition"].ToString();
                    culturalRelicModal.culturalRelicBirthPlace = dataRow["culturalrelicbirthplace"].ToString();
                    culturalRelicModal.cultrualRelicBirthDataTime = dataRow["cultrualrelicbirthdataTime"].ToString();
                    culturalRelicModal.culturalRelicDataofFigura = dataRow["culturalrelicdataoffigura"].ToString();
                    culturalRelicModal.culturalRelicBrief = dataRow["culturalrelicbrief"].ToString();
                    list.Add(culturalRelicModal);
                }
                    return list;
            }
        }
        private object fromDbNull(object db)
        {
            return db == DBNull.Value ? null : db;
        }
    
        
    }
}
