using EasyIMGUI.Controls.Base;
using System;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Button : Control, IContent, IValue<Action>
    {
        public Action Value { get; set; } = default;
        public GUIContent Content { get; set; } = GUIContent.none;
        public override void Draw()
        {
            if (GUILayout.Button(Content))
            {
                Value.Invoke();
            }
        }
    }
}
