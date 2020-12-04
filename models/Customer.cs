using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newjaposha.Catalogs;

namespace newjaposha.models
{
    public class Customer //Georgijs Katasevs
    {
        // need to add order catalog, maybe tostring method
        public static int NextId = 1;
        #region Instance fields 
        private int _id;
        private string _name;
        private string _adress;
        private string _phone;
        private string _email;
        private OrderCatalog _orders;
        #endregion
        #region Constructor
        public Customer(string nam,string adr,string ph,string email )
        {
            _id=NextId;
            NextId++;
            _name=nam;
            _adress=adr;
            _email=email;
            _phone=ph;
            _orders = new OrderCatalog($"{Id}{Name}");
        }
        #endregion
        #region Properties 
        public int Id { get{ return _id;} }
        public string Name { get{ return _name;} set {_name=value; Orders.RenameFile($"{Id}{Name}"); } }
        public string Adress { get{ return _adress;}set {_adress=value;} }
        public string Email { get{ return _phone;} set {_phone=value;} }
        public string Phone { get{ return _email;}  set {_email=value;} }
        #endregion
        public OrderCatalog Orders { get { return _orders; } }
        #region Methodes
        #endregion
    }
}
