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
                //comment just for git
                CRUDOperations.AddEducation<Educationformtype>(context, "My educationform type", true, 8);
            }
        }
    }
}
