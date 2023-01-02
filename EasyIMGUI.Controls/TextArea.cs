using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class TextArea : ValueControl<string>, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } = new GUIStyle(GUI.skin.textArea);

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();
        public int MaxLength { get; set; } = int.MaxValue;

        public override void Draw()
        {
            Value = GUILayout.TextArea(Value, MaxLength, Style, LayoutOptions.ToArray());
        }
    }
}
