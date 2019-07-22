using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Si.Criptografia
{
    public class BindableBase<T> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool SetField<TValue>(ref TValue field, TValue value, Expression<Func<T, object>> selectorExpression)
        {
            if (EqualityComparer<TValue>.Default.Equals(field, value))
            {
                return false;
            }

            field = value;
            OnPropertyChanged(selectorExpression);

            return true;
        }

        protected virtual void OnPropertyChanged(Expression<Func<T, object>> selectorExpression)
        {
            MemberExpression body = selectorExpression.Body as MemberExpression;
            if (body != null)
            {
                OnPropertyChanged(body.Member.Name);
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
