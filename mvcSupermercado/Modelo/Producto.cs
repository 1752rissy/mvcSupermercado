﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcSupermercado.Modelo
{
    public class Producto
    {
        public string  Codigo { get; set; } 
        public string Nombre { get; set; }  
        public float Precio { get; set; }   
        public int Cantidad { get; set; }

    }
}
