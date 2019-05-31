using System;

namespace AppAlmacenPF.ModelView
{
    internal class AppAlmacenPFDataContext
    {
        public object Productos { get; internal set; }
        public object Categorias { get; internal set; }
        public object Inventarios { get; internal set; }
        public object TipoEmpaques { get; internal set; }
        public object DetalleCompras { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}