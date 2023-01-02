using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class SingleButton : Button, IStyle, ILayoutOptions, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } = new GUIStyle(GUI.skin.button);

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            if (GUILayout.Button(Content, Style, LayoutOptions.ToArray()))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
