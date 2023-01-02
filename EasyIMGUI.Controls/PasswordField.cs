using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class PasswordField : TextElement, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public char MaskCharacter { get; set; } = '*';

        public override void Draw()
        {
            Value = GUILayout.PasswordField(Value, MaskCharacter, MaxLength, LayoutOptions);
        }
    }
}
