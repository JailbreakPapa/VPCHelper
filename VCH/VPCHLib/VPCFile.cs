/*
 *   Copyright (c) 2023-present Mikael K. Aboagye
 *   All rights reserved.
 *   This open-source project is covered by the MIT License. See the LICENSE file for more details.
 */

namespace VPCHLib
{
    public class VPCFile
    {
        /// <summary>
        /// filename/project vpc file. this should be changed from the default value.
        /// </summary>
        public string mvpc_filename = "project";

        /// <summary>
        /// This really should be fixed, but lets allow users to changed this as needed.
        /// </summary>
        public string mvpc_fileextend = ".vpc";

        /// <summary>
        /// Path for the VPC project. this must be set when creating the VPCFile class object.
        /// </summary>
        private string mvpc_projectpath = "";

        private FileStream mvpc_streamwriter;

        public VPCFile(string mvpc_projectpath)
        {
            this.mvpc_projectpath = mvpc_projectpath;
        }

        public void DestroyVPCFileStream()
        {
            mvpc_streamwriter.Close();
        }

        /// <summary>
        /// Creates a Blank VPC File.
        /// Users should NOT call this function if they want a fully configuration VPC file. for that call: VPCFile.ConfigurateFile to Query project information.
        /// </summary>
        /// <param name="PathForProject">Path for project. by defualt, the function will follow the mvpc_projectpath value that was provided upon object creation, but you can use this value to override that.</param>
        public void CreateVPCFile(string PathForProject)
        {
            /// First, check if the PathForProject is valid.
            if (PathForProject != null)
            {
                mvpc_streamwriter = new FileStream(PathForProject, FileMode.OpenOrCreate);
            }
            else
            {
                mvpc_streamwriter = new FileStream(mvpc_projectpath, FileMode.OpenOrCreate);
            }
        }

        public void WriteVPCMacro(FileStream fileStream, string macroname, string macrocontent)
        {
            if (fileStream == null)
            {
                VPCHLog.AddText(mvpc_streamwriter, macroname + " " + macrocontent);
            }
        }

        /// <summary>
        /// "Configurates" the VPC file, grabbing all source files in that directory, and subdirectories.
        /// </summary>
        /// <returns> Bool value on if it was successful or not. </returns>
        public bool ConfigurateFile()
        {
            /// Check if our stream writer is ready.
            if (mvpc_streamwriter == null)
            {
                Console.WriteLine("VPCHLib: mvpc_streamwriter is not valid. was the PathForProject string given in CreateVPCFile valid?");
                return false;
            }

            /// Then, Start adding some comments.
            return true;
        }
    }
}