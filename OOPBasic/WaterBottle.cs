//Encapsulation => Class + Access Modifier
//Inheritance
//Polymorphism
//Abstraction

//Access Modifier => private, protected, internal, public

namespace OOP.Basic
{
    class WaterBottle
    {
        //Variable
        private double capacity;
        private string color;
        private double waterAmount;

        //Auto property
        public double Wigth { get; set; }

        //Property
        public double Capacity
        {
            get { return capacity; }
        }

        public string Color
        {
            get { return color; }
        }
        public double WaterAmount
        {
            get
            {
                return waterAmount;
            }
            private set
            {
                if (value <= capacity)
                    waterAmount = value;

            }
        }

        public WaterBottle(double capacity, string color)
        {
            this.capacity = capacity;
            this.color = color;
        }
        ~WaterBottle() { }
        public void AddWater(double amount)
        {
            if (WaterAmount + amount <= capacity)
                WaterAmount += amount;
        }
        public void ReleaseWater(double amount)
        {
            if (WaterAmount < amount)
                WaterAmount = 0;
            else
                WaterAmount -= amount;
        }
    }
}