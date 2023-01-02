using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class SelectionGrid : ValueControl<int>, IContents, ILayoutOptions, IStyle
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();
        public int Width { get; set; } = 2;

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public GUIStyle Style { get; set; } // TODO

        public override void Draw()
        {
            Value = GUILayout.SelectionGrid(Value, Contents.ToArray(), Width, LayoutOptions.ToArray());
        }
    }
}
