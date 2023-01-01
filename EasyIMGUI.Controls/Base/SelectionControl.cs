using System;
using UnityEngine;

namespace EasyIMGUI.Controls.Base
{
    public abstract class SelectionControl : ValueControl<int>, IContents
    {
        public GUIContent[] Contents { get; set; } = Array.Empty<GUIContent>();
    }
}