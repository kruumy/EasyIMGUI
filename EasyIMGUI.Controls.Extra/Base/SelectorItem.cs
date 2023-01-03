using EasyIMGUI.Controls.Base;
using EasyIMGUI.Controls.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra.Base
{
    public class SelectorItem : IContent
    {
        public Control Control { get; set; }
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
