﻿using EasyIMGUI.Controls.Base;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    public class HorizontalScrollBar : ScrollbarControl
    {
        public override void Draw()
        {
            Value = GUILayout.HorizontalScrollbar(Value, Size, Minimum, Maximim);
        }
    }
}
