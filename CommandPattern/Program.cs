using CommandPattern;

RemoteControl remoteControl = new RemoteControl();
Light light = new Light();
GarageDoor garageDoor = new GarageDoor();



remoteControl.SetCommand(0, new LightOnCommand(light), new LightOffCommand(light));
remoteControl.SetCommand(1, new GarageDoorOpenCommand(garageDoor), new GarageDoorCloseCommand(garageDoor));

Console.WriteLine(remoteControl.ToString());

remoteControl.OnButtonWasPushed(0);
remoteControl.OffButtonWasPushed(0);
remoteControl.OnButtonWasPushed(1);
remoteControl.OffButtonWasPushed(1);

remoteControl.undoButtonWasPushed();





//SimpleRemoteControl remote = new SimpleRemoteControl();
//Light light = new Light();
//GarageDoor garageDoor = new GarageDoor();
//remote.setCommand(new LightOnCommand(light));
//remote.buttonWasPressed();
//remote.setCommand(new GarageDoorCloseCommand(garageDoor));
//remote.buttonWasPressed();
Console.ReadLine();
