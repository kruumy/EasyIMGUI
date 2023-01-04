﻿using EasyIMGUI.Controls.Shared.Base;
using EasyIMGUI.Controls.Shared.Interfaces;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra.Base
{
    public class SelectorItem : IContent
    {
        public Control Control { get; set; }
        public GUIContent Content { get; set; } = new GUIContent("");
    }
}
