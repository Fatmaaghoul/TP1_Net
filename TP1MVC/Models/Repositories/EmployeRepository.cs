namespace TP1MVC.Models.Repositories
{
    public class EmployeRepository : IRepository<Employe>
    {
        List<Employe> lemployes;
        public EmployeRepository()
        {
            lemployes = new List<Employe>()
            {
                new Employe {Id=1,Name="Sofien ben ali",Departement="comptabilité",Salary=1000},
                new Employe {Id=2,Name="Mourad triki",Departement="RH",Salary=1500},
                new Employe {Id=3,Name="ali ben mohamed", Departement= "informatique",Salary=1700},
                new Employe {Id=4,Name="tarak aribi", Departement= "informatique",Salary=1100}
             };
        }
        public void Add(Employe entity)
        {
            if (entity != null)
                lemployes.Add(entity);
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            var emp = FindByID(id);
            lemployes.Remove(emp);
            throw new NotImplementedException();
        }
        public Employe FindByID(int id)
        {
            var emp = lemployes.FirstOrDefault(a => a.Id == id);
            return emp;
            throw new NotImplementedException();
        }
        public List<Employe> GetAll()
        {
            return lemployes;
            throw new NotImplementedException();
        }
        public List<Employe> Search(string term)
        {
            if (!string.IsNullOrEmpty(term))
            {
                return lemployes.Where(a => a.Name.Contains(term)).ToList();
            }
            else
                return lemployes;
            throw new NotImplementedException();
        }
        public void Update(int id, Employe entity)
        {
            var emp = FindByID(id);
            if(emp.Id == entity.Id)
            {
                emp.Name = entity.Name;
                emp.Departement = entity.Departement;
                emp.Salary = entity.Salary;

            }
            throw new NotImplementedException();
        }

        IList<Employe> IRepository<Employe>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

