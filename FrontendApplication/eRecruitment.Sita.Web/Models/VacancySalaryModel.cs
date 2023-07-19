using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRecruitment.Sita.Web.Models
{
    public class VacancySalaryModel
    {
       public   int SalaryID { get; set; }
       public  int JobTitleID { get; set; }
       public   string JobLevel { get; set; }
       public  decimal MinValue { get; set; }
       public  decimal MaxValue { get; set; }
       public  int VacancyID { get; set; }

    }
}