using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace CFT158SalesPlugins
{
    public class AccountUpdate : IPlugin
    {
        IOrganizationService service; Entity currentEntity; 
        IPluginExecutionContext context; 
        ITracingService trace; 

        /// <summary>
        /// Initializes common parameters to set the IPluginExecutionContext and IOrganizationServiceFactory.
        /// </summary>
        /// <param name='serviceProvider'>Object of IServiceProvider</param>
        private void GetOrganizationService(IServiceProvider serviceProvider)
        {
            try
            {
                context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
                service = ((IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory))).CreateOrganizationService(context.UserId);
                trace = (ITracingService)serviceProvider.GetService(typeof(ITracingService));
            }
            catch (Exception ex)
            {

            }
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                GetOrganizationService(serviceProvider);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
