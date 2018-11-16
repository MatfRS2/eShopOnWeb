namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    // This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
    // Using non-generic integer types for simplicity and to ease caching logic             
    /// <summary>
    /// Ovo osnovna klasa za entitete, iy koje se izvode svi ostali entiteti
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Osobina koja vra;e entitete
        /// </summary>
        /// <value> vrednost identifikatora</value>
        public int Id { get; set; }
    }
}
