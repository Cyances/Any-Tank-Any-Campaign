using MelonLoader;
using HarmonyLib;
using ATAC;

[assembly: MelonInfo(typeof(ATACMod), "Any Tank Any Campaign", "1.1.4", "Cyance and Fractal")]
[assembly: MelonGame("Radian Simulations LLC", "GHPC")]

namespace ATAC
{
    public class ATACMod : MelonMod
    {
        public static MelonPreferences_Category cfg;
        public static MelonPreferences_Entry<bool> campaignMission;

        public static MelonPreferences_Entry<string> tow_replace;
        public static MelonPreferences_Entry<int> tow_chance;
        public static MelonPreferences_Entry<string> m151_replace;
        public static MelonPreferences_Entry<int> m151_chance;
        public static MelonPreferences_Entry<string> m151tow_replace;
        public static MelonPreferences_Entry<int> m151tow_chance;
        public static MelonPreferences_Entry<string> m923_replace;
        public static MelonPreferences_Entry<int> m923_chance;
        public static MelonPreferences_Entry<string> m113_replace;
        public static MelonPreferences_Entry<int> m113_chance;
        public static MelonPreferences_Entry<string> m2_replace;
        public static MelonPreferences_Entry<int> m2_chance;
        public static MelonPreferences_Entry<string> m2alt_replace;
        public static MelonPreferences_Entry<int> m2alt_chance;
        public static MelonPreferences_Entry<string> m60a1_replace;
        public static MelonPreferences_Entry<int> m60a1_chance;
        public static MelonPreferences_Entry<string> m60a1aos_replace;
        public static MelonPreferences_Entry<int> m60a1aos_chance;
        public static MelonPreferences_Entry<string> m60a1risep77_replace;
        public static MelonPreferences_Entry<int> m60a1risep77_chance;
        public static MelonPreferences_Entry<string> m60a1risep_replace;
        public static MelonPreferences_Entry<int> m60a1risep_chance;
        public static MelonPreferences_Entry<string> m60a3_replace;
        public static MelonPreferences_Entry<int> m60a3_chance;
        public static MelonPreferences_Entry<string> m60a3tts_replace;
        public static MelonPreferences_Entry<int> m60a3tts_chance;
        public static MelonPreferences_Entry<string> m1_replace;
        public static MelonPreferences_Entry<int> m1_chance;
        public static MelonPreferences_Entry<string> m1ip_replace;
        public static MelonPreferences_Entry<int> m1ip_chance;

        public static MelonPreferences_Entry<string> m113g_replace;
        public static MelonPreferences_Entry<int> m113g_chance;
        public static MelonPreferences_Entry<string> mardera1_replace;
        public static MelonPreferences_Entry<int> mardera1_chance;
        public static MelonPreferences_Entry<string> mardera1noatgm_replace;
        public static MelonPreferences_Entry<int> mardera1noatgm_chance;
        public static MelonPreferences_Entry<string> mardera1plus_replace;
        public static MelonPreferences_Entry<int> mardera1plus_chance;
        public static MelonPreferences_Entry<string> leo1a1_replace;
        public static MelonPreferences_Entry<int> leo1a1_chance;
        public static MelonPreferences_Entry<string> leo1a1a2_replace;
        public static MelonPreferences_Entry<int> leo1a1a2_chance;
        public static MelonPreferences_Entry<string> leo1a1a3_replace;
        public static MelonPreferences_Entry<int> leo1a1a3_chance;
        public static MelonPreferences_Entry<string> leo1a1a4_replace;
        public static MelonPreferences_Entry<int> leo1a1a4_chance;

