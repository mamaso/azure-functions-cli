using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Azure.Functions.Cli.Interfaces;
using Colors.Net;
using Fclp;
using System.Runtime.InteropServices;
using static Azure.Functions.Cli.Common.OutputTheme;
using Azure.Functions.Cli.Properties;

namespace Azure.Functions.Cli.Actions.LocalActions
{
    [Action(Name = "add", Context = Context.Extensions, HelpText = "Create a new function from a template.")]
    internal class AddExtensionAction : BaseAction
    {
        public string Package { get; set; }
        public string Version { get; set; }

        public AddExtensionAction()
        {
        }

        public override ICommandLineParserResult ParseArgs(string[] args)
        {
            Parser
                .Setup<string>('p', "package")
                .WithDescription("Extension package")
                .Callback(p => Package = p);
            Parser
                .Setup<string>('v', "version")
                .WithDescription("Extension version")
                .Callback(v => Version = v);

            return Parser.Parse(args);
        }

        public async override Task RunAsync()
        {
            var proj = Resources.ExtensionsProj;
        }
    }
}
