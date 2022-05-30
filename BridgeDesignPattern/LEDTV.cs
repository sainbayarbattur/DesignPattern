using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDesignPattern
{
    public interface LEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}
