using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.TextField(string, int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class TextField : TextElement, ILayoutOptions
    {

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.TextField(Value, MaxLength, LayoutOptions);
        }
    }
}
