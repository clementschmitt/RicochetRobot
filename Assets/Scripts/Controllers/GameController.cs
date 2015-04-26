using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private GameController _instance;

    public GameController Instance
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
	void Start () {
	    _instance = this;

        
	}
	
	// Update is called once per frame
	void Update () {

	}
}
