using UnityEngine;

namespace EasyIMGUI.Controls.Base
{
    public abstract class ContentAndValueControl<T> : Control, IContent, IValue<T>
    {
        public T Value { get; set; } = default;
        public GUIContent Content { get; set; } = GUIContent.none;
    }
}
