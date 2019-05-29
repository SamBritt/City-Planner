using System;

namespace Planner
{
    class Building
    {
        public Building(string _address){
            this._address = _address;
        }
        private string _designer = "Sam Britt";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public void Construct (){
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyer){
            _owner = buyer;
        }
        public string getDesigner(){
            return _designer;
        }
        public DateTime getBuildDate(){
            return _dateConstructed;
        }
        public string getOwner(){
            return _owner;
        }
        public string getAddress(){
            return _address;
        }
    }
}