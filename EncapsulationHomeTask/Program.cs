namespace EncapsulationHomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Test", "password1");
            user.Age = -20;
            Console.WriteLine(user.UserName);
            Console.WriteLine(user.Age);

        }
    }
}