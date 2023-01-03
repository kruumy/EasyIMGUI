﻿using EasyIMGUI.Controls.Extra.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class EasySelectionGrid : Selector, IStyle, ILayoutOptions
    {
        public GUIStyle Style { get; set; } // TODO

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        public int Width { get; set; } = 2;

        public override void Draw()
        {
            Value = GUILayout.SelectionGrid(Value, Items.Contents, Width, LayoutOptions);
            base.Draw();
        }
    }
}