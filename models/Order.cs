using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newjaposha.models
{
    public class Order //Georgijs Katasevs
    {
        //needs tostring method
        public static int NextId = 1;
        #region Instance fields 
        private int _id;
        private List<Item> _ItemCatalog;
        //private DateTime _startTime;
        private bool _completed;
        private Customer _client;
        #endregion
        #region Constructor
        public Order() 
        {
            _id = NextId;
            NextId++;
            _ItemCatalog = new List<Item>();
            //_startTime = DateTime.Now;
        }
        #endregion
        #region Properties 
        public int Id { get { return _id; } set { _id = value; } }
        public List<Item> Contents { get { return _ItemCatalog; } }
        public bool Completed { get { return _completed; } set { _completed = value; } }
        public Customer Client { get { return _client; } set { _client = value; } }
        public double Price { 
            get 
            {
                double t=0;
                foreach (var I in Contents)
                {
                    t = t + I.Price;
                }
                return t;
            } 
        }
        public TimeSpan EstTime //Estimated time
        {
            get
            {
                TimeSpan t = TimeSpan.Zero;
                foreach (var I in Contents)
                {
                    t = t + I.EstimatedTime;
                }
                return t;
            }
        }
        public DateTime StartTime { get; set; }
        public DateTime FinihTime { get { return StartTime.Add(EstTime); } }
        #endregion
        #region Methodes
        public void AssignCustomer(Customer cust)
        {
            Client = cust;
        }
        public void AddItem(Item I)
        {
            Contents.Add(I);
        }
        public void RemoveItem(int ind)
        {
            Contents.Remove(Contents[ind]);
        }
        public void CancelOrder()
        {
            Contents.Clear();
        }
        #endregion
    }
}
