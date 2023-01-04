﻿using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Automatic
{
    /// <summary>
    /// A <see cref="Control"/> containing the implementation of <see cref="GUILayout.Button(string, GUIStyle, GUILayoutOption[])"/>.
    /// </summary>
    public class SingleButton : Shared.Button, ILayoutOptions
    {
        /// <inheritdoc/>
        public LayoutOptions LayoutOptions { get; set; } = new LayoutOptions();

        /// <inheritdoc/>

        public override void Draw()
        {
            if (GUILayout.Button(Content, LayoutOptions))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}
