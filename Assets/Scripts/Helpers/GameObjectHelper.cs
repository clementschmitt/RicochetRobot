using UnityEngine;

namespace Assets.Scripts.Helpers
{
    public class GameObjectHelper
    {

        /// <summary>
        /// Instanciate a preafb and put it into a container
        /// </summary>
        /// <param name="prefab"></param>
        /// <param name="container"></param>
        public static GameObject Instanciate(GameObject prefab, GameObject container)
        {
            GameObject gameObject = Object.Instantiate(prefab);
            gameObject.transform.SetParent(container.transform);
            return gameObject;
        }

    }
}
