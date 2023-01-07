﻿using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Fixed
{
    public class RepeatButton : Shared.Button, IDimensions
    {
        /// <inheritdoc/>
        public Rect Dimensions { get; set; } = new Rect(0, 0, 0, 0);

        /// <inheritdoc/>
        public override void Draw()
        {
            if (GUI.RepeatButton(Dimensions, Content))
            {
                Invoke_OnButtonPressed();
            }
        }
    }
}