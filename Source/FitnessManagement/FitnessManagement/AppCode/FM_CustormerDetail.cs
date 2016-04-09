using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.AppCode
{
    public class FM_CustormerDetail
    {
        public int CustormerDetailID { set; get; }
        public int CustormerCardID { set; get; }
        public bool IsCheckIn { set; get; }
        public int ClassID { set; get; }
        public string Note { set; get; }
        public int CreatedUser { set; get; }
        public DateTime CreatedDate { set; get; }
        public int UpdatedUser { set; get; }
        public DateTime UpdatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public int DeletedUser { set; get; }
        public DateTime DeletedDate { set; get; }
    }
}
