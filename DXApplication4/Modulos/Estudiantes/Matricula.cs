﻿using DXApplication4.Reports.Estudiantes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication4.Modulos.Estudiantes
{
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
            MatriculaPorPrograma report = new MatriculaPorPrograma();
            
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
