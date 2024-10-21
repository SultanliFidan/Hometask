using Polymorphism.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    class NotePad : ITextEditor
    {
        private string _currentText;
        public string CurrentText { get { return _currentText; } }
        public void Open()
        {
            _currentText = "";
        }
        public void Write(string text)
        {
            _currentText += text;
        }
        public void Save()
        {
            Console.WriteLine($"Save olunacaq text : {CurrentText}");
        }
        public void SaveAndClose(string filename)
        {
            Console.WriteLine($"C:/Users/Desktop/{filename}.txt");
        }
    }
}
