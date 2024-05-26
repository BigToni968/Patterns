using UnityEngine;
using System;

namespace Patterns
{
    public interface IModel
    {
        public void OnInit(IModel model);
        public IModel Copy();
    }
    public interface IModel<T> : IModel
    {
        public void Set(T data);
    }

    [Serializable]
    public abstract class Model<T> : IModel
    {
        [field: SerializeField] public T Data { get; private set; }

        public virtual void OnInit(IModel model) { }
        public virtual void Set(T data) { }
        public virtual IModel Copy()
        {
            return MemberwiseClone() as IModel;
        }
    }
}