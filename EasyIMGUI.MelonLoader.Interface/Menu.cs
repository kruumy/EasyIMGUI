using EasyIMGUI.Controls.Base;
using MelonLoader;
using System.Collections.Generic;

namespace EasyIMGUI.MelonLoader.Interface
{
    public class Menu
    {
        public List<Control> Controls { get; } = new List<Control>();
        public bool IsOpen { get; private set; } = false;
        public void Open()
        {
            MelonEvents.OnGUI.Subscribe(Draw);
            IsOpen = true;
        }
        public void Close()
        {
            MelonEvents.OnGUI.Unsubscribe(Draw);
            IsOpen = false;
        }
        private void Draw()
        {
            Controls.ForEach(c => c.Draw());
        }
    }
}
