namespace VPCHLib
{
    public static class VPCLanguage
    {
        /// <summary>
        /// This will be moved into a cleaner method.
        /// 
        /// New Method: VPCH Will Read VPC definition files, write the custom Syntax to a txt file, and create VPC files using the includes.
        /// </summary>
        public struct VPCSyntax
        {
            // Files
            public string Files = " $File";

            // Additional Include Directories
            public string AdditionalIncludeDirectories = "$AdditionalIncludeDirectories"; // $AdditionalIncludeDirectories

            // Preprocessor Definitions
            public string PreprocessorDefinitions = "$PreprocessorDefinitions"; // $PreprocessorDefinitions

            // Additional Options
            public string AdditionalOptions = "$AdditionalOptions"; // $AdditionalOptions

            // Treat Warnings As Errors
            public string TreatWarningsAsErrors = "$TreatWarningsAsErrors";// $TreatWarningsAsErrors

            public string Configuration = "$Configuration";

            public string Project = "$Project";

            public string Folder = "$Folder";

            public string Compiler = "$Compiler";

            public string MacroRequired = "$MacroRequired";
            // Constructor to initialize any default values if needed
            public VPCSyntax(string files, string additionalIncludeDirs, string preprocessorDefs, string additionalOptions, string treatWarningsAsErrors)
            {
                Files = files;
                AdditionalIncludeDirectories = additionalIncludeDirs;
                PreprocessorDefinitions = preprocessorDefs;
                AdditionalOptions = additionalOptions;
                TreatWarningsAsErrors = treatWarningsAsErrors;
            }
        }
    }
}
