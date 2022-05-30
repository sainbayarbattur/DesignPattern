using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPatternRealTimeExample
{
    public interface IFrenchSpeaker
    {
        string AskQuestion(string Words);
        string AnswerFortheQuestion(string Words);
    }
}
