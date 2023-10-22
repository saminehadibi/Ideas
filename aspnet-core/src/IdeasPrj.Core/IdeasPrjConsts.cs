using IdeasPrj.Debugging;

namespace IdeasPrj
{
    public class IdeasPrjConsts
    {
        public const string LocalizationSourceName = "IdeasPrj";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "abf950c267b64fc79740cae5e862db15";
    }
}
