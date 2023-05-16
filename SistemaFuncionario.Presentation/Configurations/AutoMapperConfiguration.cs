namespace SistemaFuncionario.Presentation.Configurations
{
    public class AutoMapperConfiguration
    {
        public static void Add(WebApplicationBuilder builder)
        {
            // AutoMapper
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
