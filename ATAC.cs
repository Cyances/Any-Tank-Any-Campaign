using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using HarmonyLib;
using ATAC;
using UnityEngine;
using System.Reflection;
using BehaviorDesigner.Runtime.Tasks.Unity.UnityString;

[assembly: MelonInfo(typeof(ATACMod), "Any Tank Any Campaign", "1.0.1", "Cyance and Fractal")]
[assembly: MelonGame("Radian Simulations LLC", "GHPC")]

namespace ATAC
{
    public class ATACMod : MelonMod
    {
        public static MelonPreferences_Category cfg;
        public static MelonPreferences_Entry<string> tow_replace;
        public static MelonPreferences_Entry<int> tow_chance;
        public static MelonPreferences_Entry<string> m923_replace;
        public static MelonPreferences_Entry<int> m923_chance;
        public static MelonPreferences_Entry<string> m113_replace;
        public static MelonPreferences_Entry<int> m113_chance;
        public static MelonPreferences_Entry<string> m2_replace;
        public static MelonPreferences_Entry<int> m2_chance;
        public static MelonPreferences_Entry<string> m60a1_replace;
        public static MelonPreferences_Entry<int> m60a1_chance;
        public static MelonPreferences_Entry<string> m60a3_replace;
        public static MelonPreferences_Entry<int> m60a3_chance;
        public static MelonPreferences_Entry<string> m1_replace;
        public static MelonPreferences_Entry<int> m1_chance;
        public static MelonPreferences_Entry<string> m1ip_replace;
        public static MelonPreferences_Entry<int> m1ip_chance;

        public static MelonPreferences_Entry<string> spigot_replace;
        public static MelonPreferences_Entry<int> spigot_chance;
        public static MelonPreferences_Entry<string> ural375d_replace;
        public static MelonPreferences_Entry<int> ural375d_chance;
        public static MelonPreferences_Entry<string> brdm2_replace;
        public static MelonPreferences_Entry<int> brdm2_chance;
        public static MelonPreferences_Entry<string> btr60pb_replace;
        public static MelonPreferences_Entry<int> btr60pb_chance;
        public static MelonPreferences_Entry<string> bmp1_replace;
        public static MelonPreferences_Entry<int> bmp1_chance;
        public static MelonPreferences_Entry<string> bmp1p_replace;
        public static MelonPreferences_Entry<int> bmp1p_chance;
        public static MelonPreferences_Entry<string> bmp2_replace;
        public static MelonPreferences_Entry<int> bmp2_chance;
        public static MelonPreferences_Entry<string> pt76_replace;
        public static MelonPreferences_Entry<int> pt76_chance;
        public static MelonPreferences_Entry<string> t55a_replace;
        public static MelonPreferences_Entry<int> t55a_chance;
        public static MelonPreferences_Entry<string> t72m_replace;
        public static MelonPreferences_Entry<int> t72m_chance;
        public static MelonPreferences_Entry<string> t72mgills_replace;
        public static MelonPreferences_Entry<int> t72mgills_chance;
        public static MelonPreferences_Entry<string> t72m1_replace;
        public static MelonPreferences_Entry<int> t72m1_chance;

