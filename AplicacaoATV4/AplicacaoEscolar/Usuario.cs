using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoEscolar
{
    internal class Usuario
    {
        private string logi;
        private string senha;
        private string status;
        private string tipo;
        private string perfil;
        private string obsExtra;
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
