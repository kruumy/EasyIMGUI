using EasyIMGUI.Controls.Interfaces;
using EasyIMGUI.Controls.Shared.Base;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Label(GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class Label : Shared.Label, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            GUILayout.Label(Content, LayoutOptions);
        }
    }
}
