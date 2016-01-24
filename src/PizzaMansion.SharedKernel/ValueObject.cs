using System;

namespace Pizzamansion.SharedKernel
{
    public abstract class ValueObject<T> : IEquatable<T> where T: ValueObject<T>
    {
        public bool Equals(T other)
        {
            throw new NotImplementedException();
        }
    }
}