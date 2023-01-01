using System;
using UnityEngine;

namespace EasyIMGUI.Controls.Base
{
    public abstract class SelectionControl : Control, IValue<int>, IContents
    {
        public GUIContent[] Contents { get; set; } = Array.Empty<GUIContent>();
        public int Value { get; set; } = 0;
    }
}