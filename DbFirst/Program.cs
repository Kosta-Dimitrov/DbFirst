namespace DbFirst
{
    using DbFirst.Classes;
    using DbFirst.Functions;

    internal class Program
    {
        static void Main(string[] args)
        {
            using (database1Context context = new database1Context())
            {
                //Educationformtype educationformtype= new Educationformtype { Id=12, Isactive=true};
                //CRUDOperations.AddInstitution(context, "My speciality", true, 5, 44);
                //CRUDOperations.AddNewEducationFormType(context,"new type");
                CRUDOperations.AddEducation<Educationformtype>(context, "My educationform type", true, 8);
            }
        }
    }
}
