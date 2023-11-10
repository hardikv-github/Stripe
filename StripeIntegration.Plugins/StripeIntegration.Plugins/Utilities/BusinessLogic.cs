using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripeIntegration.Plugins.Common
{
    public class BusinessLogic
    {
        public static Entity GetTargetEntity(IPluginExecutionContext Context)
        {
            Entity TargetEntity = new Entity();

            if (!Context.InputParameters.Contains("Target"))
                throw new Exception($"Context not contains parameter named Target");
            if (Context.InputParameters["Target"] == null)
                throw new Exception($"Parameter Target is null");
            if (Context.InputParameters["Target"] is Entity)
                TargetEntity = (Entity)Context.InputParameters["Target"];
            else if (Context.InputParameters["Target"] is EntityReference)
                TargetEntity = new Entity(((EntityReference)Context.InputParameters["Target"]).LogicalName, ((EntityReference)Context.InputParameters["Target"]).Id);
            else
                throw new Exception("Unmanaged case for TargetEntity");

            return TargetEntity;
        }

        public static Entity GetPreEntity(IPluginExecutionContext Context, string ImageName = "PreImage")
        {
            if (!Context.PreEntityImages.Contains(ImageName))
                throw new Exception($"Context not contains PreImage named {ImageName}");
            if (Context.PreEntityImages[ImageName] == null)
                throw new Exception($"PreImage {ImageName} is null");
            return Context.PreEntityImages[ImageName];
        }

        public static Entity GetPostEntity(IPluginExecutionContext Context, string ImageName = "PostImage")
        {
            if (!Context.PostEntityImages.Contains(ImageName))
                throw new Exception($"Context not contains PostImage named {ImageName}");
            if (Context.PostEntityImages[ImageName] == null)
                throw new Exception($"PostImage {ImageName} is null");
            return Context.PostEntityImages[ImageName];
        }

        

    }
}
