/*--****************************************************************************
  --* Project Name    : Credentalless
  --* Reference       : NA
  --* Description     : Core
  --* Configuration Record
  --* Review            Ver  Author           Date      Cr       Comments
  --* 001               001  A HATKAR         11/12/23  CR-XXXXX Original
  --****************************************************************************/
namespace Credentialless.Core
{
    /// <summary>
    /// Represents credentialless version
    /// </summary>
    public static class CredVersion
    {
        /// <summary>
        /// Gets or sets major version
        /// </summary>
        public const string CURRENT_VERSION = "4.60";

        /// <summary>
        /// Gets or sets minor version
        /// </summary>
        public const string MINOR_VERSION = "5";

        /// <summary>
        /// Gets or sets full version
        /// </summary>
        public const string FULL_VERSION = CURRENT_VERSION + "." + MINOR_VERSION;
    }
}