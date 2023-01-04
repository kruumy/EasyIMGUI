﻿using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Box(GUIContent, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class Box : Shared.Box, ILayoutOptions
    {
        /// <inheritdoc/>

        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();
        /// <inheritdoc/>

        public override void Draw()
        {
            GUILayout.Box(Content, LayoutOptions);
        }
    }
}
