﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGNER.Tools
{
    public static class Aviso
    {
        public static void Informar(string mensaje)
        { 
            MessageBox.Show(
                mensaje,
                "App TiendaNET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        public static void Advertir(string mensaje)
        {
            MessageBox.Show(
                mensaje,
                "App TiendaNET",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        public static DialogResult Preguntar(string mensaje)
        {
            return
                MessageBox.Show(
                mensaje,
                "App TiendaNET",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }
    }
}
