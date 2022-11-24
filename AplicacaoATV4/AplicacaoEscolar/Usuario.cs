using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoEscolar
{
    internal class Usuario
    {
        private string login{get; set; }
        private string senha { get; set; }
        private string status { get; set; }
        private string tipo { get;}
        private string perfil { get; set; }
        private string obsExtra {get; set; }

        private string[] modulosEstudo;
        private DateTime dataCriacao;

        Usuario(string login, string senha, string status, string tipo, string perfil, string obsExtra, string[] modulosEstudo, DateTime dataCriacao)
        {
            
            this.senha = senha;
            this.status = status;
            this.tipo = tipo;
            this.perfil = perfil;
            this.obsExtra = obsExtra;
            this.modulosEstudo = modulosEstudo;
            this.dataCriacao = DateTime.Now;
        }
    }
}
