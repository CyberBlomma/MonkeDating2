using System.Collections.Generic;
using System;

namespace Monke
{
    public class SceneWrapper
    {
        public Scene[] scenes;
        public Dictionary<string, int> sceneMap;

        public void Init()
        {
            sceneMap = new Dictionary<string, int>();

            int i = 0;

            foreach (Scene scene in scenes)
            {
                sceneMap.Add(scene.name, i);

                i++;
            }
        }


        private int currentScene = 0;
        public void DrawScene()
        {
            scenes[0].Draw();
            scenes[0].dialogue[0].Draw();

        }

        //return an int from the SceneWrapper sceneMap pls :dorime:
        public static void ChangeScene(string nextScene)
        {
            Console.WriteLine(nextScene);
        }

    }
}
