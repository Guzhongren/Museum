using DAL;
using ModalHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CulturalRelicBLL
    {
        DAL.ResultModalList culturalRelicList = new DAL.ResultModalList();
        //List<CulturalRelicModal> selectedResult = new List<CulturalRelicModal>();
        public List<CulturalRelicModal> SelectResult(List<string> listParams) 
        {
            return culturalRelicList.getResult(listParams);

        }
        

    }
}
