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
                return _Value;
            }
            set
            {
                if (!_Value.Equals(value))
                {
                    _Value = value;
                    OnValueChanged?.Invoke(this, value);
                }
            }
        }
        public event EventHandler<T> OnValueChanged;
    }
}
