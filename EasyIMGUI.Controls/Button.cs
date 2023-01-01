using System;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Button : ContentAndValueControl<Action>
    {
        public override void Draw()
        {
            if (GUILayout.Button(Content, LayoutOptions))
            {
                Value.Invoke();
            }
        }
    }
}
