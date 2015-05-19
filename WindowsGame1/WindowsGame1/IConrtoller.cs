using Microsoft.Xna.Framework.Input;

namespace WindowsGame1
{
    public interface IController
    {
        void RegisterCommand(Keys key, ICommand command);
        void Update();
    }
}