        public static MelonPreferences_Entry<string> spg9_replace;
        public static MelonPreferences_Entry<int> spg9_chance;
        public static MelonPreferences_Entry<string> spigot_replace;
        public static MelonPreferences_Entry<int> spigot_chance;
        public static MelonPreferences_Entry<string> uaz469_replace;
        public static MelonPreferences_Entry<int> uaz469_chance;
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
        public static MelonPreferences_Entry<string> t54a_replace;
        public static MelonPreferences_Entry<int> t54a_chance;
        public static MelonPreferences_Entry<string> t55a_replace;
        public static MelonPreferences_Entry<int> t55a_chance;
        public static MelonPreferences_Entry<string> t72_replace;
        public static MelonPreferences_Entry<int> t72_chance;
        public static MelonPreferences_Entry<string> t72lem_replace;
        public static MelonPreferences_Entry<int> t72lem_chance;
        public static MelonPreferences_Entry<string> t72uv1_replace;
        public static MelonPreferences_Entry<int> t72uv1_chance;
        public static MelonPreferences_Entry<string> t72m_replace;
        public static MelonPreferences_Entry<int> t72m_chance;
        public static MelonPreferences_Entry<string> t72mgills_replace;
        public static MelonPreferences_Entry<int> t72mgills_chance;
        public static MelonPreferences_Entry<string> t72uv2_replace;
        public static MelonPreferences_Entry<int> t72uv2_chance;
        public static MelonPreferences_Entry<string> t72m1_replace;
        public static MelonPreferences_Entry<int> t72m1_chance;

        public static MelonPreferences_Entry<string> spg9_sa_replace;
        public static MelonPreferences_Entry<int> spg9_sa_chance;
        public static MelonPreferences_Entry<string> spigot_sa_replace;
        public static MelonPreferences_Entry<int> spigot_sa_chance;
        public static MelonPreferences_Entry<string> ural375d_sa_replace;
        public static MelonPreferences_Entry<int> ural375d_sa_chance;
        public static MelonPreferences_Entry<string> brdm2_sa_replace;
        public static MelonPreferences_Entry<int> brdm2_sa_chance;
        public static MelonPreferences_Entry<string> btr60pb_sa_replace;
        public static MelonPreferences_Entry<int> btr60pb_sa_chance;
        public static MelonPreferences_Entry<string> btr70_replace;
        public static MelonPreferences_Entry<int> btr70_chance;
        public static MelonPreferences_Entry<string> bmp1_sa_replace;
        public static MelonPreferences_Entry<int> bmp1_sa_chance;
        public static MelonPreferences_Entry<string> bmp1p_sa_replace;
        public static MelonPreferences_Entry<int> bmp1p_sa_chance;
        public static MelonPreferences_Entry<string> bmp2_sa_replace;
        public static MelonPreferences_Entry<int> bmp2_sa_chance;
        public static MelonPreferences_Entry<string> t62_replace;
        public static MelonPreferences_Entry<int> t62_chance;
        public static MelonPreferences_Entry<string> t64r_replace;
        public static MelonPreferences_Entry<int> t64r_chance;
        public static MelonPreferences_Entry<string> t64a74_replace;
        public static MelonPreferences_Entry<int> t64a74_chance;
        public static MelonPreferences_Entry<string> t64a79_replace;
        public static MelonPreferences_Entry<int> t64a79_chance;
        public static MelonPreferences_Entry<string> t64a81_replace;
        public static MelonPreferences_Entry<int> t64a81_chance;
        public static MelonPreferences_Entry<string> t64a_replace;//obr. 1983
        public static MelonPreferences_Entry<int> t64a_chance;
        public static MelonPreferences_Entry<string> t64a84_replace;
        public static MelonPreferences_Entry<int> t64a84_chance;
        public static MelonPreferences_Entry<string> t64b_replace;
        public static MelonPreferences_Entry<int> t64b_chance;
        public static MelonPreferences_Entry<string> t80b_replace;
        public static MelonPreferences_Entry<int> t80b_chance;

