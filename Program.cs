using CommandPattern;
using System;

namespace CommandPatternTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();
            var commandManager = new CommandManager();

            Console.WriteLine("Начальное состояние текста: " + editor.Text);

            var insertCommand1 = new InsertTextCommand(editor, "Hello");
            var insertCommand2 = new InsertTextCommand(editor, ", World!");
            commandManager.ExecuteCommand(insertCommand1);
            commandManager.ExecuteCommand(insertCommand2);
            Console.WriteLine("После вставки текста: " + editor.Text);

            var deleteCommand = new DeleteTextCommand(editor, 7);
            commandManager.ExecuteCommand(deleteCommand);
            Console.WriteLine("После удаления текста: " + editor.Text);

            commandManager.UndoLastCommand();
            Console.WriteLine("После отмены удаления: " + editor.Text);

            commandManager.UndoLastCommand();
            commandManager.UndoLastCommand();
            Console.WriteLine("После отмены всех вставок: " + editor.Text);
        }
    }
}

