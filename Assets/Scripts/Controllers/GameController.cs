using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Model;
using Assets.Scripts.Helpers;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class GameController : MonoBehaviour
    {

        private static GameController _instance;

        public static GameController Instance
        {
            get
            {
                if (_instance == null)
                {
                    Debug.LogError("Controller isn't instaciated yet");
                    return null;
                }

                return _instance;
            }
        }

        // Use this for initialization
        IEnumerator Start()
        {
            _instance = this;
            yield break;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
