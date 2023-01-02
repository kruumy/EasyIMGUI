using System;

namespace EasyIMGUI.Controls.Base
{
    /// <summary>
    /// Base class for a button. Defines OnButtonPressed.
    /// If inheriting, invoke <see cref="Invoke_OnButtonPressed"/> on each a button press.
    /// </summary>
    public abstract class Button : Control
    {
        /// <summary>
        /// Invoked on every button press.
        /// </summary>
        public event EventHandler OnButtonPressed;
        /// <summary>
        /// Invoked <see cref="Invoke_OnButtonPressed"/> to invoke <see cref="OnButtonPressed"/>.
        /// </summary>
        private protected void Invoke_OnButtonPressed()
        {
            OnButtonPressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
