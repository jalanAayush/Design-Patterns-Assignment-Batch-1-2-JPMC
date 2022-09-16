namespace DesignPatternAssignment.Builder
{
    public class Computer
    {
        private string _computerType;
        private Dictionary<object, object> _computerParts = new Dictionary<object, object>();

        public Computer(string computerType)
        {
            this._computerType = computerType;
        }

        public string this[string key]
        {
            get { return (string)_computerParts[key]; }
            set { _computerParts[key] = value; }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Computer Type : " + this._computerType);
            Console.WriteLine(" Hard Disk : " + this._computerParts["hardDisk"]);
            Console.WriteLine(" Mother Board : " + this._computerParts["motherboard"]);
            Console.WriteLine(" Processor : " + this._computerParts["processor"]);
            Console.WriteLine(" Screen : " + this._computerParts["screen"]);
        }
    }
}
