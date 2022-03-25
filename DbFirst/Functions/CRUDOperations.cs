namespace DbFirst.Functions
{
    using DbFirst.AbstractClasses;
    using DbFirst.Classes;
    using Microsoft.EntityFrameworkCore;

    internal class CRUDOperations
    {
        public static void  AddSpeciality(database1Context context,string name,int externalId)
        {
            Speciality newSpeciality=new Speciality { Name=name,Externalid=externalId};
            context.Specialities.Add(newSpeciality);
            context.SaveChanges();
        }

        public static void AddEducation<T>(database1Context context,string name,bool isActive,int viewOrder) where T:Education,new()
        {
            T itemToInsert = new T{ Id=123,Isactive=isActive,Vieworder=viewOrder};
            context.Add<T>(itemToInsert);
            context.SaveChanges();
        }
        public static int DeleteSpeciality(database1Context context,string name)
        {
            Speciality  specialityToDelete=context.Specialities.Where(x => x.Name==name).FirstOrDefault();
            if(specialityToDelete!=null)
            {
                context.Specialities.Remove(specialityToDelete);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int ChangeExternalId(database1Context context,string name,int externalId)
        {
            Speciality specialityToUpdate = context.Specialities.Where(x => x.Name == name).FirstOrDefault();
            if (specialityToUpdate != null)
            {
                specialityToUpdate.Externalid=externalId;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static void AddInstitution(database1Context context,string name,bool isActive,int level,int rootid)
        {
            Institution institutionToAdd = new Institution { Name = name, Isactive = isActive, Rootid = rootid,Id=32456 };
            context.Institutions.Add(institutionToAdd);
            context.SaveChanges();
        }
        public static int DeleteInstitution(database1Context context, string institutionName)
        {
            Institution institutionToDelete = context.Institutions.Where(i => i.Name == institutionName).FirstOrDefault();
            if (institutionToDelete != null)
            {
                context.Institutions.Remove(institutionToDelete);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static async Task<int> ChangeRootId(database1Context context, string institutionName, int rootId)
        {
            Institution institutionToUpdate = await context.Institutions.Where(x => x.Name == institutionName).FirstOrDefaultAsync();
            if (institutionToUpdate != null)
            {
                institutionToUpdate.Rootid = rootId;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //public static void AddNewEducationFormType(database1Context context,string name)
        //{
        //    Educationformtype newFormType = new Educationformtype { Name = name,Id=6};
        //    context.Add(newFormType);
        //    context.SaveChanges();
        //}
    }
}
