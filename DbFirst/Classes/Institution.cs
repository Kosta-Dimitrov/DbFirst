using System;
using System.Collections.Generic;

namespace DbFirst.Classes
{
    public partial class Institution
    {
        public Institution()
        {
            Institutionspecialities = new HashSet<Institutionspeciality>();
        }

        public int Id { get; set; }
        public int? Institutiontypeid { get; set; }
        public int Externalid { get; set; }
        public int Rootid { get; set; }
        public int? Parentid { get; set; }
        public int Level { get; set; }
        public string? Name { get; set; }
        public int? Vieworder { get; set; }
        public bool Isactive { get; set; }
        public int? Institutionownershiptypeid { get; set; }

        public virtual ICollection<Institutionspeciality> Institutionspecialities { get; set; }
    }
}
