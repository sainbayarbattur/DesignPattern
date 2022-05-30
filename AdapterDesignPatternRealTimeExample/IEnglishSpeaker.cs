using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPatternRealTimeExample
{
    public interface IEnglishSpeaker
    {
        string AskQuestion(string Words);
        string AnswerFortheQuestion(string Words);
    }
}
