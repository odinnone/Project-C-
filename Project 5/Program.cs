Console.WriteLine("Write your name");
string username = Console.ReadLine();

if (username.ToLower() == "vlad") 
{
    Console.WriteLine("Oops... Vlad");
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}