using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    public abstract class Box : Control, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
