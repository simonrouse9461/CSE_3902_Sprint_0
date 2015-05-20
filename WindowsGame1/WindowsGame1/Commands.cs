namespace WindowsGame1
{
    public class AnimateCommand : ICommand
    {
        private Game1 myGame;

        public AnimateCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.objSprite = new AnimatedSprite();
        }
    }

    public class MoveCommand : ICommand
    {
        private Game1 myGame;

        public MoveCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.objSprite = new MovedSprite();
        }
    }

    public class AnimateMoveCommand : ICommand
    {
        private Game1 myGame;

        public AnimateMoveCommand(Game1 game)
        {
            myGame = game;
        }

        public void Execute()
        {
            myGame.objSprite = new AnimatedMovedSprite();
        }
    }
}