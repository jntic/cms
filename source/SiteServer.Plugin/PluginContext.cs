﻿namespace SiteServer.Plugin
{
    public class PluginContext
    {
        public PluginContext(PluginMetadata metadata, IPublicApi api)
        {
            Metadata = metadata;
            Api = api;
        }

        public PluginMetadata Metadata { get; }

        /// <summary>
        /// Public APIs for plugin invocation
        /// </summary>
        public IPublicApi Api { get; }
    }
}
