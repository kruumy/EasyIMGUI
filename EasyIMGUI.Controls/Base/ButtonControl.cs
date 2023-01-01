using System;
using UnityEngine;

namespace EasyIMGUI.Controls.Base
{
    public abstract class ButtonControl : Control, IContent
    {
        public GUIContent Content { get; set; } = GUIContent.none;
        public event EventHandler OnButtonPressed;
        private void Invoke_OnButtonPressed()
        {
            OnButtonPressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
