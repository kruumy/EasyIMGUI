
using EasyIMGUI.Controls.Base;
using System.Collections.Generic;
using UnityEngine;

namespace EasyIMGUI.Controls.Extra.Base
{
    public class SelectorItems : List<SelectorItem>
    {
        public Control[] Controls
        { 
            get
            {
                Control[] result = new Control[base.Count];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = base[i].Control;
                }
                return result;
            }
        }
        public GUIContent[] Contents
        {
            get
            {
                GUIContent[] result = new GUIContent[base.Count];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = base[i].Content;
                }
                return result;
            }
        }

    }
}
