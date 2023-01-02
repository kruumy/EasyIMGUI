using System;
using UnityEngine;

namespace EasyIMGUI.Controls.Base
{
    public abstract class ButtonControl : Control, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
        public event EventHandler OnButtonPressed;
        private protected void Invoke_OnButtonPressed()
        {
            OnButtonPressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
