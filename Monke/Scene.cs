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
            
            // Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLANK);
    
            Raylib.DrawTexture(background, 0, 0, Color.WHITE);

            // Raylib.EndDrawing();

        }

        public void Conversation() {
            


        }

    }
}
