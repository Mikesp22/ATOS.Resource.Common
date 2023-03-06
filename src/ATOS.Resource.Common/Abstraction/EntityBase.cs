using Atos.Core.Abstractions;

namespace ATOS.Resource.Common.Abstraction
{
    public class EntityBase<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        public TKey Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public TUserKey UserCreatorId { get; set; }
        public bool State { get; set; }

    }
}
