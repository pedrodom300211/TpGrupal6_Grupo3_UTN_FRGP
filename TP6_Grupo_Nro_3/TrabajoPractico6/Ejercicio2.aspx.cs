﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoPractico6
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void lbtnEliminarProductosSeleccionados_Click(object sender, EventArgs e)
        {
            Session["TablaProductoSeleccion"] = null;
        }
    }
}