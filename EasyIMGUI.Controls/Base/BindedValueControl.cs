using System;

namespace EasyIMGUI.Controls.Base
{
    public abstract class BindedValueControl<T> : Control, IValue<T>
    {
        public Action<T> ValueSetter;
        public Func<T> ValueGetter;
        T IValue<T>.Value
        {
            get
            {
                return ValueGetter.Invoke();
            }
            set
            {
                ValueSetter?.Invoke(value);
            }
        }
    }
}
