﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessManagement.AppCode
{
    public class FM_Subject
    {
        public int SubjectID { set; get; }
        public string SubjectCode { set; get; }
        public string SubjectName { set; get; }
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
