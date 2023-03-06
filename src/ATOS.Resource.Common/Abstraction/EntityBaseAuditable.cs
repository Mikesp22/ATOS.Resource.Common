using ATOS.Resource.Common.Abstraction.Interfaces;

namespace ATOS.Resource.Common.Abstraction
{
    public class EntityBaseAuditable<Tkey, TUserKey> : EntityBase<Tkey, TUserKey>, IEntityBaseAuditable<Tkey, TUserKey>
    {
        public DateTime? ModifiedDate { get; set; }
        public TUserKey? ModifiedBy { get; set; }

    }
}
