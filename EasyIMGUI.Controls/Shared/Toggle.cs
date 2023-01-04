﻿using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    /// <summary>
    /// A base <see cref="Control"/> that represents a toggle.
    /// </summary>
    public abstract class Toggle : ValueControl<bool>, IContent
    {
        /// <inheritdoc/>
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
