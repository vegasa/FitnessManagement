using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.AppCode
{
    public class FM_Card
    {
        public int CardID { set; get; }
        public string CardName { set; get; }
        public bool IsFullTime { set; get; }
        public int NumOfTimes { set; get; }
        public int NumOfMonths { set; get; }
        public int Cost { set; get; }
        public int CreatedUser { set; get; }
        public DateTime CreatedDate { set; get; }
        public int UpdatedUser { set; get; }
        public DateTime UpdatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public int DeletedUser { set; get; }
        public DateTime DeletedDate { set; get; }


    }
}
