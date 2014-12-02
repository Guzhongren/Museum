using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
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
                return list;
            }
                

            
        }
        
    }
}
