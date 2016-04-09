using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.AppCode
{
    public class FM_Class
    {
        public int ClassID { set; get; }
        public int SubjectID { set; get; }
        public int RoomID { set; get; }
        public int TeacherID { set; get; }
        public string ClassCode { set; get; }
        public string ClassName { set; get; }
        public int DayOfWeek { set; get; }
        public DateTime TimeStart { set; get; }
        public DateTime TimeEnd { set; get; }
        public string Description { set; get; }
        public DateTime CreatedDate { set; get; }
        public int UpdatedUser { set; get; }
        public DateTime UpdatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public int DeletedUser { set; get; }
        public DateTime DeletedDate { set; get; }
    }
}
