namespace DbFirst.Classes
{
    using DbFirst.AbstractClasses;
    public partial class Educationformtype:Education
    {
        public Educationformtype()
        {
            Institutionspecialities = new HashSet<Institutionspeciality>();
        }

        public virtual ICollection<Institutionspeciality> Institutionspecialities { get; set; }
    }
}
