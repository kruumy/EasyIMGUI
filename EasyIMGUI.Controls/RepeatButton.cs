using EasyIMGUI.Controls.Base;
using System;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class RepeatButton : ValueAndContentControl<Action>, IContent
    {
        public GUIContent Content { get; set; } = GUIContent.none;
        public override void Draw()
        {
            if (GUILayout.RepeatButton(Content))
            {
                Value.Invoke();
            }
        }
    }
}
