using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.TextArea(string, int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class TextArea : TextElement, ILayoutOptions
    {

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public override void Draw()
        {
            Value = GUILayout.TextArea(Value, MaxLength, LayoutOptions);
        }
    }
}
