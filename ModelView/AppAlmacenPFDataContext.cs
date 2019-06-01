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
        public object DetalleFacturas { get; internal set; }
        public object EmailProveedores { get; internal set; }
        public object Compras { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}