        public static MelonPreferences_Entry<string> spigot_sa_replace;
        public static MelonPreferences_Entry<int> spigot_sa_chance;
        public static MelonPreferences_Entry<string> ural375d_sa_replace;
        public static MelonPreferences_Entry<int> ural375d_sa_chance;
        public static MelonPreferences_Entry<string> brdm2_sa_replace;
        public static MelonPreferences_Entry<int> brdm2_sa_chance;
        public static MelonPreferences_Entry<string> btr60pb_sa_replace;
        public static MelonPreferences_Entry<int> btr60pb_sa_chance;
        public static MelonPreferences_Entry<string> bmp1_sa_replace;
        public static MelonPreferences_Entry<int> bmp1_sa_chance;
        public static MelonPreferences_Entry<string> bmp1p_sa_replace;
        public static MelonPreferences_Entry<int> bmp1p_sa_chance;
        public static MelonPreferences_Entry<string> bmp2_sa_replace;
        public static MelonPreferences_Entry<int> bmp2_sa_chance;
        public static MelonPreferences_Entry<string> t62_replace;
        public static MelonPreferences_Entry<int> t62_chance;
        public static MelonPreferences_Entry<string> t64a_replace;
        public static MelonPreferences_Entry<int> t64a_chance;
        public static MelonPreferences_Entry<string> t80b_replace;
        public static MelonPreferences_Entry<int> t80b_chance;
        public override void OnInitializeMelon()
        {
            cfg = MelonPreferences.CreateCategory("ATAC Config");
            tow_replace = cfg.CreateEntry("TOW Launcher replacement", "STATIC_TOW");
            tow_replace.Description = "////NATO////";
            tow_chance = cfg.CreateEntry("TOW Launcher replacement chance", 100);
            m923_replace = cfg.CreateEntry("M923 replacement", "M923");
            m923_chance = cfg.CreateEntry("M923 replacement chance", 100);
            m113_replace = cfg.CreateEntry("M113 replacement", "M2BRADLEY");
            m113_chance = cfg.CreateEntry("M113 replacement chance", 100);
            m2_replace = cfg.CreateEntry("M2 replacement", "M2BRADLEY");
            m2_chance = cfg.CreateEntry("M2 replacement chance", 100);
            m60a1_replace = cfg.CreateEntry("M60A1 replacement", "M60A1RISEP");
            m60a1_chance = cfg.CreateEntry("M60A1 replacement chance", 100);
            m60a3_replace = cfg.CreateEntry("M60A3 replacement", "M60A3TTS");
            m60a3_chance = cfg.CreateEntry("M60A3 replacement chance", 100);
            m1_replace = cfg.CreateEntry("M1 replacement", "M1");
            m1_chance = cfg.CreateEntry("M1 replacement chance", 100);
            m1ip_replace = cfg.CreateEntry("M1IP replacement", "M1IP");
            m1ip_chance = cfg.CreateEntry("M1IP replacement chance", 100);

            spigot_replace = cfg.CreateEntry("9K111 Launcher replacement", "STATIC_9K111");
            spigot_replace.Description = "////NVA////";
            spigot_chance = cfg.CreateEntry("9K111 Launcher replacement chance", 100);
            ural375d_replace = cfg.CreateEntry("Ural-375D replacement", "URAL375D");
            ural375d_chance = cfg.CreateEntry("Ural-375D replacement chance", 100);
            brdm2_replace = cfg.CreateEntry("BRDM2 replacement", "BRDM2");
            brdm2_chance = cfg.CreateEntry("BRDM2 replacement chance", 100);
            btr60pb_replace = cfg.CreateEntry("BTR-60PB replacement", "BTR60PB");
            btr60pb_chance = cfg.CreateEntry("BTR-60PB replacement chance", 100);
            bmp1_replace = cfg.CreateEntry("BMP-1 replacement", "BMP1");
            bmp1_chance = cfg.CreateEntry("BMP-1 replacement chance", 100);
            bmp1p_replace = cfg.CreateEntry("BMP-1P replacement", "BMP1P");
            bmp1p_chance = cfg.CreateEntry("BMP-1P replacement chance", 100);
            bmp2_replace = cfg.CreateEntry("BMP-2 replacement", "BMP2");
            bmp2_chance = cfg.CreateEntry("BMP-2 replacement chance", 100);
            pt76_replace = cfg.CreateEntry("PT-76B replacement", "PT76B");
            pt76_chance = cfg.CreateEntry("PT-76B replacement chance", 100);
            t55a_replace = cfg.CreateEntry("T-55A replacement", "T72MGILLS");
            t55a_chance = cfg.CreateEntry("T-55A replacement chance", 100);
            t72m_replace = cfg.CreateEntry("T-72M replacement", "T72A");
            t72m_chance = cfg.CreateEntry("T-72M replacement chance", 100);
            t72mgills_replace = cfg.CreateEntry("T-72M Gills replacement", "T72A");
            t72mgills_chance = cfg.CreateEntry("T-72M Gills replacement chance", 100);
            t72m1_replace = cfg.CreateEntry("T-72M1 replacement", "T72A");
            t72m1_chance = cfg.CreateEntry("T-72M1 replacement chance", 100);

            spigot_sa_replace = cfg.CreateEntry("SA 9K111 Launcher replacement", "STATIC_9K111_SA");
            spigot_sa_replace.Description = "////SA////";
            spigot_sa_chance = cfg.CreateEntry("SA 9K111 Launcher replacement chance", 100);
            ural375d_sa_replace = cfg.CreateEntry("SA Ural-375D", "URAL375D_SA");
            ural375d_sa_chance = cfg.CreateEntry("SA Ural-375D replacement chance", 100);
            brdm2_sa_replace = cfg.CreateEntry("SA BRDM2 replacement", "BRDM2_SA");
            brdm2_sa_chance = cfg.CreateEntry("SA BRDM2 replacement chance", 100);
            btr60pb_sa_replace = cfg.CreateEntry("SA BTR-60PB replacement", "BTR60PB_SA");
            btr60pb_sa_chance = cfg.CreateEntry("SA BTR-60PB replacement chance", 100);
            bmp1_sa_replace = cfg.CreateEntry("SA BMP-1 replacement", "BMP1P_SA");
            bmp1_sa_chance = cfg.CreateEntry("SA BMP-1 replacement chance", 100);
            bmp1p_sa_replace = cfg.CreateEntry("SA BMP-1P replacement", "BMP1P_SA");
            bmp1p_sa_chance = cfg.CreateEntry("SA BMP-1P replacement chance", 100);
            bmp2_sa_replace = cfg.CreateEntry("SA BMP-2 replacement", "BMP2_SA");
            bmp2_sa_chance = cfg.CreateEntry("SA BMP-2 replacement chance", 100);
            t62_replace = cfg.CreateEntry("SA T-62 replacement", "T62");
            t62_chance = cfg.CreateEntry("SA T-62 replacement chance", 100);
            t64a_replace = cfg.CreateEntry("SA T-64A replacement", "T64A");
            t64a_chance = cfg.CreateEntry("SA T-64A replacement chance", 100);
            t80b_replace = cfg.CreateEntry("SA T-80B replacement", "T80B");
            t80b_chance = cfg.CreateEntry("SA T-80B replacement chance", 100);
        }

