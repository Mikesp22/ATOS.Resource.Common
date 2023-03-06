using ATOS.Resource.Common.Abstraction.Interfaces;

namespace ATOS.Resource.Common.Abstraction
{
    public class EntityBaseAuditable<Tkey, TUserKey> : IEntityBaseAuditable<Tkey, TUserKey>
    {
        public Tkey Id { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DateCreated { get; set; } 
        public TUserKey ModifiedBy { get; set; }
        public TUserKey IdUserCreator { get; set; }
        public bool State { get; set; }
    }
}
