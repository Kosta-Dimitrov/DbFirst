namespace DbFirst.Classes
{
    using System.Collections.Generic;
    public partial class Speciality
    {
        public Speciality()
        {
            Institutionspecialities = new HashSet<Institutionspeciality>();
        }

        public int Id { get; set; }
        public int Externalid { get; set; }
        public int? Educationalqualificationid { get; set; }
        public string? Name { get; set; }
        public int? Vieworder { get; set; }
        public bool Isactive { get; set; }

        public virtual Educationalqualification? Educationalqualification { get; set; }
        public virtual ICollection<Institutionspeciality> Institutionspecialities { get; set; }
    }
}
