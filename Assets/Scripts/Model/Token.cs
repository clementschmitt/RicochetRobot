namespace Assets.Scripts.Model
{
    public class Token
    {
        public TokenColors Color { get; set; }
        public TokenShape Shape { get; set; }
    }

    public enum TokenColors
    {
        Red,
        Blue,
        Yellow,
        Green,
        Rainbow
    }

    public enum TokenShape
    {
        Moon,
        Star,
        Ring,
        Planet,
        Cyclon
    }
}