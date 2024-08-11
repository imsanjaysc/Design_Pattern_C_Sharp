namespace CommandDesignPattern
{
    // Command Interface
    // It declares a method for executing a command
    public interface ICommand
    {
        void Execute();
    }
}
/*
//Create an Instance of Receiver
using CommandDesignPattern;

Document document = new Document();
//Create the Command Object by passing the Receiver Instance
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);
//Create the Invoker instance by passing the command objects
MenuOptions menu = new MenuOptions(openCommand, saveCommand, closeCommand);
//Giving command to the Invoker to do the operation
menu.ClickOpen();
menu.ClickSave();
menu.ClickClose();
Console.ReadKey();
 */