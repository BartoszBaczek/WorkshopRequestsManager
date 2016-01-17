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
        private OrdersTableAdapter OrdersData = new OrdersTableAdapter();
        private List<string>[] DatabaseData;
        private string[,] convertedData;
        private Data ReqBuff;


        public List<Request> GetAll()
        {

            DatabaseData = OrdersData.Get.All();
            return PrepareList();
        }

        public List<Request> GetByModel(string model)
        {
            
            DatabaseData = OrdersData.Get.ByMark(model);
            return PrepareList();
        }

        public List<Request> GetByMark(string mark)
        {

            DatabaseData = OrdersData.Get.ByMark(mark);
            return PrepareList();
        }
        

        public Request GetByID(int ID)
        {
            Request result;
            DatabaseData = OrdersData.Get.ById(ID);
            convertedData = ConvertToTable(DatabaseData);
            ReqBuff.ID = int.Parse(convertedData[0, 0]);
            ReqBuff.Model = convertedData[0, 1];
            ReqBuff.Owner = convertedData[0, 2];
            ReqBuff.Description = convertedData[0, 3];
            ReqBuff.ListOfParts = null;
            result = new Request(ReqBuff.ID, ReqBuff.Model, ReqBuff.Owner, ReqBuff.Description, ReqBuff.ListOfParts);
            return result;
        }

        private List<Request> PrepareList()
        {
            List<Request> result = new List<Request>();
            convertedData = ConvertToTable(DatabaseData);
            for (int i = 0; i < DatabaseData[0].Count(); i++)
            {
                ReqBuff.ID = int.Parse(convertedData[i, 0]);
                ReqBuff.Model = convertedData[i, 1];
                ReqBuff.Owner = convertedData[i, 2];
                ReqBuff.Description = convertedData[i, 3];
                ReqBuff.ListOfParts = null;
                result.Add(new Request(ReqBuff.ID, ReqBuff.Model, ReqBuff.Owner, ReqBuff.Description, ReqBuff.ListOfParts));
            }
            return result;
        }

        private string[,] ConvertToTable(List<string>[] tabelOfLists)
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
