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
    }
}
