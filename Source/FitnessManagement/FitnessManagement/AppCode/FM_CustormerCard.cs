using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.AppCode
{
    public class FM_CustormerCard
    {
        public int CustormerCardID { set; get; }
        public int FromCustormerID { set; get; }
        public int CustormerID { set; get; }
        public int CardID { set; get; }
        public bool IsActived { set; get; }
        public int NumOfTimes { set; get; }
        public int TotalTimes { set; get; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public int ConsultUser { set; get; }
        public string Description { set; get; }
        public int CreatedUser { set; get; }
        public DateTime CreatedDate { set; get; }
        public int UpdatedUser { set; get; }
        public DateTime UpdatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public int DeletedUser { set; get; }
        public DateTime DeletedDate { set; get; }
    }
}
