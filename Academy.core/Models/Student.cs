using Academy.core.Enums;
using OfficeDevPnP.Core.Framework.Provisioning.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy.core.Models
{
    public class Student:BaseModel
    {
        static int _id;
        public string FullName { get; set; }    
        public double Average { get; set; }
        public string Group { get; set; }
        public Specialty Specialty { get; set; }
        public string Id { get; }
        public DateTime CreatAt { get; set; }
        public string id { get; set; }
        public DateTime UpdateAt { get; set; }

        public Student(string FullName, double Average,string Group, Specialty Specialty)
        {
            _id++;
            string studentName = Specialty.ToString();

            Id = $"{studentName[0]}-{_id}";
            this.FullName = FullName;
            this.Group = Group;
            this.Average = Average;
            this.Specialty = Specialty;





        }

        public Student(string fullName, string group, double average, Specialty specialty)
        {
            FullName = fullName;
            Group = group;
            Average = average;
            Specialty = specialty;
        }
    }
}
