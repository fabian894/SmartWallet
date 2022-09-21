namespace SmartWallet2.Web.Data.Entities
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
