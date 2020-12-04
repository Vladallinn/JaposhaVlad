using newjaposha.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace newjaposha.Catalogs
{   //Andrei Sarbu
    public class ItemCatalog
    {
        private List<Item> _items;
        public ItemCatalog(string fileNam)
        {
            FileName = fileNam;
            _items = new List<Item>();
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
        public void AddItem(Item o) { _items.Add(o); Save(); }
        public void DeleteItem(Item o) { _items.Remove(o); Save(); }
        public Item SearchItem(int id)
        {
            foreach (Item o in _items)
            {
                if (o.Id == id) { return o; }
            }
            return null;
        }
        public void DisplayContent()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
        #endregion
        #region Json stuff
        public string FileName { get; set; }
        public string FilePath { get { return $@".\data\{FileName}.Json"; } }
        public void CreateFile()
        {
            File.Create(FilePath);
        }
        // Save load Methods need editing
        private void Save()
        {
            // JsonWriter.WriteToJson(_items, FilePath);
        }
        private void Load()
        {
            //    _items = JsonReader.ReadJsonitems(FilePath);
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
