using EasyIMGUI.Controls.Shared.Base;
using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    public abstract class Toggle : ValueControl<bool>, IContent
    {
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
