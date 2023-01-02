using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class SingleButton : Button, IStyle, ILayoutOptions, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (GUILayout.Button(Content, LayoutOptions))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
