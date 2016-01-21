using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkshopManager.IPart;
using WorkshopManager.Models.IRequest;


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
        private OrdersTableAdapter ordersData = new OrdersTableAdapter(); //obsluga tabeli zadani
        private PartsTableAdapter partsData = new PartsTableAdapter();  //obsluga tabeli czesci
        private List<string>[] databaseData; //zmienna przechowujaca wynik zapytania do bazy danych
        private string[,] convertedData; //metoda konwertujaca tablice list bedaca wynikiem zapytania do bazy na tablice dwuwymiarowa
        private ReqData reqBuff; // zmienna przechowujaca dane dla zadania 
        private PartData partBuff; //zmienna przechowujaca zmienne dla czesci

        #region operacje dla request

        /// <summary>
        /// Funkcja zwraca wszystkie zadania znajdujace sie w bazie
        /// </summary>
        /// <returns>List<Requests></returns>
        List<Request> IRequestDatabaseAdapter.GetAll()
        {

            databaseData = ordersData.Get.All();
            return PrepareReqList();
        }
        
        /// <summary>
        /// Metoda zwraca wszystkie zlecenia ktore oparte sa o podany model samochodu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<Request> IRequestDatabaseAdapter.GetByModel(string model)
        {
            
            databaseData = ordersData.Get.ByMark(model);
            return PrepareReqList();
        }

        /// <summary>
        /// Metoda zwracajaca wszystkie zlecenia po marce samochodu
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        List<Request> IRequestDatabaseAdapter.GetByMark(string mark)
        {

            databaseData = ordersData.Get.ByMark(mark);
            return PrepareReqList();
        }
        
        /// <summary>
        /// Metoda zwraca zlecenie o podanym ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Request IRequestDatabaseAdapter.GetById(int id)
        {
            databaseData = ordersData.Get.ById(id);
            convertedData = ConvertToTable(databaseData);
            reqBuff.ID = int.Parse(convertedData[0, 0]);
            reqBuff.Model = convertedData[0, 1];
            reqBuff.Owner = convertedData[0, 2];
            reqBuff.Description = convertedData[0, 3];
            reqBuff.ListOfParts = PreparePartList(reqBuff.ID);
            IRequestWithIdAcces result = new Request(reqBuff.Model, reqBuff.Owner, reqBuff.Description, reqBuff.ListOfParts);
            result.SetId(reqBuff.ID);

            return (Request) result;
        }

        List<Request> IRequestDatabaseAdapter.GetByOwner(string owner)
        {
            databaseData = ordersData.Get.ByOwner(owner);
            return PrepareReqList();
        }

        // Funkcja pomocnicza ktora tworzy liste obiektow Request
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

                IRequestWithIdAcces newRequest = new Request(reqBuff.Model, reqBuff.Owner, reqBuff.Description, reqBuff.ListOfParts);
                newRequest.SetId(reqBuff.ID);
                result.Add((Request)newRequest);
            }
            return result;
        }
        /// <summary>
        /// Usuwa zadanie o podanym ID 
        /// </summary>
        /// <param name="id"></param>
        void IRequestDatabaseAdapter.DeleteById(int id)
        {

        }

        void IRequestDatabaseAdapter.UpdateById(int id)
        {

        }

        

        #endregion


        #region opracje dla Part

        /// <summary>
        /// pozwala na pobranie czesci o podanym ID
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        Part IPartsDatabaseAdapter.GetById(int id)
        {
            IPartWithIdAcces result;
            databaseData = ordersData.Get.ById(id);
            convertedData = ConvertToTable(databaseData);
            partBuff.ID = int.Parse(convertedData[0, 0]);
            partBuff.Name = convertedData[0, 1];
            partBuff.Price = double.Parse( convertedData[0, 2]);

            result = new Part(partBuff.Name, partBuff.Price);
            result.SetId(partBuff.ID);
            return (Part) result;
        }

        /// <summary>
        /// Pobiera liste wszystkich czesci znajdujacych sie w bazie
        /// </summary>
        /// <returns></returns>
        List<Part> IPartsDatabaseAdapter.GetAll()
        {

            databaseData = partsData.Get.All();
            return PreparePartList();
        }

        /// <summary>
        /// pobiera czesci o zadanej cenie
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        List<Part> IPartsDatabaseAdapter.GetByPrice(double price)
        {
            
            databaseData = partsData.Get.ByPrice(price);
            return PreparePartList();
        }

        /// <summary>
        /// pobranie czesci o podanych 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        List<Part> IPartsDatabaseAdapter.GetByName(string name)
        {

            databaseData = partsData.Get.ByName(name);
            return PreparePartList();
        }

        /// <summary>
        /// metoda pozwala na przygotowanie listy czsci n apodstawie danych otrzymanych z bazy
        /// </summary>
        /// <returns></returns>
        private List<Part> PreparePartList()
        {
            List<Part> result = new List<Part>();
            convertedData = ConvertToTable(databaseData);
            for (int i = 0; i < databaseData[0].Count(); i++)
            {
                partBuff.ID = int.Parse(convertedData[0, 0]);
                partBuff.Name = convertedData[0, 1];
                partBuff.Price = double.Parse(convertedData[0, 2]);

                IPartWithIdAcces newPart = new Part(partBuff.Name, partBuff.Price);
                newPart.SetId(partBuff.ID);
                result.Add( (Part)newPart);
            }
            return result;
        }

        /// <summary>
        /// Metoda pozwalajaca pobrac liste czesci przypisanych do danego zlecenia
        /// </summary>
        /// <param name="reqId"></param>
        /// <returns></returns>
        private List<Part> PreparePartList(int reqId)
        {
            databaseData = partsData.Get.PartsList(reqId);
            List<Part> result = new List<Part>();
            convertedData = ConvertToTable(databaseData);
            for (int i = 0; i < databaseData[0].Count(); i++)
            {
                partBuff.ID = int.Parse(convertedData[0, 0]);
                partBuff.Name = convertedData[0, 1];
                partBuff.Price = double.Parse(convertedData[0, 2]);

                IPartWithIdAcces newPart = new Part(partBuff.Name, partBuff.Price);
                newPart.SetId(partBuff.ID);
                result.Add((Part)newPart);
            }
            return result;
        }

        /// <summary>
        /// Usuwa zadanie z bazy po podanym id
        /// </summary>
        /// <param name="id"></param>
        void IPartsDatabaseAdapter.DeleteById(int id)
        {

        }

        void IPartsDatabaseAdapter.UpdateById(int id)
        {

        }
        #endregion 


        /// <summary>
        /// Funkcja pozwala na zmiane danych otrzymanych z bazy na tabice dwuwymiarowa
        /// </summary>
        /// <param name="tabelOfLists"></param>
        /// <returns></returns>
        private string[,] ConvertToTable(List<string>[] tabelOfLists)
        {
            int colCount = tabelOfLists.Length;
            int rowCount = tabelOfLists[0].Count;
            string[,] result = new String[colCount, rowCount];
            for (int i = 0; i < colCount; i++)
            {
                int j = 0;
                foreach (string data in tabelOfLists[i])
                {
                    result[i, j] = data;
                    j++;
                }

            }
            return result;

        }



    }
}
