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

[assembly: MelonInfo(typeof(ATACMod), "Any Tank Any Campaign Beta", "0.1.1", "Cyance")]
[assembly: MelonGame("Radian Simulations LLC", "GHPC")]

namespace ATAC
{
    public class ATACMod : MelonMod
    {
        public static MelonPreferences_Category cfg;
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
        public static MelonPreferences_Entry<string> t55a_replace;
        public static MelonPreferences_Entry<int> t55a_chance;
        public static MelonPreferences_Entry<string> t72m_replace;
        public static MelonPreferences_Entry<int> t72m_chance;
        public static MelonPreferences_Entry<string> t72mgills_replace;
        public static MelonPreferences_Entry<int> t72mgills_chance;
        public static MelonPreferences_Entry<string> t72m1_replace;
        public static MelonPreferences_Entry<int> t72m1_chance;

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
        public static MelonPreferences_Entry<string> t64a_replace;
        public static MelonPreferences_Entry<int> t64a_chance;
        public override void OnInitializeMelon()
        {
            cfg = MelonPreferences.CreateCategory("ATAC Config");
            m923_replace = cfg.CreateEntry("M923 replacement", "M923");
            m923_replace.Description = "////NATO////";
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

            ural375d_replace = cfg.CreateEntry("Ural-375D replacement", "URAL375D");
            ural375d_replace.Description = "////NVA////";
            ural375d_chance = cfg.CreateEntry("Ural-375D replacement chance", 100);
            brdm2_replace = cfg.CreateEntry("BRDM2 replacement", "BRDM2");
            brdm2_chance = cfg.CreateEntry("BRDM2 replacement chance", 100);
            btr60pb_replace = cfg.CreateEntry("BTR-60PB replacement", "BTR60PB");
            btr60pb_chance = cfg.CreateEntry("BTR-60PB replacement chance", 100);
            bmp1_replace = cfg.CreateEntry("BMP-1 replacement", "BMP1");
            bmp1_chance = cfg.CreateEntry("BMP-1 replacement chance", 100);
            bmp1p_replace = cfg.CreateEntry("BMP-1P replacement", "BMP1P");
            bmp1p_chance = cfg.CreateEntry("BMP-1P replacement chance", 100);
            t55a_replace = cfg.CreateEntry("T-55A replacement", "T72MGILLS");
            t55a_chance = cfg.CreateEntry("T-55A replacement chance", 100);
            t72m_replace = cfg.CreateEntry("T-72M replacement", "T72A");
            t72m_chance = cfg.CreateEntry("T-72M replacement chance", 100);
            t72mgills_replace = cfg.CreateEntry("T-72M Gills replacement", "T72A");
            t72mgills_chance = cfg.CreateEntry("T-72M Gills replacement chance", 100);
            t72m1_replace = cfg.CreateEntry("T-72M1 replacement", "T72A");
            t72m1_chance = cfg.CreateEntry("T-72M1 replacement chance", 100);

            ural375d_sa_replace = cfg.CreateEntry("SA Ural-375D", "URAL375D_SA");
            ural375d_sa_replace.Description = "////SA////";
            ural375d_sa_chance = cfg.CreateEntry("SA Ural-375D replacement chance", 100);
            brdm2_sa_replace = cfg.CreateEntry("SA BRDM2 replacement", "BRDM2_SA");
            brdm2_sa_chance = cfg.CreateEntry("SA BRDM2 replacement chance", 100);
            btr60pb_sa_replace = cfg.CreateEntry("SA BTR-60PB replacement", "BTR60PB_SA");
            btr60pb_sa_chance = cfg.CreateEntry("SA BTR-60PB replacement chance", 100);
            bmp1_sa_replace = cfg.CreateEntry("SA BMP-1 replacement", "BMP2_SA");
            bmp1_sa_chance = cfg.CreateEntry("SA BMP-1 replacement chance", 100);
            bmp1p_sa_replace = cfg.CreateEntry("SA BMP-1P replacement", "BMP2_SA");
            bmp1p_sa_chance = cfg.CreateEntry("SA BMP-1P replacement chance", 100);
            t64a_replace = cfg.CreateEntry("SA T-64A replacement", "T64A");
            t64a_chance = cfg.CreateEntry("SA T-64A replacement chance", 100);
        }

