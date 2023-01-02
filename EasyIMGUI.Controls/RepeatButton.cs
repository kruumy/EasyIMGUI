using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class RepeatButton : Button, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (GUILayout.RepeatButton(Content, LayoutOptions))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
