using System;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls
{
    /// <summary>
    /// A wrapper for GUILayoutOptions that makes it more intuitive to interact with.
    /// </summary>
    public struct LayoutOptions
    {
        public bool? ExpandHeight { private get; set; }
        public bool? ExpandWidth { private get; set; }
        public float? Height { private get; set; }
        public float? Width { private get; set; }
        public float? MaxWidth { private get; set; }
        public float? MinWidth { private get; set; }
        public float? MinHeight { private get; set; }
        public float? MaxHeight { private get; set; }

        public static implicit operator GUILayoutOption[](LayoutOptions lo)
        {
            List<GUILayoutOption> result = new List<GUILayoutOption>();
            if (lo.ExpandHeight != null) result.Add(GUILayout.ExpandHeight((bool)lo.ExpandHeight));
            if (lo.ExpandWidth != null) result.Add(GUILayout.ExpandWidth((bool)lo.ExpandWidth));
            if (lo.Height != null) result.Add(GUILayout.Height((float)lo.Height));
            if (lo.Width != null) result.Add(GUILayout.Width((float)lo.Width));
            if (lo.MaxWidth != null) result.Add(GUILayout.MaxWidth((float)lo.MaxWidth));
            if (lo.MinWidth != null) result.Add(GUILayout.MinWidth((float)lo.MinWidth));
            if (lo.MinHeight != null) result.Add(GUILayout.MinHeight((float)lo.MinHeight));
            if (lo.MaxHeight != null) result.Add(GUILayout.MaxHeight((float)lo.MaxHeight));
            return result.ToArray();
        }
        public static implicit operator LayoutOptions(GUILayoutOption glo)
        {
            throw new NotImplementedException();
        }
        public static implicit operator LayoutOptions(GUILayoutOption[] gloArr)
        {
            throw new NotImplementedException();
        }
    }
}
