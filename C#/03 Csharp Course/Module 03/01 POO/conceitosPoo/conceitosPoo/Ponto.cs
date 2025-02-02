﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceitosPoo
{
    internal class Ponto
    {
        public Ponto(int x, int y) 
        {

            this.x = x;
            this.y = y;
            contadorDeObjetos++;
        }

        public Ponto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }

        public double DistanciaPontos(Ponto definicao)
        {
            int xDif = this.x - definicao.x;

            int yDif = this.y - definicao.y;

            double distanciaPontos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPontos;
        }

        public static int ContadorDeObjetos()=> contadorDeObjetos;

        private int x,y;
        private static int contadorDeObjetos = 0;
    }
}
