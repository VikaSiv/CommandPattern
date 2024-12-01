using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class InsertTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly string _textToInsert;

        public InsertTextCommand(TextEditor editor, string text)
        {
            _editor = editor;
            _textToInsert = text;
        }

        public void Execute()
        {
            _editor.InsertText(_textToInsert);
        }

        public void Undo()
        {
            _editor.DeleteText(_textToInsert.Length);
        }
    }
}

