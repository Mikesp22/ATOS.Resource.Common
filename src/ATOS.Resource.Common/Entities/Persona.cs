using ATOS.Resource.Common.Abstraction;

namespace ATOS.Resource.Common.Entities
{
    public class Persona<TKey, TUserKey> : EntityBase<TKey, TUserKey>
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
