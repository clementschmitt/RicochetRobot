using Assets.Scripts.Model;

namespace Assets.ProjectResources.Prefabs.Default
{
    public class DefaultBoards
    {
        public static BoardPart GetDefaultNorthWestBoardRecto()
        {
            return new BoardPart(){
                Cells = new Cell[][]
                {
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                            HasRightWall = true,
                        },
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                             HasLeftWall = true,
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasBotWall = true,
                            HasRightWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Red,
                                Shape = TokenShape.Star
                            }
                        },
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                             HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasRightWall = true
                        },
                        new Cell()
                        {
                             HasLeftWall = true,
                             HasBotWall = true,
                             Token = new Token()
                             {
                                 Color = TokenColors.Green,
                                 Shape = TokenShape.Planet
                             }
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasBotWall = true
                        },
                        new Cell()
                        {
                            
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasBotWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        },
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasTopWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Yellow,
                                Shape = TokenShape.Ring
                            }
                        },
                        new Cell()
                        {
                            
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasTopWall = true, 
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasBotWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true,
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                            HasRightWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Blue,
                                Shape = TokenShape.Moon
                            }
                        },
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            HasBotWall = true
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                             HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasRightWall = true,
                            HasBotWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Rainbow,
                                Shape = TokenShape.Cyclon
                            }
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        },
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasTopWall = true
                        }
                    }
                },
                BoardPosition = BoardPosition.NorthWest
            };
        }
        public static BoardPart GetDefaultNorthEastBoardRecto()
        {
            return new BoardPart()
            {
                Cells = new Cell[][]
                {
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                            HasRightWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                        },
                        new Cell()
                        {
                            HasBotWall = true,
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                            HasRightWall = true
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasTopWall = true,
                            HasRightWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Green,
                                Shape = TokenShape.Ring
                            }
                        },
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            HasBotWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasRightWall = true
                        },
                        new Cell()
                        {
                             HasLeftWall = true,
                             HasTopWall = true,
                             Token = new Token()
                             {
                                 Color = TokenColors.Red,
                                 Shape = TokenShape.Moon
                             }
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            HasRightWall = true,
                            HasBotWall = true,
                        }
                    },
                    //-------------------------------------
                    new Cell[]
                    {
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasBotWall = true,
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasBotWall = true,
                            HasRightWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Blue,
                                Shape = TokenShape.Moon
                            }
                        },
                        new Cell()
                        {
                             HasLeftWall = true,
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasRightWall = true,
                        },
                        new Cell()
                        {
                            HasLeftWall = true,
                            HasBotWall = true,
                            Token = new Token()
                            {
                                Color = TokenColors.Yellow,
                                Shape = TokenShape.Star
                            }
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasTopWall = true,
                            HasRightWall = true
                        },
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    }
                },
                BoardPosition = BoardPosition.NorthEast
            };
        }
        //TODO END THIS : http://d4rian.free.fr/RicochetRobots/image011.png
        public static BoardPart GetDefaultSouthWestBoardRecto()
        {
            return new BoardPart()
            {

                Cells = new Cell[][]
                {
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            HasTopWall = true
                        },
                        new Cell()
                        {
                           
                        },
                        new Cell()
                        {
                           
                        },
                        new Cell()
                        {
                            HasRightWall = true
                        },
                        new Cell()
                        {
                            HasLeftWall = true
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    },
                    //-------------------------------------
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    },

                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    },
                    new Cell[]
                    {
                        new Cell()
                        {
                            HasLeftWall = true
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           
                        }
                    }
                },
                BoardPosition = BoardPosition.SouthWest
            };
        }

        public static BoardPart GetDefaultSouthEastBoardRecto()
        {
            return new BoardPart()
            {

                Cells = new Cell[][]
                {
                    new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    },new Cell[]
                    {
                        new Cell()
                        {
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {

                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                            
                        },
                        new Cell()
                        {
                           HasRightWall = true
                        }
                    }
                },
                BoardPosition = BoardPosition.SouthEast
            };
        }

        
    }
}
