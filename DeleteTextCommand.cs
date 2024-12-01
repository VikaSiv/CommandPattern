using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class DeleteTextCommand : ICommand
    {
        private readonly TextEditor _editor;
        private readonly int _count;
        private string _deletedText;


        public DeleteTextCommand(TextEditor editor, int count)
        {
            _editor = editor;
            _count = count;
            _deletedText = string.Empty;
        }

        public void Execute()
        {
            if (_count > _editor.Text.Length)
            {
                _deletedText = _editor.Text;
            }
            else
            {
                _deletedText = _editor.Text.Substring(_editor.Text.Length - _count);
            }
            _editor.DeleteText(_count);
        }

        public void Undo()
        {
            _editor.InsertText(_deletedText);
        }
    }
}
