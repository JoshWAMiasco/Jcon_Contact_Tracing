using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softbox
{
    class JconMapClass
    {
        public static string[,] j100 = new string[4, 61]
        {
            {
                "A_J100", "A_RET", "+5V", "-5.2V", "CBIT_1", "CBIT_2","CBIT_3", "CBIT_4", "CBIT_5", "CBIT_6", "CBIT_7",
                "CBIT_8", "CBIT_9", "CBIT_10", "CBIT_11", "CBIT_12", "CBIT_13", "CBIT_14", "CBIT_15", "CBIT_16","CBIT_17",
                "CBIT_18", "CBIT_19", "CBIT_20", "CBIT_21", "CBIT_22", "CBIT_23", "CBIT_24", "CBIT_27", "CBIT_31", "CBIT_35",
                "A_RET", "TH_MTX_P1_D", "TH_MTX_P2_D", "TH_MTX_P3_D", "TH_MTX_P4_D", "TH_MTX_L1_D", "TH_MTX_L2_D",
                "UTH_S9_IC4", "UTH_S9_IC8", "UTH_S9_IC12", "UTH_S9_IC16", "UTH_S9_IC20", "UTH_S9_IC24", "UTH_S10_IC4",
                "UTH_S10_IC8", "UTH_S10_IC12", "UTH_S10_IC16", "UTH_S10_IC20", "UTH_S10_IC24", "DPS_1-2_LF", "DPS_1-2_LF",
                "DPS_1-2_RIPL", "DPS_3-4-LF", "DPS_3-4-LF", "EEPROM_DATA_2", "H_DATA", "EEPROM_DATA_3", "+12V", "-40V","A_RET"
            },

            {
                "B_J100", "A_RET", "+5V", "-5.2V", "APCBIT_1", "APCBIT_2", "APCBIT_3", "APCBIT_4", "APCBIT_5", "APCBIT_6",
                "APCBIT_7", "APCBIT_8", "APCBIT_9", "APCBIT_10", "APCBIT_11", "APCBIT_12", "APCBIT_13", "APCBIT_14",
                "APCBIT_15", "APCBIT_16", "APCBIT_17", "APCBIT_18", "APCBIT_19", "APCBIT_20", "APCBIT_21",
                "APCBIT_22", "APCBIT_23", "APCBIT_24", "CBIT_26", "CBIT_30", "CBIT_34", "APMTX_L1S_1-24", "TH_MTX_P1_C",
                "TH_MTX_P2_C", "TH_MTX_P3_C", "TH_MTX_P4_C", "TH_MTX_L1_C", "TH_MTX_L2_C", "TH_MTX_L2_C", "UTH_S9_IC7",
                "UTH_S9_IC11", "UTH_S9_IC15", "UTH_S9_IC19", "UTH_S9_IC23", "UTH_S10_IC3", "UTH_S10_IC7", "UTH_S10_IC11",
                "UTH_S10_IC15", "UTH_S10_IC19", "UTH_S10_IC23", "DPS_1_LS", "DPS_2_LS", "DPS_3-4_RIPL",
                "DPS_3_LS", "DPS_4_LS", "H_CLK_3", "H_REG_STB", "EEPROM_CLK_6", "12V", "40V", "A_RET"
            },

            {
                "C_J100", "A_RET", "+5V", "-5.2V", "AP1_G_S", "AP2_G_S", "AP3_G_S", "AP4_G_S", "AP5_G_S", "AP6_G_S",
                "AP7_G_S", "AP8_G_S", "AP9_G_S", "AP10_G_S", "AP11_G_S", "AP12_G_S", "AP13_G_S", "AP14_G_S", "AP15_G_S",
                "AP16_G_S", "AP17_G_S", "AP18_G_S", "AP19_G_S", "AP20_G_S", "AP21_G_S", "AP22_G_S", "AP23_G_S", "AP24_G_S",
                "CBIT_25", "CBIT_29", "CBIT_33", "APMTX_L1F_1-24", "TH_MTX_P1_B", "TH_MTX_P2_B", "TH_MTX_P3_B", "TH_MTX_P4_B",
                "TH_MTX_L1_B", "TH_MTX_L2_B", "UTH_S9_IC2", "UTH_S9_IC6", "UTH_S9_IC10", "UTH_S9_IC14", "UTH_S9_IC18",
                "UTH_S9_IC22", "UTH_S10_IC2", "UTH_S10_IC6", "UTH_S10_IC10", "UTH_S10_IC14", "UTH_S10_IC18", "UTH_S10_IC22",
                "DPS_1_HS", "DPS_2_HS", "DPS_1-2_RIPH", "DPS_3_HS", "DPS_4_HS", "A_RET", "H_RESET", "+5V_EEPROM",
                "APMTX_L2S_1-24", "-15V", "A_RET"
            },

            {
                "D_J100", "A_RET", "+5V", "-5.2V", "AP_1", "AP_2", "AP_3", "AP_4", "AP_5", "AP_6", "AP_7", "AP_8", "AP_9",
                "AP_10", "AP_11", "AP_12", "AP_13", "AP_14", "AP_15", "AP_16", "AP_17", "AP_18", "AP_19", "AP_20", "AP_21",
                "AP_22", "AP_23", "AP_24", "SA_DZ", "CBIT_28", "CBIT_32", "CBIT_36", "TH_MTX_P1_A", "TH_MTX_P2_A",
                "TH_MTX_P3_A", "TH_MTX_P4_A", "TH_MTX_L1_A", "TH_MTX_L2_A", "UTH_S9_IC1", "UTH_S9_IC5", "UTH_S9_IC9",
                "UTH_S9_IC13", "UTH_S9_IC17", "UTH_S9_IC21", "UTH_S10_IC1", "UTH_S10_IC5", "UTH_S10_IC9", "UTH_S10_IC13",
                "UTH_S10_IC17","UTH_S10_IC21", "DPS_1_HF", "DPS_2_HF", "DPS_3-4_RIPH", "DPS_3_HF", "DPS_4_HF", "H_EN_0",
                "A_RET", "EEPROM_EN_1", "APMTX_L2F_1-24", "+15V", "A_RET"
            }
        };
        public static string[,] j101 = new string[4, 61]
        {
           {
                "A_J101", "A_RET", "+5V", "-5.2V", "CBIT_49", "CBIT_50", "CBIT_51", "CBIT_52", "CBIT_53", "CBIT_54", "CBIT_55",
                "CBIT_56", "APMTX_L1S_49-72", "APMTX_L1F_49-72", "APMTX_L2S_49-72", "APTMX_L2F_49-72", "$$$16594", "NC_17A",
                "UTH_BUS_L1", "UTH_BUS_L2", "UTH_BUS_L3", "UTH_BUS_L4", "NC_22A", "WM5_AC_LO", "NC_24A", "NC_25A", "NC",
                "NC_27A", "UTH_S18_IC24", "UTH_S19_IC24", "UTH_S20_IC24", "A_RET", "TH_MTX_P1_H", "TH_MTX_P2_H", "TH_MTX_P3_H",
                "TH_MTX_P4_H", "TH_MTX_L1_H", "TH_MTX_L2_H", "DPS_5-6_RIPL", "UTH_S18_IC4", "UTH_S18_IC8", "UTH_S18_IC12",
                "UTH_S18_IC16", "UTH_S18_IC20", "UTH_S19_IC4", "UTH_S19_IC8", "UTH_S19_IC12", "UTH_S19_IC16", "UTH_S19_IC20",
                "UTH_S20_IC4", "UTH_S20_IC8", "UTH_S20_IC12", "UTH_S20_IC16", "UTH_S20_IC20", "DPS_5-6_LF", "DPS_5-6_LF",
                "DPS_7-8_LF", "DPS_7-8_LF", "+12V", "-40V", "A_RET"
            },

            {
                "B_J101", "A_RET", "+5V", "-5.2V", "APCBIT_49", "APCBIT_50", "APCBIT_51", "APCBIT_52", "APCBIT_53",
                "APCBIT_54", "APCBIT_55", "APCBIT_56", "APCBIT_57", "APCBIT_58", "APCBIT_59", "APCBIT_60", "APCBIT_61",
                "APCBIT_62", "APCBIT_63", "APCBIT_64", "APCBIT_65", "APCBIT_66", "APCBIT_67", "APCBIT_68", "APCBIT_69",
                "APCBIT_70", "APCBIT_72", "APCBIT_24", "UTH_S18_IC23", "UTH_S19_IC23", "UTH_S20_IC23", "A_RET", "TH_MTX_P1_G",
                "TH_MTX_P2_G", "TH_MTX_P3_G", "TH_MTX_P4_G", "TH_MTX_L1_G", "TH_MTX_L2_G", "DPS_7-8_RIPL", "UTH_S18_IC3",
                "UTH_S18_IC7", "UTH_S18_IC11", "UTH_S18_IC15", "UTH_S18_IC19", "UTH_S19_IC3", "UTH_S19_IC7", "UTH_S19_IC11",
                "UTH_S19_IC15", "UTH_S19_IC19", "UTH_S20_IC3", "UTH_S20_IC7", "UTH_S20_IC11", "UTH_S19_IC15", "UTH_S20_IC19",
                "DPS_5_LS", "DPS_6_LS", "DPS_7_LS", "DPS_8_LS", "+12V", "+40V", "A_RET"
            },

            {
                "C_J101", "A_RET", "+5V", "-5.2V", "AP49_G_S", "AP50_G_S", "AP51_G_S", "AP52_G_S", "AP53_G_S", "AP54_G_S",
                "AP55_G_S", "AP56_G_S", "AP57_G_S", "AP58_G_S", "AP59_G_S", "AP60_G_S", "AP61_G_S", "AP62_G_S", "AP63_G_S",
                "AP64_G_S", "AP65_G_S", "AP66_G_S", "AP67_G_S", "AP68_G_S", "AP69_G_S", "AP70_G_S", "AP71_G_S", "AP72_G_S",
                "NC_28C", "UTH_S18_IC22", "UTH_S19_IC22", "UTH_S20_IC22", "TH_MTX_P1_F", "TH_MTX_P2_F", "TH_MTX_P3_F",
                "TH_MTX_P4_F", "TH_MTX_L1_F", "TH_MTX_L2_F", "DPS_5-6_RIPH", "UTH_S18_IC2", "UTH_S18_IC6", "UTH_S18_IC10",
                "UTH_S18_IC14", "UTH_S18_IC18", "UTH_S19_IC2", "UTH_S19_IC6", "UTH_S19_IC10", "UTH_S19_IC14", "UTH_S19_IC18",
                "UTH_S20_IC2", "UTH_S20_IC6", "UTH_S20_IC10", "UTH_S20_IC14", "UTH_S20_IC18", "DPS_5_HS", "DPS_6_HS",
                "DPS_7_HS", "DPS_8_HS", "A_RET", "-15V", "A_RET"
            },

            {
                "D_J101", "A_RET", "+5V", "-5.2V", "AP_49", "AP_50", "AP_51", "AP_52", "AP_53", "AP_54", "AP_55", "AP_56",
                "AP_57", "AP_58", "AP_59", "AP_60", "AP_61", "AP_62", "AP_63", "AP_64", "AP_65", "AP_66", "AP_67", "AP_68",
                "AP_69", "AP_70", "AP_71", "AP_72", "NC_SA_DZ", "UTH_S18_IC21", "UTH_S19_IC21", "UTH_S20_IC21", "TH_MTX_P1_E",
                "TH_MTX_P2_E", "TH_MTX_P3_E", "TH_MTX_P4_E", "TH_MTX_L1_E", "TH_MTX_L2_E", "DPS_7-8_RIPH", "UTH_S18_IC1",
                "UTH_S18_IC5", "UTH_S18_IC9", "UTH_S18_IC13", "UTH_S18_IC17", "UTH_S19_IC1", "UTH_S19_IC5", "UTH_S19_IC9",
                "UTH_S19_IC13", "UTH_S19_IC17", "UTH_S20_IC1", "UTH_S20_IC5", "UTH_S20_IC9", "UTH_S20_IC13", "UTH_S20_IC17",
                "DPS_5_HF", "DPS_6_HF", "DPS_7_HF", "DPS_8_HF", "A_RET", "+15V", "A_RET"
            }
        };
        public static string[,] j102 = new string[4, 61]
        {
            {
                "A_J102", "A_RET", "+5V", "-5.2V", "WM5_AC_LO", "WM6_AC_LO", "WM7_AC_LO", "WM8_AC_LO", "A_RET", "WM_256V_HI",
                "A_RET", "CBIT_37", "CBIT_38", "CBIT_39", "CBIT_40", "CBIT_41", "CBIT_42", "CBIT_43", "CBIT_44", "CBIT_45",
                "CBIT_46", "CBIT_47", "CBIT_48", "UTH_S30_IC7", "UTH_S30_IC8", "UTH_S30_IC9", "UTH_S30_IC10", "UTH_S30_IC11",
                "UTH_S30_IC12", "UTH_S30_IC13", "UTH_S30_IC14", "UTH_S30_IC15", "UTH_S30_IC16", "UTH_S30_IC17", "NC_SA_DZ",
                "A_RET", "TMU_DIR_CH1", "A_RET", "TMU_DIR_CH2", "A_RET", "NC", "A_RET", "WM2_DC_HI", "WM2_DC_LO", "NC", "NC",
                "WM4_DC_LO", "APMTX_L1S_25-48", "NC", "WS2_LF", "WS2_LS", "MS_IC11", "WS4_GUARD", "WS4_LF", "WS4_LS",
                "UTH_S30_IC24", "PM2_TO_DUT*", "PM1_TO_DUT*", "+12V", "-40V", "A_RET"
            },

            {
                "B_J102", "A_RET", "+5V", "-5.2V", "WM1_AC_LO", "WM2_AC_LO", "WM3_AC_LO", "WM4_AC_LO", "A_RET", "A_RET",
                "A_RET", "APCBIT_25", "APCBIT_26", "APCBIT_27", "APCBIT_28", "APCBIT_29", "APCBIT_30", "APCBIT_31",
                "APCBIT_32", "APCBIT_33", "APCBIT_34", "APCBIT_35", "APCBIT_36", "APCBIT_37", "APCBIT_38", "APCBIT_39",
                "APCBIT_40", "APCBIT_41", "APCBIT_42", "APCBIT_43", "APCBIT_44", "APCBIT_45", "APCBIT_46", "APCBIT_47",
                "APCBIT_47", "TMU_IC1", "A_RET", "TMU_IC2", "A_RET", "TMU_IC3", "A_RET", "A_RET", "MS_IC1", "WM2_DC_RET",
                "MS_IC4", "MS_IC6", "WM4_DC_RET", "APMTX_L1F_25-48", "MS_IC7", "WS2_HF", "WS2_HS", "NC_51B", "NC_52B",
                "WS4_HF", "WS4_HS", "UTH_S30_IC23", "PM2_TO_DUT", "PM1_TO_DUT", "+12V", "+40V", "A_RET"
            },

            {
                "C_J102", "A_RET", "+5V", "-5.2V", "WM1_AC_HI", "WM2_AC_HI", "WM3_AC_HI", "WM4_AC_HI", "UTH_S30_IC2",
                "UTH_S30_IC4", "UTH_S30_IC6", "NC", "NC", "NC", "AP28_G_S", "AP29_G_S", "AP30_G_S", "AP31_G_S",
                "AP32_G_S", "AP33_G_S", "AP34_G_S", "AP35_G_S", "AP36_G_S", "AP37_G_S", "AP38_G_S", "AP39_G_S",
                "AP40_G_S", "AP41_G_S", "AP42_G_S", "AP43_G_S", "AP44_G_S", "AP45_G_S", "AP46_G_S", "AP47_G_S",
                "AP48_G_S", "A_RET", "TMU_BUFF_CH1", "A_RET", "TMU_BUFF_CH3", "A_RET", "TMU_IC5", "A_RET", "WM1_DC_RET",
                "MS_IC2", "WM3_DC_RET", "WM3_DC_LO", "APMTX_L2S_25-48", "WS1_HF", "WS1_HS", "MS_IC8", "MS_IC9", "WS3_HF",
                "WS3_HS", "UTH_S30_IC18", "UTH_S30_IC20", "UTH_S30_IC22", "PM2_FROM_DUT*", "PM1_FROM_DUT*", "A_RET", "15V",
                "A_RET"

            },

            {
                "D_J102", "A_RET", "+5V", "-5.2V", "WM5_AC_HI", "WM6_AC_HI", "WM7_AC_HI", "WM8_AC_HI", "UTH_S30_IC1",
                "UTH_S30_IC3", "UTH_S30_IC5", "NC", "NC", "AP_27", "AP_28", "AP_29", "AP_30", "AP_31", "AP_32", "AP_33",
                "AP_34", "AP_35", "AP_36", "AP_37", "AP_38", "AP_39", "AP_40", "AP_41", "AP_42", "AP_43", "AP_4", "AP_45",
                "AP_46", "NC", "NC", "NC", "A_RET", "TMU_BUFF_CH2", "A_RET", "NC", "A_RET", "A_RET", "WM1_DC_HI", "WM1_DC_LO",
                "NC", "WM3_DC_HI", "APMTX_L2F_25-48", "NC", "WS1_LS", "WS1_L", "NC", "WS3_LF", "WS3_LS", "NC", "NC", "NC",
                "PM2_FROM_DUT", "PM1_FROM_DUT", "A_RET", "+15V", "A_RET"
            }
        };
        public static string[,] j103 = new string[4, 61]
        {
            {
                "A_J103", "A_RET", "+5V", "-5.2V", "CBIT_57", "CBIT_58", "CBIT_59", "CBIT_60", "CBIT_61", "CBIT_62",
                "CBIT_63", "CBIT_64", "TMU_IC5", "MS_IC2", "AP_45", "NC", "$$$16594", "NC_17A", "NC", "NC", "NC",
                "NC_21A", "NC_22A", "WM5_AC_LO", "NC_24A", "NC_25A", "NC", "NC_27A", "NC_28A", "NC_29A", "UTH_S37_IC21",
                "UTH_S37_IC22", "UTH_S37_IC23", "UTH_S37_IC24", "NC_SA_DZ", "UTH_S37_IC4", "UTH_S37_IC8", "UTH_S37_IC12",
                "UTH_S37_IC16", "UTH_S37_IC20", "UTH_S38_IC4", "UTH_S38_IC8", "UTH_S38_IC12", "UTH_S38_IC16", "UTH_S38_IC20",
                "UTH_S39_IC4", "UTH_S39_IC8", "UTH_S39_IC12", "UTH_S39_IC16", "UTH_S39_IC20", "UTH_S40_IC4", "UTH_S40_IC12",
                "UTH_S40_IC16", "UTH_S40_IC20", "UTH_S40_IC24", "UTH_S38_IC24", "UTH_S39_IC24", "UTH_S40_IC8", "+12V",
                "-40V", "A_RET"
            },

            {
                "B_J103", "A_RET", "+5V", "-5.2V", "DPS_9 - 10_LF", "DPS_9_LS", "DPS_9_HS", "DPS_9_HF", "DPS_11 - 12_LF",
                "DPS_12_LS", "DPS_12_HS", "APCBIT_73", "APCBIT_74", "APCBIT_75", "APCBIT_76", "APCBIT_77", "APCBIT_78",
                "APCBIT_79", "APCBIT_80", "APCBIT_81", "APCBIT_82", "APCBIT_83", "APCBIT_84", "APCBIT_85", "APCBIT_86",
                "APCBIT_87", "APCBIT_88", "APCBIT_89", "APCBIT_90", "APCBIT_91", "APCBIT_92", "APCBIT_93", "APCBIT_94",
                "APCBIT_95", "APCBIT_96", "UTH_S37_IC3", "UTH_S37_IC7", "UTH_S37_IC11", "UTH_S37_IC15", "UTH_S37_IC19",
                "UTH_S38_IC3", "UTH_S38_IC7", "UTH_S38_IC11", "UTH_S38_IC15", "UTH_S38_IC19", "UTH_S39_IC3", "UTH_S39_IC7",
                "UTH_S39_IC11", "UTH_S39_IC15", "UTH_S39_IC1", "UTH_S40_IC3", "UTH_S40_IC7", "UTH_S40_IC11", "UTH_S40_IC15",
                "UTH_S40_IC19", "UTH_S40_IC23", "UTH_S38_IC23", "UTH_S39_IC23", "+12V", "+40V", "A_RET"
            },

            {
                "C_J103", "A_RET", "+5V", "-5.2V", "DPS_9-10_LF", "DPS_10_LS", "DPS_10_HS", "DPS_10_HF", "DPS_9-10_RIPL",
                "DPS_9-10_RIPH", "DPS_12_HF", "AP73_G_S", "AP74_G_S", "AP75_G_S", "AP76_G_S", "AP77_G_S", "AP78_G_S",
                "AP79_G_S", "AP80_G_S", "AP81_G_S", "AP82_G_S", "AP83_G_S", "AP84_G_S", "AP85_G_S", "AP86_G_S", "AP87_G_S",
                "AP88_G_S", "AP89_G_S", "AP90_G_S", "AP91_G_S", "AP92_G_S", "AP93_G_S", "AP94_G_S", "AP95_G_S", "AP96_G_S",
                "UTH_S37_IC2", "UTH_S37_IC6", "UTH_S37_IC10", "UTH_S37_IC14", "UTH_S37_IC18", "UTH_S38_IC2", "UTH_S38_IC6",
                "UTH_S38_IC10", "UTH_S38_IC14", "UTH_S38_IC18", "UTH_S39_IC2", "UTH_S39_IC6", "UTH_S39_IC10", "UTH_S39_IC14",
                "UTH_S39_IC18", "UTH_S40_IC2", "UTH_S40_IC6", "UTH_S40_IC10", "UTH_S40_IC14", "UTH_S40_IC18", "UTH_S40_IC22",
                "UTH_S38_IC22", "UHT_S39_IC22", "A_RET", "-15V", "A_RET"
            },

            {
                "D_J103", "A_RET", "+5V", "-5.2V", "DPS_11-12_LF", "DPS_11_LS", "DPS_11_HS", "DPS_11_HF", "DPS_11-12_RIPL",
                "DPS_11-12_RIPH", "NC_10D", "AP_73", "AP_74", "AP_75", "AP_76", "AP_77", "AP_78", "AP_79", "AP_80", "AP_81",
                "AP_82", "AP_83", "AP_84", "AP_85", "AP_86", "AP_87", "AP_88", "AP_89", "AP_90", "AP_91", "AP_92", "AP_93",
                "AP_94", "AP_95", "AP_96", "UTH_S37_IC1", "UTH_S37_IC5", "UTH_S37_IC9", "UTH_S37_IC13", "UTH_S37_IC17",
                "UTH_S38_IC1", "UTH_S38_IC5", "UTH_S38_IC9", "UTH_S38_IC13", "UTH_S38_IC17", "UTH_S39_IC1", "UTH_S39_IC5",
                "UTH_S39_IC9", "UTH_S39_IC13", "UTH_S39_IC17", "UTH_S40_IC1", "UTH_S40_IC5", "UTH_S40_IC9", "UTH_S40_IC13",
                "UTH_S40_IC17", "UTH_S40_IC21", "UTH_S38_IC21", "UTH_S39_IC21", "A_RET", "+15V", "A_RET"
            }
        };
        public static string[,] j201 = new string[4, 26]
        {
            {
                "A_J201", "NC_A1", "NC_A2", "NC_A3", "H_RET", "DP_48", "DP_46", "DP_44", "DP_42", "DP_40", "DP_38", "DP_36",
                "DP_34", "DP_32", "DP_30", "DP_28", "DP_26", "D_RET", "NC_A18", "A_RET", "VMS_1_MEASURE+",
                "VMS_1_MEASUREA_RET", "A_RET", "VMS_2_MEASURE+", "VMS_2_MEASUREA_RET", "A_RET"
            },

            {
                "B_J201", "NC_B1", "NC_B2", "NC_B3", "H_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET",
                "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "NC_B18", "A_RET", "A_RET", "A_RET", "A_RET", "A_RET",
                "A_RET", "A_RET",
            },

            {
                "C_201", "NC_C1", "NC_C2", "NC_C3",  "H_RET", "DP_47", "DP_45", "DP_43", "DP_41", "DP_39", "DP_37", "DP_35",
                "DP_33", "DP_31", "DP_29", "DP_27", "DP_25", "D_RET", "NC_C18", "A_RET", "VMS_1_SOURCE+", "VMS_1_SOURCEA_RET-",
                 "A_RET", "VMS_2_SOURCE+", "VMS_2_SOURCEA_RET", "A_RET"
            },

            {
                "D_201", "NC_D1", "NC_D2", "NC_D3", "H_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET",
                "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "NC_D18", "A_RET", "A_RET", "A_RET", "A_RET", "A_RET",
                "A_RET", "A_RET"
            }
        };
        public static string[,] j203 = new string[4, 26]
        {
            {
                "A_J203", "NC_A1", "NC_A2", "NC_A3", "D_RET", "DP_24", "DP_22", "DP_20", "DP_18", "UTH_S20_IC5", "DP_14",
                "DP_12", "DP_10", "DP_8", "DP_6", "DP_4", "DP_2", "D_RET", "NC_A18", "A_RET", "VMS_3_MEASURE+",
                "VMS_3_MEASUREA_RET", "A_RET", "VMS_4_MEASURE+", "VMS_4_MEASUREA_RE", "A_RET"
            },

            {
                "B_J203", "NC_B1", "NC_B2", "NC_B3", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET",
                "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "NC_B18", "A_RET", "A_RET", "A_RET",
                "A_RET", "A_RET", "A_RET", "A_RET"
            },

            {
                "C_J203", "NC_C1", "NC_C2", "NC_C3", "D_RET", "DP_23", "DP_21", "DP_19", "DP_17", "DP_15", "DP_13", "DP_11",
                "DP_9", "DP_7", "DP_5", "DP_3", "DP_1", "D_RET", "NC_C18", "A_RET", "VMS_3_SOURCE+", "VMS_3_SOURCEA_RET",
                "A_RET", "VMS_4_SOURCE+", "VMS_4_SOURCEA_RET", "A_RET"
            },

            {
                "D_J203", "NC_D1", "NC_D2", "NC_D3", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET",
                "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "D_RET", "NC_D18", "A_RET", "A_RET", "A_RET", "A_RET", "A_RET",
                "A_RET", "A_RET"

            }
        };
    }
}