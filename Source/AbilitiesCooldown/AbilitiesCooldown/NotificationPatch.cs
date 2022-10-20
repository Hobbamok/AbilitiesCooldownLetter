using HarmonyLib;
using RimWorld;
using System.Reflection;
using Verse;

namespace AbilitiesCooldown
{
    [HarmonyPatch(typeof(Ability), "AbilityTick")]
    public static class AC_NotificationPatch
    {
        private static FieldInfo cooldownTicks = AccessTools.Field(typeof(Ability), "cooldownTicks");

        [HarmonyPostfix]
        public static void NotificationPostfix(Ability __instance)
        {
            if (__instance.def.defName == "Convert" && (int)cooldownTicks.GetValue(__instance) == 1)
            {
                //Messages.Message("Your Cleric can cast abilities again.", __instance.pawn, MessageTypeDefOf.PositiveEvent, false);
                //alert.Notify_Started();
                Letter letter = new StandardLetter();
                LetterDef letDef = new LetterDef();
                letDef.arriveSound = SoundDef.Named("");
                letter.def = letDef;
                letter.label = "Your Cleric can convert again";
                
                
                Find.LetterStack.ReceiveLetter(letter);


            }
            if (__instance.def.defName == "ProductionCommand" && (int)cooldownTicks.GetValue(__instance) == 1)
            {
                //Messages.Message("Your Cleric can cast abilities again.", __instance.pawn, MessageTypeDefOf.PositiveEvent, false);
                //alert.Notify_Started();
                Letter letter = new StandardLetter();
                LetterDef letDef = new LetterDef();
                letDef.arriveSound = SoundDef.Named("");
                letter.def = letDef;
                letter.label = "Sigma Male Grindset time";
                
                
                Find.LetterStack.ReceiveLetter(letter);


            }
            if (__instance.def.defName == "ResearchCommand" && (int)cooldownTicks.GetValue(__instance) == 1)
            {
                //Messages.Message("Your Cleric can cast abilities again.", __instance.pawn, MessageTypeDefOf.PositiveEvent, false);
                //alert.Notify_Started();
                Letter letter = new StandardLetter();
                LetterDef letDef = new LetterDef();
                letDef.arriveSound = SoundDef.Named("");
                letter.def = letDef;
                letter.label = "Oh yeah it's big brain time";
                
                
                Find.LetterStack.ReceiveLetter(letter);


            }

            /*if (__instance.def.defName != "Burden" && __instance.def.defName != "EntropyDump" && __instance.def.defName != "WordOfTrust" && __instance.def.defName != "Painblock" && __instance.def.defName != "ChaosSkip" && (int)cooldownTicks.GetValue(__instance) == 1)
            {
                Messages.Message(__instance.def.defName, __instance.pawn, MessageTypeDefOf.PositiveEvent, false);
            }*/
            

            

        }
        /*[HarmonyPostfix
        public static void ]*/
    }
}