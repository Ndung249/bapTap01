namespace Management
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Salary { get; set; }

        protected abstract double CalculateSalary();
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Ten Nhan Vien:  " + this.Name);
            Console.WriteLine("Ma Nhan Vien:  " + this.ID);
            Console.WriteLine("Luong co ban:  " + this.Salary);

        }
    }
}
