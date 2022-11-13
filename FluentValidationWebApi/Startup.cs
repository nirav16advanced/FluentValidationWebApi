using FluentValidation.AspNetCore;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace FluentValidationWebApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddFluentValidation(s =>
                {
                    // Validate child properties and root collection elements
                    s.ImplicitlyValidateChildProperties = true;
                    s.ImplicitlyValidateRootCollectionElements = true;

                    // Automatic registration of validators in assembly
                    s.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());


                    //s.RegisterValidatorsFromAssemblyContaining<Startup>();

                    //s.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                });
        }
    }
}
