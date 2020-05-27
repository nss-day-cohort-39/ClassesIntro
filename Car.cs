namespace ClassesIntro
{
    public class Car
    {
        // Private fields. Fields are very similar to properties, but are by convention private
        // and they don't have a getter and setter
        private int _milesDriven;

        private int _milesAtLastService;

        // Public properties
        public string Color { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Computed properties
        public string Description
        {
            get
            {
                return $"A {Year} {Color} {Make} {Model}";
            }
        }

        // Methods
        public void Drive(int miles)
        {
            _milesDriven += miles;
        }

        public int GetOdometer()
        {
            return _milesDriven;
        }

        public void Service()
        {
            _milesAtLastService = _milesDriven;
        }

        public int GetMaintenanceAtMileage()
        {
            return _milesAtLastService + 5_000;
        }

        // Constructor Method
        // Constructors don't have a return type and the name of the method is the same as the name of the class
        public Car(int year, int miles)
        {
            Year = year;
            _milesDriven = miles;
        }

    }
}