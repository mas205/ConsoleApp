using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Televisor
    {
        #region Atributos
        private string marca;
        private string modelo;
        public enum EnumTipoPantalla { LED = 1, LCD, PLASMA, TRC }
        private bool smart;
        public enum EnumEstado { PRENDIDO, APAGADO, STANDBY }
        private int brillo;
        private int contraste;
        private int volumen;
        #endregion

        #region Properties
        public string Marca
        {
            get { return marca; }
            //set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            //set { modelo = value; }
        }

        private EnumTipoPantalla tipoPantalla;
        public EnumTipoPantalla TipoPantalla
        {
            get { return tipoPantalla; }
            //set { tipoPantalla = value; }
        }

        public bool Smart
        {
            get { return smart; }
        }

        private EnumEstado estado;

        public EnumEstado Estado
        {
            get { return estado; }
        }
        public int Brillo
        {
            get { return brillo; }
            set { brillo = value; }
        }
        public int Contraste
        {
            get { return contraste; }
            set { contraste = value; }
        }
        public int Volumen
        {
            get { return volumen; }
            set { volumen = value; }
        }



        #endregion

        #region Constructor
        public Televisor(string marca, string modelo, EnumTipoPantalla tipoPantalla, bool smart, EnumEstado estado, int brillo, int contraste, int volumen)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipoPantalla = tipoPantalla;
            this.smart = smart;
            this.estado = estado;
            this.brillo = brillo;
            this.contraste = contraste;
            this.volumen = volumen;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Marca: {0}\nModelo: {1}\nTipo de pantalla: {2}\nSmart: {3}\nEstado: {4}\nBrillo: {5}\nContraste: {6}\nVolumen: {7}", modelo, marca, tipoPantalla, smart, estado, brillo, contraste, volumen);          
        }
    }
}
