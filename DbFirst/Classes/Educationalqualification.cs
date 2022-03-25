namespace DbFirst.Classes
{
    using DbFirst.AbstractClasses;
    public partial class Educationalqualification:Education
    {
        public Educationalqualification()
        {
            Specialities = new HashSet<Speciality>();
        }

        public string? Alias { get; set; }

        public virtual ICollection<Speciality> Specialities { get; set; }
    }
}
