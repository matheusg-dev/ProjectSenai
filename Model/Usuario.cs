using System;
using System.Collections.Generic;

namespace ProjectSenai.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            FollowSeguidoNavigations = new HashSet<Follow>();
            FollowSeguindoNavigations = new HashSet<Follow>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Senha { get; set; } = null!;

        public virtual ICollection<Follow> FollowSeguidoNavigations { get; set; }
        public virtual ICollection<Follow> FollowSeguindoNavigations { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
