﻿using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class ScrollView : NestedControl, IStyle, ILayoutOptions
    {
        public Vector2 Position { get; set; } = Vector2.zero;

        public GUIStyle Style { get; set; } // TODO

        public List<GUILayoutOption> LayoutOptions { get; set; } = new List<GUILayoutOption>();

        public override void Draw()
        {
            GUILayout.BeginScrollView(Position, LayoutOptions.ToArray());
            base.Draw();
            GUILayout.EndScrollView();
        }
    }
}
