using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toggle : ValueControl<bool>, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            Value = GUILayout.Toggle(Value, Content, LayoutOptions);
        }
    }
}
