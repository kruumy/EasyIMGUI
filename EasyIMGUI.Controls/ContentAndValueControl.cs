using UnityEngine;

namespace EasyIMGUI.Controls
{
    public abstract class ContentAndValueControl<T> : Control
    {
        public GUIContent Content { get; set; } = GUIContent.none;
        public T Value { get; set; } = default;
    }
}
