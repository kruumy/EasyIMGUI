using EasyIMGUI.Controls.Shared;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra
{
    public class SelectorItem : IContent
    {
        public Control Control { get; set; }
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
