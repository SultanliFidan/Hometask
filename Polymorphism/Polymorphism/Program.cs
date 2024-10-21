using Polymorphism.Interface;
using Polymorphism.Models;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITextEditor text = new Word();
            text.Write("salam");
            text.Save();
            text.SaveAndClose("fidan");
            ITextEditor word = new WordPad();
            word.Write("Necesen");
            word.Save();
            word.SaveAndClose("Ab108");
        }
    }
}
