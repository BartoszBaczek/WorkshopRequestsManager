using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WorkshopManager.DatabasePresenter

{
    using SqlDatabase;
    struct Data
    {
        public int ID;
        public string Model;
        public string Owner;
        public string Description;
        public List<Part> ListOfParts;
    }

    class DatabasePresenter : IPartsDatabaseAdapter, IRequestDatabaseAdapter
    {
        OrdersTableAdapter OrdersData = new OrdersTableAdapter();
        
        public List<Request> GetByID(int id)
        {
            Data requestBuff;
            List<Request> result = new List<Request>();
            List<string>[] DatabaseData = OrdersData.Get.ById(id);
            string[,]
            for (int i = 0; i < DatabaseData[0].Count();i++)
            {
                
            }


            return result;
        }
        
        public string[,] ConvertToTable(List<string>[] tabelOfLists)
        {
            int colCount = tabelOfLists.Length;
            int rowCount = tabelOfLists[0].Count;
            string[,] result = new String[colCount,rowCount];
            for (int i = 0; i < colCount;i++ )
            {
                int j =0;
                foreach(string data in tabelOfLists[i])
                {
                    result[i, j] = data;
                    j++;
                }

            }
                return result;

        }


    }
}
