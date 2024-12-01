using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class TextEditor
    {
        public string Text { get; private set; } = string.Empty;

        public void InsertText(string text)
        {
            Text += text;
        }

        public void DeleteText(int count)
        {
            if (count > Text.Length)
            {
                Text = string.Empty;
            }
            else
            {
                Text = Text.Substring(0, Text.Length - count);
            }
        }
    }
}

