using System;

namespace EasyIMGUI.Controls.Base
{
    public abstract class ValueControl<T> : Control
    {
        private T _Value = default;

        public T Value
        {
            get
            {
                if (IsValueBinded) return BindingValueGetter.Invoke();
                return _Value;
            }
            set
            {
                if (_Value == null || !_Value.Equals(value))
                {
                    if (IsValueBinded) BindingValueSetter.Invoke(value);
                    _Value = value;
                    OnValueChanged?.Invoke(this, value);
                }
            }
        }

        public event EventHandler<T> OnValueChanged;

        public bool IsValueBinded => BindingValueSetter != null && BindingValueGetter != null;
        private Func<T> BindingValueGetter;
        private Action<T> BindingValueSetter;

        public void Bind(Func<T> getter, Action<T> setter)
        {
            BindingValueGetter = getter;
            BindingValueSetter = setter;
        }

        public void Unbind()
        {
            BindingValueGetter = null;
            BindingValueSetter = null;
        }
    }
}
