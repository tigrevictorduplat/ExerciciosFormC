using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoEscolar
{
    public class Usuario
    {
        private string login;
        public string Login { get; }
        
        private string senha;
        public string Senha { get; }
        
        private ComboBox status;
        public ComboBox Stauts { get; }
        
        private RadioButton tipo;
        public RadioButton Tipo{ get; }
        
        private RadioButton perfil;
        public RadioButton Perfil{ get; }
        
        private string obsExtra;
        
        private List<string> modulosEstudo;
        public List<string> ModuloEstudo { get; }
        
        private DateTime dataCriacao { get; }
        public DateTime DataCriacao { get; }
        
        public Usuario(string login, string senha, ComboBox status, RadioButton tipo, RadioButton perfil, string obsExtra, List<string> modulosEstudo)
        {
            this.login = login;
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
