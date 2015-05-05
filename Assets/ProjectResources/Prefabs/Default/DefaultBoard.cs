using Assets.Scripts.Model;

namespace Assets.ProjectResources.Prefabs.Default
{
    public class DefaultBoards
    {
        public static BoardPart GetDefaultNorthWestBoardRecto()
        {
            return new BoardPart
            {
                Cells = new[]
                {
                    new[]
                    {
                        new Cell("UL"),
                        new Cell("U"),
                        new Cell("U"),
                        new Cell("U"),
                        new Cell("UR"),
                        new Cell("UL"),
                        new Cell("U"),
                        new Cell("U")
                    },
                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell("DR",new Token{Color = TokenColors.Red,Shape = TokenShape.Star}),
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell()
                    },
                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell()
                    },
                    new[]
                    {
                        new Cell("LR"),
                        new Cell("LD", new Token{Color = TokenColors.Green, Shape = TokenShape.Planet}),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("D"),
                        new Cell()
                    },
                    new[]
                    {
                        new Cell("LD"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R"),
                        new Cell("LU",new Token{Color = TokenColors.Yellow,Shape = TokenShape.Ring}),
                        new Cell()
                    },
                    new[]
                    {
                        new Cell("LU"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("D"),
                        new Cell(),
                        new Cell()
                    },
                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("UR",new Token{Color = TokenColors.Blue,Shape = TokenShape.Moon}),
                        new Cell("L"),
                        new Cell("D")
                    },
                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell("RD",new Token{Color = TokenColors.Rainbow,Shape = TokenShape.Cyclon}),
                        new Cell("L"),
                        new Cell(),
                        new Cell("R"),
                        new Cell("LU"),
                    }
                },
                BoardPosition = BoardPosition.NorthWest
            };
        }
        public static BoardPart GetDefaultNorthEastBoardRecto()
        {
            return new BoardPart
            {
                Cells = new[]
                {
                    new[]
                    {
                        new Cell("U"),
                        new Cell("RU"),
                        new Cell("LU"),
                        new Cell("U"),
                        new Cell("U"),
                        new Cell("UD"),
                        new Cell("U"),
                        new Cell("UR"),
                    },

                    new[]
                    {
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("UR",new Token{Color = TokenColors.Green,Shape = TokenShape.Ring}),
                        new Cell("L"),
                        new Cell("R"),
                    },

                    new[]
                    {
                        new Cell(),
                        new Cell("D"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R")
                    },

                    new[]
                    {
                        new Cell("R"),
                        new Cell("LU",new Token{Color = TokenColors.Red,Shape = TokenShape.Moon}),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R")
                    },

                    new[]
                    {
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("RD")
                    },

                    new[]
                    {
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("UR")
                    },

                    new[]
                    {
                        new Cell("D"),
                        new Cell(),
                        new Cell("DR",new Token{Color = TokenColors.Blue,Shape = TokenShape.Moon}),
                        new Cell("L"),
                        new Cell(),
                        new Cell("R"),
                        new Cell("LD",new Token{Color = TokenColors.Yellow,Shape = TokenShape.Star}),
                        new Cell("R")
                    },
                    new[]
                    {
                        new Cell("UR"),
                        new Cell("L"),
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("U"),
                        new Cell("R")
                    }
                },
                BoardPosition = BoardPosition.NorthEast
            };
        }
        //TODO END THIS : http://d4rian.free.fr/RicochetRobots/image011.png
        public static BoardPart GetDefaultSouthWestBoardRecto()
        {
            return new BoardPart
            {

                Cells = new[]
                {
                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell("R"),
                        new Cell("LD")
                    },

                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell("DR", new Token(){Color = TokenColors.Blue,Shape = TokenShape.Ring}),
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell("U")
                    },

                   new[]
                    {
                        new Cell("LD"),
                        new Cell(),
                        new Cell(),
                        new Cell("U"),
                        new Cell(),
                        new Cell("D"),
                        new Cell(),
                        new Cell()
                    },

                    new[]
                    {
                        new Cell("LU"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R"),
                        new Cell("LU", new Token{Color = TokenColors.Red,Shape = TokenShape.Planet}),
                        new Cell(),
                        new Cell()
                    },

                    new[]
                    {
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell()
                    },

                    new[]
                    {
                        new Cell("LR"),
                        new Cell("LD", new Token{Color = TokenColors.Yellow,Shape = TokenShape.Moon}),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("D"),
                        new Cell()
                    },
                    new[]
                    {
                        new Cell("L"),
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("UR", new Token{Color = TokenColors.Green,Shape = TokenShape.Star}),
                        new Cell("L")
                    },
                    new[]
                    {
                        new Cell("DL"),
                        new Cell("D"),
                        new Cell("D"),
                        new Cell("D"),
                        new Cell("DR"),
                        new Cell("DL"),
                        new Cell("D"),
                        new Cell("D"),
                    },
                },
                BoardPosition = BoardPosition.SouthWest
            };
        }

        public static BoardPart GetDefaultSouthEastBoardRecto()
        {
            return new BoardPart
            {

                Cells = new[]
                {
                    new[]
                    {
                        new Cell("DR"),
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R")
                    },
                    new[]
                    {
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("RD")
                    },
                    new[]
                    {
                        new Cell("DR", new Token{Color = TokenColors.Yellow,Shape = TokenShape.Planet}),
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("D"),
                        new Cell(),
                        new Cell("RU")
                    },
                    new[]
                    {
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R"),
                        new Cell("UL",new Token{Color = TokenColors.Blue,Shape = TokenShape.Star}),
                        new Cell(),
                        new Cell("R")
                    },
                    new[]
                    {
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("R")
                    },
                    new[]
                    {
                        new Cell(),
                        new Cell("DR",new Token{Color = TokenColors.Green,Shape = TokenShape.Moon}),
                        new Cell("L"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("D"),
                        new Cell("R")
                    },
                    new[]
                    {
                        new Cell(),
                        new Cell("U"),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell(),
                        new Cell("RU",new Token{Color = TokenColors.Red,Shape = TokenShape.Ring}),
                        new Cell("RL")
                    },
                    new[]
                    {
                        new Cell("D"),
                        new Cell("D"),
                        new Cell("D"),
                        new Cell("DR"),
                        new Cell("DL"),
                        new Cell("D"),
                        new Cell("D"),
                        new Cell("DR")
                    },
                },
                BoardPosition = BoardPosition.SouthEast
            };
        }


    }
}
