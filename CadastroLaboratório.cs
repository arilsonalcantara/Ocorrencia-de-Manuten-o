﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocorrencia_de_Manutenção
{
    public partial class CadastroLaboratório : Form
    {
        MenuOpção OpçãoCadastro;
        public CadastroLaboratório(MenuOpção opc)
        {
            InitializeComponent();
            OpçãoCadastro = opc;
        }

        
    }
}
