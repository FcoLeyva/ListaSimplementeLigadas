namespace ListaSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;
        public Lista()
        {
            _nodoInicial = new Nodo();

        }

        private bool EstaVacia()
        {
            if (_nodoInicial.Enlace == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public void Vaciar()
        {
            _nodoInicial.Enlace = null;
        }

        public void Agregar(string valor)
        {
            Nodo nodoActual = _nodoInicial;
            while (nodoActual.Enlace != null)
            {
                nodoActual = nodoActual.Enlace;
            }

            Nodo nodoNuevo = new Nodo(valor);
            nodoActual.Enlace = nodoNuevo;
        }
    }
}
