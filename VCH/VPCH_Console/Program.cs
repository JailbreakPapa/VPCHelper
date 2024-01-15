using CommandLine;

namespace VPCH
{
    public class VPCHOptions
    {
        [Option('l', "logsuccess", Required = false, HelpText = "Bool to allow VPCH to create a log file on success.")]
        public bool LogOnSuccess { get; set; }

        [Option('p', "projectname", Required = true, HelpText = "Name Of the project that you want to generate the vpc file for.")]
        public required string ProjectName { get; set; }


    }
}