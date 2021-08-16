namespace DinnerMenu.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Core;
    
    public class DinnerMenuRepository : RepositoryBase<Dinner>, IDinnerRepository
    {

        protected override async Task<Dinner> AddImpl(Dinner entity)
        {
            File.AppendAllText("DinnerDb.txt", entity.Name + "\n");
            return entity;
        }

        protected override List<string> GetItems()
        {
            var random = new Random();

            var StreamReader = new StreamReader("DinnerDb.txt");

            int options = 0;
            List<string> DinnerMenu = new List<string>();

            while(StreamReader.ReadLine() != null)
            {
                options++;
            }

            while(DinnerMenu.Count() != 7 )
            {
                int num = random.Next(options + 1);
                string lineOption = File.ReadLines("DinnerDb.txt").Skip(num - 1).FirstOrDefault();
                
                if (!DinnerMenu.Contains(lineOption))
                {
                    DinnerMenu.Add(lineOption);
                }
                
            }

            
            
            return DinnerMenu;
        }

        

    }
}
