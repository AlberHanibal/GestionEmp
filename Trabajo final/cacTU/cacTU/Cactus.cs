using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cacTU
{
    internal class Cactus
    {
        private int indice;
        private string especie;
        private string genero;
        private string tribu;
        private string nombreComun;
        private string distribucion;
        private int stock;

        public Cactus(string especie, string genero, string tribu, int stock, int indice = 0, string nombreComun = "", string distribucion = "" )
        {
            this.indice = indice;
            this.especie = especie;
            this.genero = genero;
            this.tribu = tribu;
            this.nombreComun = nombreComun;
            this.distribucion = distribucion;
            this.stock = stock;
        }

        public int getIndice()
        {
            return indice;
        }

        public void setIndice(int indice)
        {
            this.indice = indice;
        }

        public string getEspecie()
        {
            return especie;
        }

        public void setEspecie(string especie)
        {
            this.especie = especie;
        }

        public string getGenero()
        {
            return genero;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public string getTribu()
        {
            return tribu;
        }

        public void setTribu(string tribu)
        {
            this.tribu = tribu;
        }

        public string getNombreComun()
        {
            return nombreComun;
        }

        public void setNombreComun(string nombreComun)
        {
            this.nombreComun = nombreComun;
        }

        public string getDistribucion()
        {
            return distribucion;
        }

        public void setDistribucion(string distribucion)
        {
            this.distribucion = distribucion;
        }

        public int getStock()
        {
            return stock;
        }

        public void setStock(int stock)
        {
            this.stock = stock;
        }
    }
}
