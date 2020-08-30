using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class ClasseSingleton
    {
        private static ClasseSingleton _instance;

        public Guid Id { get; private set; }

        private ClasseSingleton()
        {
            Id = Guid.NewGuid();
        }

        public static ClasseSingleton Instance()
        {
            if (_instance == null)
                _instance = new ClasseSingleton();

            return _instance;
        }
    }
}
