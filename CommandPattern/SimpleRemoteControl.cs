﻿
namespace CommandPattern
{
    public class SimpleRemoteControl
    {
        ICommand slot;
        public void setCommand(ICommand command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.Execute();
        }
    }
}
