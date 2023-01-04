using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    /// <summary>
    /// A base <see cref="Control"/> that represents a label.
    /// </summary>
    public abstract class Label : Control, IContent
    {
        /// <inheritdoc/>
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
