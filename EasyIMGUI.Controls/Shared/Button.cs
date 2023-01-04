using EasyIMGUI.Controls.Shared.Base;
using EasyIMGUI.Controls.Shared.Interfaces;
using System;
using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    /// <summary>
    /// Base class for a button. Defines OnButtonPressed.
    /// If inheriting, invoke <see cref="Invoke_OnButtonPressed"/> on each a button press.
    /// </summary>
    public abstract class Button : Control, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
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
