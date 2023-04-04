using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class GarageDoorOpenCommand : ICommand
    {
        public GarageDoor garageDoor { get; set; }

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }

        public void Undo()
        {
            garageDoor.Down();
        }
    }

    public class GarageDoorCloseCommand : ICommand
    {
        public GarageDoor garageDoor { get; set; }

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.Up();
        }
    }
}
