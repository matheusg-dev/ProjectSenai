using System;
using System.Collections.Generic;

namespace ProjectSenai.Model
{
    public partial class Post
    {
        public int Id { get; set; }
        public int? Publicante { get; set; }
        public string Conteudo { get; set; } = null!;
        public DateTime Momento { get; set; }

        public virtual Usuario? PublicanteNavigation { get; set; }
    }
}
