using System;
using System.Collections.Generic;
using System.Text;

namespace ConmmandDesignPattern
{
    class CloseCommand : ICommand
    {
        private Document document;
        public CloseCommand(Document doc)
        {
            document = doc;
        }
        public void Execute()
        {
            document.Close();
        }
    }
}
