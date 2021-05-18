using System.Reflection.Metadata.Ecma335;
using System;
using Raylib_cs;
namespace Monke
{
    public class Dialogue
    {

        public string type;
        public string content;
        public string[] characters;
        public DialogueOption[] dialogueOptions;

        public void Draw() {
            // System.Console.WriteLine(content);

            Raylib.DrawText(content, 100, 100, 50, Color.WHITE);
        }
    }

    public class DialogueOption {
        public string text;
        public string action;
    }
}
