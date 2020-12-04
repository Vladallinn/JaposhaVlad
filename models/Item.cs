using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newjaposha.models
{
    public class Item //Georgijs Katasevs
    {
        //needs tostring method
        //Maybe needs coment function and mayve quantity function
        public static int NextId = 1;
        #region Instance fields 
        private int _id;
        private string _name;
        private double _price;
        private TimeSpan _estimatedTime;
        #endregion
        #region Constructor
        public Item(string nam, double pris)
        {
            _id=NextId;
            NextId++;
            _name=nam;
            _price=pris;
        }
        #endregion
        #region Properties 
        public int Id { get{ return _id;} set {_id=value;} }
        public string Name { get{ return _name;} set {_name=value;} }
        public double Price{ get{ return _price;} set {_price=value;} }
        public TimeSpan EstimatedTime{ get{ return _estimatedTime;} set {_estimatedTime=value;} }
        #endregion
        #region Methodes
        #endregion
    }
}
