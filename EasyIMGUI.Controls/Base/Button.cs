using System;

namespace EasyIMGUI.Controls.Base
{
    public abstract class Button : Control
    {
        public event EventHandler OnButtonPressed;

        protected void Invoke_OnButtonPressed()
        {
            OnButtonPressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
