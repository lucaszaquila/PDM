using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XF.LocalDB.Model;

namespace XF.LocalDB.AlunoViewModel
{
    public class Aluno_ViewModel
    {
        public Aluno_ViewModel() { }
        #region Propriedades
        public string RM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Aluno> Alunos
        {
            get
            {
                return App.AlunoModel.GetAlunos().ToList();
            }
        }
        #endregion
    }
}
