using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class Label : Control, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
        public override void Draw()
        {
            GUILayout.Label(Content);
        }
    }
}
