using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WorkshopManager.DatabasePresenter

{
    using SqlDatabase;
    struct ReqData
    {
        public int ID;
        public string Model;
        public string Owner;
        public string Description;
        public List<Part> ListOfParts;
    }
    struct PartData
    {
        public int ID;
        public string Name;
        public double Price;
    }

    class DatabasePresenter : IPartsDatabaseAdapter, IRequestDatabaseAdapter
    {
        private OrdersTableAdapter ordersData = new OrdersTableAdapter();
        private PartsTableAdapter partsData = new PartsTableAdapter();
        private List<string>[] databaseData;
        private string[,] convertedData;
        private ReqData reqBuff;
        private PartData partBuff;

        #region operacje dla request
        public List<Request> GetAll()
        {

            databaseData = ordersData.Get.All();
            return PrepareReqList();
        }

        public List<Request> GetByModel(string model)
        {
            
            databaseData = ordersData.Get.ByMark(model);
            return PrepareReqList();
        }

        public List<Request> GetByMark(string mark)
        {

            databaseData = ordersData.Get.ByMark(mark);
            return PrepareReqList();
        }
        

        public Request GetByID(int ID)
        {
            Request result;
            databaseData = ordersData.Get.ById(ID);
            convertedData = ConvertToTable(databaseData);
            reqBuff.ID = int.Parse(convertedData[0, 0]);
            reqBuff.Model = convertedData[0, 1];
            reqBuff.Owner = convertedData[0, 2];
            reqBuff.Description = convertedData[0, 3];
            reqBuff.ListOfParts = null;
            result = new Request(reqBuff.ID, reqBuff.Model, reqBuff.Owner, reqBuff.Description, reqBuff.ListOfParts);
            return result;
        }

        private List<Request> PrepareReqList()
        {
            List<Request> result = new List<Request>();
            convertedData = ConvertToTable(databaseData);
            for (int i = 0; i < databaseData[0].Count(); i++)
            {
                reqBuff.ID = int.Parse(convertedData[i, 0]);
                reqBuff.Model = convertedData[i, 1];
                reqBuff.Owner = convertedData[i, 2];
                reqBuff.Description = convertedData[i, 3];
                reqBuff.ListOfParts = null;
                result.Add(new Request(reqBuff.ID, reqBuff.Model, reqBuff.Owner, reqBuff.Description, reqBuff.ListOfParts));
            }
            return result;
        }
        #endregion

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
        #region opracje dla Part
        public Part GetByID(int ID)
        {
            Part result;
            databaseData = ordersData.Get.ById(ID);
            convertedData = ConvertToTable(databaseData);
            partBuff.ID = int.Parse(convertedData[0, 0]);
            partBuff.Name = convertedData[0, 1];
            partBuff.Price = double.Parse( convertedData[0, 2]);
            result = new Part(partBuff.ID, partBuff.Name, partBuff.Price);
            return result;
        }

        public List<Request> GetAll()
        {

            databaseData = ordersData.Get.All();
            return PrepareReqList();
        }

        public List<Request> GetByModel(string model)
        {

            databaseData = ordersData.Get.ByMark(model);
            return PrepareReqList();
        }

        public List<Request> GetByMark(string mark)
        {

            databaseData = ordersData.Get.ByMark(mark);
            return PrepareReqList();
        }

        private List<Part> PreparePartList()
        {
            List<Part> result = new List<Part>();
            convertedData = ConvertToTable(databaseData);
            for (int i = 0; i < databaseData[0].Count(); i++)
            {
                partBuff.ID = int.Parse(convertedData[0, 0]);
                partBuff.Name = convertedData[0, 1];
                partBuff.Price = double.Parse(convertedData[0, 2]);
                result.Add(new Part(partBuff.ID, partBuff.Name, partBuff.Price));
            }
            return result;
        }
        #endregion 

        void DeleteReqById(int id)
        {

        }

        void UpdateReqById(int id)
        {

        }
        void DeleteParById(int id)
        {

        }

        void UpdateParById(int id)
        {

        }


    }
}
