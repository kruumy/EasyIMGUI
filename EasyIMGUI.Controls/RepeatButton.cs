using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.RepeatButton(GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class RepeatButton : Button, IContent, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

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
