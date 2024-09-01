using UnityEngine;
using System;

namespace Patterns
{
    public interface IModel
    {
        public void Init();
        public T Copy<T>() where T : class;
        public void Set(IModel model);
    }

    [Serializable]
    public abstract class Model : IModel
    {
        public virtual void Init() { }

        public virtual void Set(IModel model) { }

        public T Copy<T>() where T : class
        {
            return MemberwiseClone() as T;
        }
    }
}