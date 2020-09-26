using BepInEx;
using RoR2;
using R2API.Utils;
using R2API;

namespace PurpleLeprecaun
{
    [R2APISubmoduleDependency(nameof(ItemAPI), nameof(ItemDropAPI))]
    [BepInDependency("com.bepis.r2api")]
    [BepInPlugin("com.ThatsSickLOL.BadSyringe", "Bad Syringe", "1.0.0")]
    public class BadSyringe : BaseUnityPlugin
    {
        public void Awake()
        {
            On.EntityStates.Huntress.ArrowRain.OnEnter += (orig, self) =>
            {

                Chat.AddMessage("Hello");

                orig(self);
            };
        }
    }
}
