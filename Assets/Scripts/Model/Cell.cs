using UnityEngine;

namespace Assets.Scripts.Model
{
    public class Cell
    {
        public bool HasTopWall { get; set; }
        public bool HasBotWall { get; set; }
        public bool HasLeftWall { get; set; }
        public bool HasRightWall { get; set; }

        public Token Token { get; set; }

        public Cell()
        {
            Token = null;
        }

        /// <summary>
        /// Init a cell
        /// </summary>
        /// <param name="walls">"UDLR" => 4 walls, "U" one wall etc.</param>
        /// <param name="t"></param>
        public Cell(string walls, Token t = null)
        {
            Token = t;
            walls = walls.ToUpperInvariant();
            if (!string.IsNullOrEmpty(walls))
            {
                if (walls.Contains("U"))
                    HasTopWall = true;

                if (walls.Contains("D"))
                    HasBotWall = true;

                if (walls.Contains("L"))
                    HasLeftWall = true;

                if (walls.Contains("R"))
                    HasRightWall = true;
            }
        }
    }
}