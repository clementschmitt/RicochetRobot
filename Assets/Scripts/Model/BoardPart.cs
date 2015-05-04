namespace Assets.Scripts.Model
{
    public class BoardPart{

        public Cell[][] Cells { get; set; }
        public BoardPosition BoardPosition { get; set; }
    }

    public enum BoardPosition
    {
        NorthWest,
        NorthEast,
        SouthWest,
        SouthEast
    }
}
