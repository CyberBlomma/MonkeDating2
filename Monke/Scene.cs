using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Monke
{
    public class Scene
    {
        public string name;
        public Texture2D background;
        public string backgroundPath;
        public List<string> children = new List<string>();

        public List<Dialogue> dialogue = new List<Dialogue>();

        private int dialogueIndex = 0;
        private bool loaded = false;

        public void Init()
        {
            background = Raylib.LoadTexture(backgroundPath);

            loaded = true;
        }


        public void Draw() {
            
            if (!loaded) {
                Init();
            }
            
            Raylib.ClearBackground(Color.BLANK);
    
            Raylib.DrawTexture(background, 0, 0, Color.WHITE);


        }

        public void StartDialogue(int index) {

        }

    }
}
