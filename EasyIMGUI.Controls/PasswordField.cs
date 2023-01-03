using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.PasswordField(string, char, int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class PasswordField : TextElement, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public char MaskCharacter { get; set; } = '*';

        public override void Draw()
        {
            if (Style != null) Value = GUILayout.PasswordField(Value, MaskCharacter, MaxLength, Style, LayoutOptions);
            else Value = GUILayout.PasswordField(Value, MaskCharacter, MaxLength, LayoutOptions);
        }
    }
}
