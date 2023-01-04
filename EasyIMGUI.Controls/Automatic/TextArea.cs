using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.TextArea(string, int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class TextArea : Shared.TextControl, ILayoutOptions
    {

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public override void Draw()
        {
            Value = GUILayout.TextArea(Value, MaxLength, LayoutOptions);
        }
    }
}
