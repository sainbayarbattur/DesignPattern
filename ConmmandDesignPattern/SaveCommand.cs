using System;
using System.Collections.Generic;
using System.Text;

namespace ConmmandDesignPattern
{
    class SaveCommand : ICommand
    {
        private Document document;
        public SaveCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Save();
        }
    }
}
