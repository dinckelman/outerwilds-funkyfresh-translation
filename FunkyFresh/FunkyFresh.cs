using OWML.Common;
using OWML.ModHelper;

namespace FunkyFresh
{
    public class FunkyFresh : ModBehaviour
    {
        public static FunkyFresh Instance;
        private void Awake() {}

        private void Start()
        {
            // Starting here, you'll have access to OWML's mod helper.
            ModHelper.Console.WriteLine($"{nameof(FunkyFresh)} localization is loaded!", MessageType.Success);
            
            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "FunkyFresh", "assets/funkyfresh.xml");
        }
    }
}