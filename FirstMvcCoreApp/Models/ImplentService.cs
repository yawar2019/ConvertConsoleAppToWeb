namespace FirstMvcCoreApp.Models
{
    public class ImplentService :  ITransientServices,ISingletonServices,IScopedServices
    {
        Guid id;
        public ImplentService()
        {
            id = Guid.NewGuid();
        }
        public Guid getOperation()
        {
            return id;
        }
    }
}
