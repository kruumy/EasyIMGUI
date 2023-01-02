using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.SelectionGrid(int, GUIContent[], int, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class SelectionGrid : ValueControl<int>, IContents, ILayoutOptions, IStyle
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();
        public int Width { get; set; } = 2;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public GUIStyle Style { get; set; } // TODO

        public override void Draw()
        {
            Value = GUILayout.SelectionGrid(Value, Contents.ToArray(), Width, LayoutOptions);
        }
    }
}
