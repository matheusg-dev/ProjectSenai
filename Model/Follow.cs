using System;
using System.Collections.Generic;

namespace ProjectSenai.Model
{
    public partial class Follow
    {
        public int Id { get; set; }
        public int? Seguido { get; set; }
        public int? Seguindo { get; set; }

        public virtual Usuario? SeguidoNavigation { get; set; }
        public virtual Usuario? SeguindoNavigation { get; set; }
    }
}
