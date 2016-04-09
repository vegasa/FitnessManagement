using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.AppCode
{
    public class FM_Employee
    {
        public int EmployeeID { set; get; }
        public string EmployeeNo { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Gender { set; get; }
        public DateTime DOB { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public string Address { set; get; }
        public string ImagePath { set; get; }
        public string Password { set; get; }
        public bool IsLocked { set; get; }
        public int LockedUser { set; get; }
        public int CreatedUser { set; get; }
        public DateTime CreatedDate { set; get; }
        public int UpdatedUser { set; get; }
        public DateTime UpdatedDate { set; get; }
        public bool IsDeleted { set; get; }
        public int DeletedUser { set; get; }
        public DateTime DeletedDate { set; get; }
    }
}