        [HarmonyPatch(typeof(GHPC.Mission.DynamicMissionComposer), "GetFirstRegisteredKeyForSpawnPoint")]
        public static class ReplaceUnits
        {
            private static void Postfix(GHPC.Mission.DynamicMissionComposer __instance, ref string __result)
            {
                ////NATO
                bool is_M923 = __result == "M923";
                if (is_M923 && UnityEngine.Random.Range(1, 100) <= m923_chance.Value)
                { 
                    __result = m923_replace.Value;
                }
                
                bool is_M113 = __result == "M113";
                if (is_M113 && UnityEngine.Random.Range(1, 100) <= m113_chance.Value)
                {
                    __result = m113_replace.Value;
                }

                bool is_M2 = __result == "M2BRADLEY";
                if (is_M2 && UnityEngine.Random.Range(1, 100) <= m2_chance.Value)
                {
                    __result = m2_replace.Value;
                }

                bool is_M60A1 = __result == "M60A1RISEP";
                if (is_M60A1 && UnityEngine.Random.Range(1, 100) <= m60a1_chance.Value)
                {
                    __result = m60a1_replace.Value;
                }

                bool is_M60A3 = __result == "M60A3TTS";
                if (is_M60A3 && UnityEngine.Random.Range(1, 100) <= m60a3_chance.Value)
                {
                    __result = m60a3_replace.Value;
                }

                bool is_M1 = __result == "M1";
                if (is_M1 && UnityEngine.Random.Range(1, 100) <= m1_chance.Value)
                {
                    __result = m1_replace.Value;
                }

                bool is_M1IP = __result == "M1IP";
                if (is_M1IP && UnityEngine.Random.Range(1, 100) <= m1ip_chance.Value)
                {
                    __result = m1ip_replace.Value;
                }

                ////NVA
                bool is_URAL375D = __result == "URAL375D";
                if (is_URAL375D && UnityEngine.Random.Range(1, 100) <= ural375d_chance.Value)
                {
                    __result = ural375d_replace.Value;
                }
                bool is_BRDM2 = __result == "BRDM2";
                if (is_BRDM2 && UnityEngine.Random.Range(1, 100) <= brdm2_chance.Value)
                {
                    __result = brdm2_replace.Value;
                }

                bool is_BTR60 = __result == "BTR60PB";
                if (is_BTR60 && UnityEngine.Random.Range(1, 100) <= btr60pb_chance.Value)
                {
                    __result = btr60pb_replace.Value;
                }

                bool is_BMP1 = __result == "BMP1";
                if (is_BMP1 && UnityEngine.Random.Range(1, 100) <= bmp1_chance.Value)
                {
                    __result = bmp1_replace.Value;
                }

                bool is_BMP1P = __result == "BMP1P";
                if (is_BMP1P && UnityEngine.Random.Range(1, 100) <= bmp1p_chance.Value)
                {
                    __result = bmp1p_replace.Value;
                }

                bool is_T55A = __result == "T55A";
                if (is_T55A && UnityEngine.Random.Range(1, 100) <= t55a_chance.Value)
                {
                    __result = t55a_replace.Value;
                }

                bool is_T72M = __result == "T72M";
                if (is_T72M && UnityEngine.Random.Range(1, 100) <= t72m_chance.Value)
                {
                    __result = t72m_replace.Value;
                }

                bool is_T72MGILLS = __result == "T72MGILLS";
                if (is_T72MGILLS && UnityEngine.Random.Range(1, 100) <= t72mgills_chance.Value)
                {
                    __result = t72mgills_replace.Value;
                }

                bool is_T72M1 = __result == "T72A";
                if (is_T72M1 && UnityEngine.Random.Range(1, 100) <= t72m1_chance.Value)
                {
                    __result = t72m1_replace.Value;
                }


                ////SA
                bool is_URAL375D_SA = __result == "URAL375D_SA";
                if (is_URAL375D_SA && UnityEngine.Random.Range(1, 100) <= ural375d_sa_chance.Value)
                {
                    __result = ural375d_sa_replace.Value;
                }
                bool is_BRDM2_SA = __result == "BRDM2_SA";
                if (is_BRDM2_SA && UnityEngine.Random.Range(1, 100) <= brdm2_sa_chance.Value)
                {
                    __result = brdm2_sa_replace.Value;
                }

                bool is_BTR60_SA = __result == "BTR60PB_SA";
                if (is_BTR60_SA && UnityEngine.Random.Range(1, 100) <= btr60pb_sa_chance.Value)
                {
                    __result = btr60pb_sa_replace.Value;
                }

                bool is_BMP1_SA = __result == "BMP1_SA";
                if (is_BMP1_SA && UnityEngine.Random.Range(1, 100) <= bmp1_sa_chance.Value)
                {
                    __result = bmp1_sa_replace.Value;
                }

                bool is_BMP1P_SA = __result == "BMP1P_SA";
                if (is_BMP1P_SA && UnityEngine.Random.Range(1, 100) <= bmp1p_sa_chance.Value)
                {
                    __result = bmp1p_sa_replace.Value;
                }

                bool is_T64A = __result == "T64A";
                if (is_T64A && UnityEngine.Random.Range(1, 100) <= t64a_chance.Value)
                {
                    __result = t64a_replace.Value;
                }
            }
        }
    }
}
