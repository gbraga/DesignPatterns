using System;
using System.Collections.Generic;

namespace DesignPatterns.Multiton
{
    public class Multiton
    {
        private static readonly IDictionary<MultitonType, Multiton> _instances = new Dictionary<MultitonType, Multiton>();
        private Guid Id;

        private Multiton()
        {
            Id = Guid.NewGuid();
        }

        public static Multiton GetInstance(MultitonType type)
        {
            // Lazy init (not thread safe as written)
            // Recommend using Double Check Loking if needing thread safety
            if (!_instances.ContainsKey(type))
                _instances.Add(type, new Multiton());

            return _instances[type];
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
