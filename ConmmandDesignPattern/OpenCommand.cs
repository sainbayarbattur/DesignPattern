using System;
using System.Collections.Generic;
using System.Text;

namespace ConmmandDesignPattern
{
    public class OpenCommand : ICommand
    {
        private Document document;
        public OpenCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Open();
        }
    }
}
