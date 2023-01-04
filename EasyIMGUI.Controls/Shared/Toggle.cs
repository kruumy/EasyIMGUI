using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    public abstract class Toggle : ValueControl<bool>, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
