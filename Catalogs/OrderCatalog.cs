using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newjaposha.models;
using System.IO;
using newjaposha.JsonHelpers;

namespace newjaposha.Catalogs
{
    public class OrderCatalog
    {
        //Georgijs Katasevs
        List<Order> _orders;
        public OrderCatalog(string fileNam)
        {
            FileName = fileNam;
            _orders = new List<Order>();
            if (File.Exists(FilePath) == false)
            {
                File.Create(FilePath);
            }
            else 
            {
                Load();
            }
        }
        #region Methodes
        public void AddOrder(Order o) { _orders.Add(o); Save(); }
        public void DeleteOrder(Order o) { _orders.Remove(o); Save(); }
        public Order SearchOrder(int id)
        {
            foreach (Order o in _orders)
            {
                if (o.Id == id) { return o; }
            }
            return new Order();
        }
        public void DisplayContent()
        {
            foreach (var item in _orders)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region Json stuff
        public string FileName { get; set; }
        public string FilePath { get { return $@".\data\{FileName}.Json";} }
        public void CreateFile()
        {
            File.Create(FilePath);
        }
        private void Save()
        {
            JsonWriter.WriteToJson(_orders, FilePath);
        }
        private void Load()
        {
            _orders = JsonReader.ReadJsonOrders(FilePath);
        }
        public void RenameFile(string newName)
        {
            string old = FilePath;
            FileName = newName;
            string n = FilePath;
            File.Move(old, n);
        }
        #endregion
    }
}
