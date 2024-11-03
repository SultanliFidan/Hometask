namespace FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(@"C:\Users\User\Desktop\Hometask\FileStream\FileStream\Files\names.json");
            FileStream file = new FileStream(path);
            file.Add("Fidan");
            file.Add("Jale");

            Console.WriteLine(file.Exist("Fidan"));
            //file.Update(1, "Nezrin");
            //file.Delete(1);

        }
    }
}
