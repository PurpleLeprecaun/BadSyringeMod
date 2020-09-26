using BepInEx;
using RoR2;

namespace PurpleLeprecaun
{
    [BepInDependency("com.bepis.r2api")]
    //Change these
    [BepInPlugin("com.ThatsSickLOL.BadSyringe", "Bad Syringe and if we see this exact name on Thunderstore we will deprecate your mod", "1.0.0")]
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
