﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoPractico6
{
    public class Producto
    {
        private int i_IdProducto;
        private String s_NombreProducto;
        private String s_CantidadPorUnidad;
        private decimal d_PrecioUnidad;
        public Producto()
        {

        }
        public Producto(int i_IdProducto, String s_NombreProducto,
            String s_CantidadPorUnidad, decimal d_PrecioUnidad)
        {
            this.i_IdProducto = i_IdProducto;
            this.s_NombreProducto = s_NombreProducto;
            this.s_CantidadPorUnidad = s_CantidadPorUnidad;
            this.d_PrecioUnidad = d_PrecioUnidad;
        }
        public int IdProducto
        {
            get { return i_IdProducto; }
            set { i_IdProducto = value; }
        }
        public String NombreProducto
        {
            get { return s_NombreProducto; }
            set { s_NombreProducto = value; }
        }
        public String CantidadPorUnidad
        {
            get { return s_CantidadPorUnidad; }
            set { s_CantidadPorUnidad = value; }
        }
        public decimal PrecioUnidad
        {
            get { return d_PrecioUnidad; }
            set { d_PrecioUnidad = value; }
        }
    }
}