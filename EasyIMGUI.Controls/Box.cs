using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Box : Control, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } // TODO

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            GUILayout.Box(Content, LayoutOptions.ToArray());
        }
    }
}
