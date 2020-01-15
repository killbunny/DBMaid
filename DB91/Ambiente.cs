﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB91
{
    class Ambiente
    {
        public List<string> tvTablasDestino { get; set; }
        public List<string> tvStoredDestino { get; set; }
        public List<string> tvVistasDestino { get; set; }
        public List<string> tvFuncionesDestino { get; set; }
        public bool ckMostrar { get; set; }
        public bool ckGuardar { get; set; }
        public bool ckEjecutar { get; set; }
        public bool ckBulkCopy { get; set; }
        public string Conn { get; set; }
        public string Catalog { get; set; }

        [Newtonsoft.Json.JsonConstructor]
        public Ambiente(List<string> tvTablasDestino, List<string> tvStoredDestino, List<string> tvVistasDestino, List<string> tvFuncionesDestino, bool ckMostrar, bool ckGuardar, bool ckEjecutar, bool ckBulkCopy, string con, string cat)
        {
            this.tvTablasDestino = tvTablasDestino;
            this.tvStoredDestino = tvStoredDestino;
            this.tvVistasDestino = tvVistasDestino;
            this.tvFuncionesDestino = tvFuncionesDestino;
            this.ckMostrar = ckMostrar;
            this.ckGuardar = ckGuardar;
            this.ckEjecutar = ckEjecutar;
            this.ckBulkCopy = ckBulkCopy;
            this.Conn = con;
            this.Catalog = cat;
        }

        public Ambiente()
        {

        }
    }
}
