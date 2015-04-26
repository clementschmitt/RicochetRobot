using UnityEngine;

namespace Assets.Scripts.Model
{
    public class Cell
    {
        public Vector2 Position { get; set; }

        public bool HasTopWall { get; set; }
        public bool HasBotWall { get; set; }
        public bool HasLeftWall { get; set; }
        public bool HasRightWall { get; set; }
    }
}