        public override void OnInitializeMelon()
        {
            cfg = MelonPreferences.CreateCategory("ATAC Config");
            campaignMission = cfg.CreateEntry("Playing Campaign", false);
            campaignMission.Description = "Set to true if you are playing Campaign, false if Instant Action";

            tow_replace = cfg.CreateEntry("TOW Launcher replacement", "STATIC_TOW");
            tow_replace.Description = "////USA////";
            tow_chance = cfg.CreateEntry("TOW Launcher replacement chance", 100);

            m151_replace = cfg.CreateEntry("M151 replacement", "M151");
            m151_chance = cfg.CreateEntry("M151 replacement chance", 100);
            m151tow_replace = cfg.CreateEntry("M151 TOW replacement", "M151M232");
            m151tow_chance = cfg.CreateEntry("M151 TOW replacement chance", 100);
            m923_replace = cfg.CreateEntry("M923 replacement", "M923");
            m923_chance = cfg.CreateEntry("M923 replacement chance", 100);
            m113_replace = cfg.CreateEntry("M113 replacement", "M2BRADLEY");
            m113_chance = cfg.CreateEntry("M113 replacement chance", 100);
            m2_replace = cfg.CreateEntry("M2 replacement", "M2BRADLEY");
            m2_chance = cfg.CreateEntry("M2 replacement chance", 100);
            m2alt_replace = cfg.CreateEntry("M2 (Alt) replacement", "M2BRADLEY(ALT)");
            m2alt_chance = cfg.CreateEntry("M2 (Alt) replacement chance", 100);
            m60a1_replace = cfg.CreateEntry("M60A1 replacement", "M60A1");
            m60a1_chance = cfg.CreateEntry("M60A1 replacement chance", 100);
            m60a1aos_replace = cfg.CreateEntry("M60A1 AOS replacement", "M60A1AOS");
            m60a1aos_chance = cfg.CreateEntry("M60A1 AOS replacement chance", 100);
            m60a1risep77_replace = cfg.CreateEntry("M60A1 RISE replacement", "M60A1RISEP77");
            m60a1risep77_chance = cfg.CreateEntry("M60A1 RISE replacement chance", 100);
            m60a1risep_replace = cfg.CreateEntry("M60A1 RISE(P) replacement", "M60A1RISEP");
            m60a1risep_chance = cfg.CreateEntry("M60A1 RISE(P) replacement chance", 100);
            m60a3_replace = cfg.CreateEntry("M60A3 replacement", "M60A3");
            m60a3_chance = cfg.CreateEntry("M60A3 replacement chance", 100);
            m60a3tts_replace = cfg.CreateEntry("M60A3 TTS replacement", "M60A3TTS");
            m60a3tts_chance = cfg.CreateEntry("M60A3 TTS replacement chance", 100);
            m1_replace = cfg.CreateEntry("M1 replacement", "M1");
            m1_chance = cfg.CreateEntry("M1 replacement chance", 100);
            m1ip_replace = cfg.CreateEntry("M1IP replacement", "M1IP");
            m1ip_chance = cfg.CreateEntry("M1IP replacement chance", 100);

            m113g_replace = cfg.CreateEntry("M113G replacement", "M113G");
            m113g_replace.Description = "////FRG////";
            m113g_chance = cfg.CreateEntry("M113G replacement chance", 100);

            mardera1_replace = cfg.CreateEntry("Marder A1 replacement", "MARDERA1");
            mardera1_chance = cfg.CreateEntry("Marder A1 replacement chance", 100);
            mardera1noatgm_replace = cfg.CreateEntry("Marder A1 (No ATGM) replacement", "MARDERA1_NO_ATGM");
            mardera1noatgm_chance = cfg.CreateEntry("Marder A1 (No ATGM) replacement chance", 100);
            mardera1plus_replace = cfg.CreateEntry("Marder A1+ replacement", "MARDERA1PLUS");
            mardera1plus_chance = cfg.CreateEntry("Marder A1+ replacement chance", 100);
            leo1a1_replace = cfg.CreateEntry("Leopard 1A1 replacement", "LEO1A1");
            leo1a1_chance = cfg.CreateEntry("Leopard 1A1 replacement chance", 100);
            leo1a1a2_replace = cfg.CreateEntry("Leopard 1A1A2 replacement", "LEO1A1A2");
            leo1a1a2_chance = cfg.CreateEntry("Leopard 1A1A2 replacement chance", 100);
            leo1a1a3_replace = cfg.CreateEntry("Leopard 1A1A3 replacement", "LEO1A1A3");
            leo1a1a3_chance = cfg.CreateEntry("Leopard 1A1A3 replacement chance", 100);
            leo1a1a4_replace = cfg.CreateEntry("Leopard 1A1A4 replacement", "LEO1A1A4");
            leo1a1a4_chance = cfg.CreateEntry("Leopard 1A1A4 replacement chance", 100);

            spg9_replace = cfg.CreateEntry("SPG-9 replacement", "STATIC_SPG9");
            spg9_replace.Description = "////GDR////";
            spg9_chance = cfg.CreateEntry("SPG-9 replacement chance", 100);

            spigot_replace = cfg.CreateEntry("9K111 Launcher replacement", "STATIC_9K111");
            spigot_chance = cfg.CreateEntry("9K111 Launcher replacement chance", 100);
            uaz469_replace = cfg.CreateEntry("UAZ-469 replacement", "UAZ469");
            uaz469_chance = cfg.CreateEntry("UAZ-469 replacement chance", 100);
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
            t54a_replace = cfg.CreateEntry("T-54A replacement", "T54A");
            t54a_chance = cfg.CreateEntry("T-54A replacement chance", 100);
            t55a_replace = cfg.CreateEntry("T-55A replacement", "T72GILLS");
            t55a_chance = cfg.CreateEntry("T-55A replacement chance", 100);
            t72_replace = cfg.CreateEntry("T-72 replacement", "T72");
            t72_chance = cfg.CreateEntry("T-72 replacement chance", 100);
            t72lem_replace = cfg.CreateEntry("T-72 LEM replacement", "T72ULEM");
            t72lem_chance = cfg.CreateEntry("T-72 LEM replacement chance", 100);
            t72uv1_replace = cfg.CreateEntry("T-72 UV1 replacement", "T72UV1");
            t72uv1_chance = cfg.CreateEntry("T-72 UV1 replacement chance", 100);
            t72m_replace = cfg.CreateEntry("T-72M replacement", "T72M1");
            t72m_chance = cfg.CreateEntry("T-72M replacement chance", 100);
            t72mgills_replace = cfg.CreateEntry("T-72M Gills replacement", "T72M1");
            t72mgills_chance = cfg.CreateEntry("T-72M Gills replacement chance", 100);
            t72uv2_replace = cfg.CreateEntry("T-72 UV2 replacement", "T72UV2");
            t72uv2_chance = cfg.CreateEntry("T-72 UV2 replacement chance", 100);
            t72m1_replace = cfg.CreateEntry("T-72M1 replacement", "T72M1");
            t72m1_chance = cfg.CreateEntry("T-72M1 replacement chance", 100);

            spg9_sa_replace = cfg.CreateEntry("SA SPG-9 replacement", "STATIC_SPG9_SA");
            spg9_sa_replace.Description = "////USSR////";
            spg9_sa_chance = cfg.CreateEntry("SA SPG-9 replacement chance", 100);

            spigot_sa_replace = cfg.CreateEntry("SA 9K111 Launcher replacement", "STATIC_9K111_SA");
            spigot_sa_chance = cfg.CreateEntry("SA 9K111 Launcher replacement chance", 100);
            ural375d_sa_replace = cfg.CreateEntry("SA Ural-375D", "URAL375D_SA");
            ural375d_sa_chance = cfg.CreateEntry("SA Ural-375D replacement chance", 100);
            brdm2_sa_replace = cfg.CreateEntry("SA BRDM2 replacement", "BRDM2_SA");
            brdm2_sa_chance = cfg.CreateEntry("SA BRDM2 replacement chance", 100);
            btr60pb_sa_replace = cfg.CreateEntry("SA BTR-60PB replacement", "BTR60PB_SA");
            btr60pb_sa_chance = cfg.CreateEntry("SA BTR-60PB replacement chance", 100);
            btr70_replace = cfg.CreateEntry("SA BTR-70 replacement", "BTR70");
            btr70_chance = cfg.CreateEntry("SA BTR-70 replacement chance", 100);
            bmp1_sa_replace = cfg.CreateEntry("SA BMP-1 replacement", "BMP1P_SA");
            bmp1_sa_chance = cfg.CreateEntry("SA BMP-1 replacement chance", 100);
            bmp1p_sa_replace = cfg.CreateEntry("SA BMP-1P replacement", "BMP1P_SA");
            bmp1p_sa_chance = cfg.CreateEntry("SA BMP-1P replacement chance", 100);
            bmp2_sa_replace = cfg.CreateEntry("SA BMP-2 replacement", "BMP2_SA");
            bmp2_sa_chance = cfg.CreateEntry("SA BMP-2 replacement chance", 100);
            t62_replace = cfg.CreateEntry("SA T-62 replacement", "T62");
            t62_chance = cfg.CreateEntry("SA T-62 replacement chance", 100);
            t64r_replace = cfg.CreateEntry("SA T-64R replacement", "T64R");
            t64r_chance = cfg.CreateEntry("SA T-64R replacement chance", 100);
            t64a74_replace = cfg.CreateEntry("SA T-64A obr74 replacement", "T64A74");
            t64a74_chance = cfg.CreateEntry("SA T-64A obr74 replacement chance", 100);
            t64a79_replace = cfg.CreateEntry("SA T-64A obr79 replacement", "T64A79");
            t64a79_chance = cfg.CreateEntry("SA T-64A obr79 replacement chance", 100);
            t64a81_replace = cfg.CreateEntry("SA T-64A obr81 replacement", "T64A81");
            t64a81_chance = cfg.CreateEntry("SA T-64A obr81 replacement chance", 100);
            t64a_replace = cfg.CreateEntry("SA T-64A replacement", "T64B");
            t64a_chance = cfg.CreateEntry("SA T-64A replacement chance", 100);
            t64a84_replace = cfg.CreateEntry("SA T-64A obr84 replacement", "T64A84");
            t64a84_chance = cfg.CreateEntry("SA T-64A obr84 replacement chance", 100);
            t64b_replace = cfg.CreateEntry("SA T-64B replacement", "T64B");
            t64b_chance = cfg.CreateEntry("SA T-64B replacement chance", 100);
            t80b_replace = cfg.CreateEntry("SA T-80B replacement", "T80B");
            t80b_chance = cfg.CreateEntry("SA T-80B replacement chance", 100);
        }


