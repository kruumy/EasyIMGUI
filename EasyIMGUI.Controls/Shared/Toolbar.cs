using EasyIMGUI.Controls.Shared.Base;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls.Shared
{
    public abstract class Toolbar : ValueControl<int>
    {
        public List<GUIContent> Contents { get; set; } = new List<GUIContent>();
    }
}
