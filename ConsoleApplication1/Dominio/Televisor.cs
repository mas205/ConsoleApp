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
        private int canal;
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
        public int Canal
        {
            get { return canal; }
            set { canal = value; }
        }


        #endregion

        #region Constructors
        public Televisor(string marca, string modelo, EnumTipoPantalla tipoPantalla, bool smart, EnumEstado estado, int brillo, int contraste, int volumen, int canal)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.tipoPantalla = tipoPantalla;
            this.smart = smart;
            this.estado = estado;
            this.brillo = brillo;
            this.contraste = contraste;
            this.volumen = volumen;
            this.canal = canal;
        }
        #endregion

        #region Métodos
        public void SubirCanal()
        {
            canal++;
            if (canal > 100)
                canal = 1;
            else if (canal < 1)
                canal = 100;
        }
        public void subirVolumen()
        {
            if (volumen <= 90)
                volumen += 10;


        }
        public void BajarVolumen()
        {
            if (volumen >= 10)
                volumen -= 10;


        }
        public override string ToString()
        {            
            return string.Format("Marca: {0}\nModelo: {1}\nTipo de pantalla: {2}\nSmart: {3}\nEstado: {4}\nBrillo: {5}\nContraste: {6}\nVolumen: {7}\nCanal: {8}", modelo, marca, tipoPantalla, smart, estado, brillo, contraste, volumen, canal);          
        }
        #endregion
    }
}
