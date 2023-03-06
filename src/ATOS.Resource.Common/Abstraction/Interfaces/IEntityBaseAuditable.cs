using Atos.Core.Abstractions;

namespace ATOS.Resource.Common.Abstraction.Interfaces
{
    public interface IEntityBaseAuditable<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        /// <summary>
        /// Fecha de modificación del registro
        /// </summary>
        public DateTime ModifiedDate { get; set; } 
        /// <summary>
        /// Id del usuario que modificó el registro
        /// </summary>
        public TUserKey ModifiedBy { get; set; }
    }
}