        [HarmonyPatch(typeof(GHPC.Mission.DynamicMissionComposer), "GetFirstRegisteredKeyForSpawnPoint")]
        public static class ReplaceUnits
        {

            private static void Postfix(GHPC.Mission.DynamicMissionComposer __instance, ref string __result)
            {
                if (campaignMission.Value)
                {
                    //Add a check in the future to check if the config is enabled for replacing campaign units
                    //MelonLoader.MelonLogger.Msg("Enabled for replacement of campaign units");

                    string replace = null;
                    int chance = 0;
                    bool failed = false;
                    switch (__result)
                    {
                        // USA
                        case "STATIC_TOW":
                            replace = tow_replace.Value;
                            chance = tow_chance.Value;
                            break;
                        case "M151":
                            replace = m151_replace.Value;
                            chance = m151_chance.Value;
                            break;
                        case "M151M232":
                            replace = m151tow_replace.Value;
                            chance = m151tow_chance.Value;
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
                        case "M2BRADLEY(ALT)":
                            replace = m2alt_replace.Value;
                            chance = m2alt_chance.Value;
                            break;
                        case "M60A1":
                            replace = m60a1_replace.Value;
                            chance = m60a1_chance.Value;
                            break;
                        case "M60A1AOS":
                            replace = m60a1aos_replace.Value;
                            chance = m60a1aos_chance.Value;
                            break;
                        case "M60A1RISEP77":
                            replace = m60a1risep77_replace.Value;
                            chance = m60a1risep77_chance.Value;
                            break;
                        case "M60A1RISEP":
                            replace = m60a1risep_replace.Value;
                            chance = m60a1risep_chance.Value;
                            break;
                        case "M60A3":
                            replace = m60a3_replace.Value;
                            chance = m60a3_chance.Value;
                            break;
                        case "M60A3TTS":
                            replace = m60a3tts_replace.Value;
                            chance = m60a3tts_chance.Value;
                            break;
                        case "M1":
                            replace = m1_replace.Value;
                            chance = m1_chance.Value;
                            break;
                        case "M1IP":
                            replace = m1ip_replace.Value;
                            chance = m1ip_chance.Value;
                            break;
                        // FRG
                        case "M113G":
                            replace = m113g_replace.Value;
                            chance = m113g_chance.Value;
                            break;
                        case "MARDERA1":
                            replace = mardera1_replace.Value;
                            chance = mardera1_chance.Value;
                            break;
                        case "MARDERA1_NO_ATGM":
                            replace = mardera1noatgm_replace.Value;
                            chance = mardera1noatgm_chance.Value;
                            break;
                        case "MARDERA1PLUS":
                            replace = mardera1plus_replace.Value;
                            chance = mardera1plus_chance.Value;
                            break;
                        case "LEO1A1":
                            replace = leo1a1_replace.Value;
                            chance = leo1a1_chance.Value;
                            break;
                        case "LEO1A1A2":
                            replace = leo1a1a2_replace.Value;
                            chance = leo1a1a2_chance.Value;
                            break;
                        case "LEO1A1A3":
                            replace = leo1a1a3_replace.Value;
                            chance = leo1a1a3_chance.Value;
                            break;
                        case "LEO1A1A4":
                            replace = leo1a1a4_replace.Value;
                            chance = leo1a1a4_chance.Value;
                            break;
                        // GDR
                        case "STATIC_SPG9":
                            replace = spg9_replace.Value;
                            chance = spg9_chance.Value;
                            break;
                        case "STATIC_9K111":
                            replace = spigot_replace.Value;
                            chance = spigot_chance.Value;
                            break;
                        case "UAZ469":
                            replace = uaz469_replace.Value;
                            chance = uaz469_chance.Value;
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
                        case "PT76B":
                            replace = pt76_replace.Value;
                            chance = pt76_chance.Value;
                            break;
                        case "T54A":
                            replace = t54a_replace.Value;
                            chance = t54a_chance.Value;
                            break;
                        case "T55A":
                            replace = t55a_replace.Value;
                            chance = t55a_chance.Value;
                            break;
                        case "T72":
                            replace = t72_replace.Value;
                            chance = t72_chance.Value;
                            break;
                        case "T72ULEM":
                            replace = t72lem_replace.Value;
                            chance = t72lem_chance.Value;
                            break;
                        case "T72UV1":
                            replace = t72uv1_replace.Value;
                            chance = t72uv1_chance.Value;
                            break;
                        case "T72M":
                            replace = t72m_replace.Value;
                            chance = t72m_chance.Value;
                            break;
                        case "T72GILLS":
                            replace = t72mgills_replace.Value;
                            chance = t72mgills_chance.Value;
                            break;
                        case "T72UV2":
                            replace = t72uv2_replace.Value;
                            chance = t72uv2_chance.Value;
                            break;
                        case "T72M1":
                            replace = t72m1_replace.Value;
                            chance = t72m1_chance.Value;
                            break;
                        // USSR
                        case "STATIC_SPG9_SA":
                            replace = spg9_sa_replace.Value;
                            chance = spg9_sa_chance.Value;
                            break;
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
                        case "BTR70":
                            replace = btr70_replace.Value;
                            chance = btr70_chance.Value;
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
                        case "T64R":
                            replace = t64r_replace.Value;
                            chance = t64r_chance.Value;
                            break;
                        case "T64A74":
                            replace = t64a74_replace.Value;
                            chance = t64a74_chance.Value;
                            break;
                        case "T64A79":
                            replace = t64a79_replace.Value;
                            chance = t64a79_chance.Value;
                            break;
                        case "T64A81":
                            replace = t64a81_replace.Value;
                            chance = t64a81_chance.Value;
                            break;
                        case "T64A":
                            replace = t64a_replace.Value;
                            chance = t64a_chance.Value;
                            break;
                        case "T64A84":
                            replace = t64a84_replace.Value;
                            chance = t64a84_chance.Value;
                            break;
                        case "T64B":
                            replace = t64b_replace.Value;
                            chance = t64b_chance.Value;
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
}