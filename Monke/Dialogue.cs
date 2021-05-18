using System.Reflection.Metadata.Ecma335;
using System;
using Raylib_cs;
namespace Monke {
    public class Dialogue {

        public string type;
        public DialogueBox dialogueBox;
        public string content;
        public string[] characters;
        public DialogueOption[] dialogueOptions;

        public Dialogue() {

        }

        public void Draw() {
            //Raylib.DrawText(content, 100, 100, 50, Color.WHITE);

            //Draw text

            //Hold for user input

            if (dialogueOptions.Length > 0) {
                //Display dialogue options
            } else {
                //Just wait for user input to display next dialogue
            }


            dialogueOptions[0].Action("test");
        }

    }

    public class DialogueOption {
        public string text;
        public string action;

        public delegate void onAction(string action);
        public onAction Action;

        public DialogueOption() {
            Action = ChangeSceneDelegate;
        }

        private static void ChangeSceneDelegate(string action) {
            SceneWrapper.ChangeScene(action);
        }
    }

    public class DialogueBox {
        public Rectangle box;
        public (int x, int y) size;

        public DialogueBox(string content, int height, int width) {

        }

        public void Draw() {

        }
    }

    //public enum AlignmentOptions {
        
    //}
}
