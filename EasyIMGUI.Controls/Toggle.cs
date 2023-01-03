﻿using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Toggle(bool, GUIContent, GUILayoutOption[])"/>.
    /// </summary>
    public class Toggle : ValueControl<bool>, IContent, IStyle, ILayoutOptions
    {
        public GUIContent Content { get; set; } = new GUIContent("");

        public GUIStyle Style { get; set; } = null;

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        public override void Draw()
        {
            if (Style != null) Value = GUILayout.Toggle(Value, Content, Style, LayoutOptions);
            else Value = GUILayout.Toggle(Value, Content, LayoutOptions);
        }
    }
}
