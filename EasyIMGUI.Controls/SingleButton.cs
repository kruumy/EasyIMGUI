using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Button(string, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class SingleButton : Button, IStyle, ILayoutOptions, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            bool isClicked;
            if (Style != null) isClicked = GUILayout.Button(Content, Style, LayoutOptions);
            else isClicked = GUILayout.Button(Content, LayoutOptions);
            if (isClicked) Invoke_OnButtonPressed();
        }
    }
}
