using Assets.Scripts.Model;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class CellComponent : MonoBehaviour
    {
        public const string AssetName = "Cell";
        public Cell Cell { get; set; }
        public Transform ContentTransform;
        public GameObject TopWall;
        public GameObject BotWall;
        public GameObject RightWall;
        public GameObject LeftWall;
        public GameObject Floor;

        private BoardPosition _boardposition;

        public BoardPosition BoardPosition
        {
            get { return _boardposition; }
            set
            {
                _boardposition = value;
                switch (_boardposition)
                {
                    case BoardPosition.NorthWest:
                        ContentTransform.position = new Vector3(-.5f, 0f, .5f);
                        break;
                    case BoardPosition.NorthEast:
                        ContentTransform.position = new Vector3(.5f, 0f, .5f);
                        break;
                    case BoardPosition.SouthEast:
                        ContentTransform.position = new Vector3(.5f, 0, -.5f);
                        break;
                    case BoardPosition.SouthWest:
                        ContentTransform.position = new Vector3(-.5f, 0, -.5f);
                        break;
                }
            }
        }

        // Use this for initialization
        void Start()
        {
            TopWall.SetActive(Cell.HasTopWall);
            BotWall.SetActive(Cell.HasBotWall);
            RightWall.SetActive(Cell.HasRightWall);
            LeftWall.SetActive(Cell.HasLeftWall);
            Floor.tag = "Board";
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
