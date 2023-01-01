using System;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public abstract class Control
    {
        public GUILayoutOption[] LayoutOptions { get; } = Array.Empty<GUILayoutOption>();
        public abstract void Draw();
    }
}
