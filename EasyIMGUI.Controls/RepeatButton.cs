using EasyIMGUI.Controls.Base;
using System;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class RepeatButton : ContentAndValueControl<Action>
    {
        public override void Draw()
        {
            if (GUILayout.RepeatButton(Content))
            {
                Value.Invoke();
            }
        }
    }
}
