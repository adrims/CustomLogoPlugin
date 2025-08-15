using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;
using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Serialization;

namespace CustomLogoPlugin
{
        public class Plugin : BasePlugin<PluginConfiguration>, IPlugin
        {
            private readonly IApplicationPaths _applicationPaths;

            public override string Name => "Custom Logo";
            public override string Description => "Allows uploading a custom logo to replace Jellyfin branding.";

            public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
                : base(applicationPaths, xmlSerializer)
            {
                _applicationPaths = applicationPaths;
                Instance = this;
            }

            public override Guid Id => Guid.Parse("b7e8dce1-44df-4b37-91a3-15fcf9f3b76a");

            public static Plugin? Instance { get; private set; }

            public new IApplicationPaths ApplicationPaths => _applicationPaths;
        }
}
