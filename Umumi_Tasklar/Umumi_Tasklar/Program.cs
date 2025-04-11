namespace Umumi_Tasklar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://notes.io/wHCUh
            //Human classiniz olur--User class:
            Human human01 = new Human("Fexreddin", "Ehmedov", 20);
            Human human02 = new Human("Eli", "Elisadov", 18);
            Human human03 = new Human("Murad", "Baxshiliyev", 25);

            human01.ShowFullDate();
            human02.ShowFullDate();
            human03.ShowFullDate();
            human01.GetFullName();
            human02.GetFullName();
            human03.GetFullName();

            Console.WriteLine("UserName daxil edin: ");
            string username01 = Console.ReadLine();

            Console.WriteLine("Password daxil edin: ");
            string password01 = Console.ReadLine();
        }
    }
}
