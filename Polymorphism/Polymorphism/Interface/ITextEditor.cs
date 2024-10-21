using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Interface
{
     interface ITextEditor
    {
        void Open();
        void Write(string text);
        void Save();
        void SaveAndClose(string filename);
        public string CurrentText {  get; }
    }
}
