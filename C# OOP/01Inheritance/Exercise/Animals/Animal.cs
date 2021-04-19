namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        
        public string Name 
        { 
            get
            {
                return this.name;
            } 
            set
            {
                if (value == System.String.Empty)
                {
                    throw new System.ArgumentException("Invalid input");
                }

                this.name = value;
            } 
        }

        public int Age 
        { 
            get => this.age; 
            set
            {
                if (value <= 0)
                {
                    //throw new System.ArgumentException("Invalid input");
                    this.age = -1;
                }

                this.age = value;
            }
        }

        public string Gender 
        { 
            get => this.gender; 
            private set
            {
                if (value != "Male" && value != "Female")
                {
                    //throw new System.ArgumentException("Invalid input");
                    this.gender = System.String.Empty;
                }

                this.gender = value;
            } 
        }

        public abstract string ProduceSound();
    }
}
