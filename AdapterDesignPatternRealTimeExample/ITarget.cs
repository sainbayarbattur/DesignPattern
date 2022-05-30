using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPatternRealTimeExample
{
    public interface ITarget
    {
        string TranslateAndTellToOtherPerson(string words, string convertToWhichLanguage);
    }
}
