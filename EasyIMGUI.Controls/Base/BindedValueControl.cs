using System;

namespace EasyIMGUI.Controls.Base
{
    public abstract class BindedValueControl<T> : Control
    {
        public Action<T> ValueSetter;
        public Func<T> ValueGetter;
        protected internal T Value
        {
            get
            {
                return ValueGetter.Invoke();
            }
            set
            {
                ValueSetter.Invoke(value);
            }
        }
    }
}
