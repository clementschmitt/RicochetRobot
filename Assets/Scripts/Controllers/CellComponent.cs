using Assets.Scripts.Model;
using UnityEngine;

namespace Assets.Scripts.Controllers
{
    public class CellComponent : MonoBehaviour
    {
        public Cell Cell { get; set; }
        public const string AssetName = "Cell";

        public GameObject TopWall;
        public GameObject BotWall;
        public GameObject RightWall;
        public GameObject LeftWall;


        // Use this for initialization
        void Start()
        {
            transform.position = Cell.Position;
            TopWall.SetActive(Cell.HasTopWall);
            BotWall.SetActive(Cell.HasBotWall);
            RightWall.SetActive(Cell.HasRightWall);
            LeftWall.SetActive(Cell.HasLeftWall);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
