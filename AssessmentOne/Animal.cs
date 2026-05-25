namespace AssessmentOne
{
    public class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
    public class Bird : Animal
    {
        //public override void Speak()
        //{
        //    Console.WriteLine($"{Name} says: Tweet!");
        //}
        public new void Speak()
        {
            Console.WriteLine($"{Name} says: Tweet!");
        }
    }
}
