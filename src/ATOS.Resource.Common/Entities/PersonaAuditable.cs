using ATOS.Resource.Common.Abstraction;

namespace ATOS.Resource.Common.Entities
{
    public class PersonaAuditable<Tkey, TUserKey> : EntityBaseAuditable<Tkey, TUserKey>
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
