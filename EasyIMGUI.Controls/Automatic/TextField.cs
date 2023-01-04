using EasyIMGUI.Controls.Interfaces;
using EasyIMGUI.Controls.Shared.Base;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.TextField(string, int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class TextField : Shared.TextControl, ILayoutOptions
    {
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.TextField(Value, MaxLength, LayoutOptions);
        }
    }
}