        [HarmonyPatch(typeof(GHPC.Mission.DynamicMissionComposer), "GetFirstRegisteredKeyForSpawnPoint")]
        public static class ReplaceUnits
        {
            private static void Postfix(GHPC.Mission.DynamicMissionComposer __instance, ref string __result)
            {
                string replace = null;
                int chance = 0;
                bool failed = false;
                switch (__result)
                {
                    // NATO
                    case "STATIC_TOW":
                        replace = tow_replace.Value;
                        chance = tow_chance.Value;
                        break;
                    case "M923":
                        replace = m923_replace.Value;
                        chance = m923_chance.Value;
                        break;
                    case "M113":
                        replace = m113_replace.Value;
                        chance = m113_chance.Value;
                        break;
                    case "M2BRADLEY":
                        replace = m2_replace.Value;
                        chance = m2_chance.Value;
                        break;
                    case "M60A1RISEP":
                        replace = m60a1_replace.Value;
                        chance = m60a1_chance.Value;
                        break;
                    case "M60A3TTS":
                        replace = m60a3_replace.Value;
                        chance = m60a3_chance.Value;
                        break;
                    case "M1":
                        replace = m1_replace.Value;
                        chance = m1_chance.Value;
                        break;
                    case "M1IP":
                        replace = m1ip_replace.Value;
                        chance = m1ip_chance.Value;
                        break;
                    // NVA
                    case "STATIC_9K111":
                        replace = spigot_replace.Value;
                        chance = spigot_chance.Value;
                        break;
                    case "URAL375D":
                        replace = ural375d_replace.Value;
                        chance = ural375d_chance.Value;
                        break;
                    case "BRDM2":
                        replace = brdm2_replace.Value;
                        chance = brdm2_chance.Value;
                        break;
                    case "BTR60PB":
                        replace = btr60pb_replace.Value;
                        chance = btr60pb_chance.Value;
                        break;
                    case "BMP1":
                        replace = bmp1_replace.Value;
                        chance = bmp1_chance.Value;
                        break;
                    case "BMP1P":
                        replace = bmp1p_replace.Value;
                        chance = bmp1p_chance.Value;
                        break;
                    case "BMP2":
                        replace = bmp2_replace.Value;
                        chance = bmp2_chance.Value;
                        break;
                    case "PT76":
                        replace = pt76_replace.Value;
                        chance = m923_chance.Value;
                        break;
                    case "T55A":
                        replace = t55a_replace.Value;
                        chance = t55a_chance.Value;
                        break;
                    case "T72M":
                        replace = t72m_replace.Value;
                        chance = t72mgills_chance.Value;
                        break;
                    case "T72MGILLS":
                        replace = t72mgills_replace.Value;
                        chance = t72mgills_chance.Value;
                        break;
                    case "T72A":
                        replace = t72m1_replace.Value;
                        chance = t72m1_chance.Value;
                        break;
                    // SA
                    case "STATIC_9K111_SA":
                        replace = spigot_sa_replace.Value;
                        chance = spigot_sa_chance.Value;
                        break;
                    case "URAL375D_SA":
                        replace = ural375d_sa_replace.Value;
                        chance = ural375d_sa_chance.Value;
                        break;
                    case "BRDM2_SA":
                        replace = brdm2_sa_replace.Value;
                        chance = brdm2_sa_chance.Value;
                        break;
                    case "BTR60PB_SA":
                        replace = btr60pb_sa_replace.Value;
                        chance = btr60pb_sa_chance.Value;
                        break;
                    case "BMP1_SA":
                        replace = bmp1_sa_replace.Value;
                        chance = bmp1_sa_chance.Value;
                        break;
                    case "BMP1P_SA":
                        replace = bmp1p_sa_replace.Value;
                        chance = bmp1p_sa_chance.Value;
                        break;
                    case "BMP2_SA":
                        replace = bmp2_sa_replace.Value;
                        chance = bmp2_sa_chance.Value;
                        break;
                    case "T62":
                        replace = t62_replace.Value;
                        chance = t62_chance.Value;
                        break;
                    case "T64A":
                        replace = t64a_replace.Value;
                        chance = t64a_chance.Value;
                        break;
                    case "T80B":
                        replace = t80b_replace.Value;
                        chance = t80b_chance.Value;
                        break;
                    default:
                        MelonLoader.MelonLogger.Warning("Found a vehicle without a case! Its ID is: " + __result + ". Ignoring.");
                        failed = true;
                        break;
                }
                if (UnityEngine.Random.Range(1, 100) <= chance && !failed)
                {
                    MelonLoader.MelonLogger.Msg("Transformed a " + __result + " into a " + replace + "!");
                    __result = replace;
                }
            }
        }
    }
}
