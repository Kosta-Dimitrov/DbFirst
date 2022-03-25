using System;
using System.Collections.Generic;

namespace DbFirst.Classes
{
    public partial class Institutionspeciality
    {
        public int Id { get; set; }
        public int? Vieworder { get; set; }
        public bool Isactive { get; set; }
        public int Externalid { get; set; }
        public int Institutionid { get; set; }
        public int Specialityid { get; set; }
        public int? Educationalformid { get; set; }
        public double? Duration { get; set; }
        public int? Researchareaid { get; set; }

        public virtual Educationformtype? Educationalform { get; set; }
        public virtual Institution Institution { get; set; } = null!;
        public virtual Speciality Speciality { get; set; } = null!;
    }
}
