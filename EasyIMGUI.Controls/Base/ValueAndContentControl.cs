using UnityEngine;

namespace EasyIMGUI.Controls.Base
{
    public abstract class ValueAndContentControl<T> : Control, IContent
    {
        public T Value { get; set; } = default;
        public GUIContent Content { get; set; } = GUIContent.none;
    }
}
