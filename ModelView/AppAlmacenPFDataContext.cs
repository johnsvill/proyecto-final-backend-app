using System;

namespace AppAlmacenPF.ModelView
{
    internal class AppAlmacenPFDataContext
    {
        public object Productos { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}