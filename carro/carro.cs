using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carro
{
    public class Carro
    {
        private int _accion;
        public int accion
        {
            get { return _accion; }
            set { _accion = value; }
        }
        private bool _encendido;

        public bool encendido
        {
            get { return _encendido; }
            set { _encendido = value; }
        }

        private int _galones;

        public int galones
        {
            get { return _galones; }
            set { _galones = value; }
        }

        private int _velocidadmaxima;

        public int velocidadmaxima
        {
            get { return _velocidadmaxima; }
            set { _velocidadmaxima = value; }
        }

        private int _velocidad;

        public int velocidad
        {
            get { return _velocidad; }
            set { _velocidad = value; }
        }

        private string _kilometros;

        public string kilometros
        {
            get { return _kilometros; }
            set { _kilometros = value; }
        }
        private int _Cambio;
        public int cambio
        {
            get { return _Cambio; }
            set { _Cambio = value; }
        }
        private int _Distanciarecorrida;
        public int distanciarecorrida
        {
            get { return _Distanciarecorrida; }
            set { _Distanciarecorrida = value; }
        }
        private int _freno;
        public int freno
        {
            get { return _freno; }
            set { _freno = value; }
        }
    }
}
