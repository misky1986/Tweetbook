using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cosmonaut;
using Cosmonaut.Extensions.Microsoft.DependencyInjection;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tweetbook.Domain;

namespace Tweetbook.Installers
{
    public class CosmosInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            var cosmosStoreSEttings = new CosmosStoreSettings(
                configuration["CosmosSettings:DatabaseName"],
                configuration["CosmosSettings:AccountUri"],
                configuration["CosmosSettings:AccountKey"],
                new ConnectionPolicy { ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Tcp });

            services.AddCosmosStore<CosmosPostDto>(cosmosStoreSEttings);
        }
    }
}
