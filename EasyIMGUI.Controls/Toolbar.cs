using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Toolbar : ValueControl<int>, IContents, IStyle, ILayoutOptions
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();

        public GUIStyle Style { get; set; } // TODO

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            Value = GUILayout.Toolbar(Value, Contents.ToArray(), LayoutOptions.ToArray());
        }
    }
}
