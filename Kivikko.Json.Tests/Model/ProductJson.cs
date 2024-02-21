﻿namespace Kivikko.Json.Tests.Model;

public class ProductRoot
{
    public CatalogueProduct catalogue_product { get; set; }
}

public class CatalogueProduct
{
    public string id { get; set; }
    public string product_id { get; set; }
    public string ean { get; set; }
    public CharacteristicGroupList characteristic_group_list { get; set; }
    public bool isActive { get; set; }
    public Description long_desc { get; set; }
}

public class CharacteristicGroupList
{
    public List<CharacteristicGroup> characteristic_group { get; set; }
}

public class CharacteristicGroup
{
    public string id { get; set; }
    public string label { get; set; }
    public CharacteristicList characteristic_list { get; set; }
    public Dictionary<string, string> translation { get; set; }
}

public class CharacteristicList
{
    public List<Characteristic> characteristic { get; set; }
}

public class Characteristic
{
    public string id { get; set; }
    public string short_description { get; set; }
    public string long_description { get; set; }
    public string isVisible { get; set; }
    public Dictionary<string, string> translation { get; set; }
    public List<ValueId> valueIds { get; set; }
}

public class ValueId
{
    public string value_id { get; set; }
    public Dictionary<string, string> translation { get; set; }
}

public class Description
{
    public Dictionary<string, string> translation { get; set; }
}

public static class ProductJson
{
    public const string LV430880 = "{\"catalogue_product\":{\"id\":\"LV430880\",\"product_id\":\"LV430880\",\"ean\":\"3606480010248\",\"characteristic_group_list\":{\"characteristic_group\":[{\"id\":\"108\",\"label\":\"Main\",\"characteristic_list\":{\"characteristic\":[{\"id\":\"D_NEW_RANGE\",\"short_description\":\"Range\",\"long_description\":\"Range\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Range\",\"de-DE\":\"Baureihe\"},\"valueIds\":[{\"value_id\":\"COMPACT\",\"translation\":{\"en-GB\":\"ComPact\",\"de-DE\":\"ComPact\"}}]},{\"id\":\"D_PRODUCT_NAME\",\"short_description\":\"Product name\",\"long_description\":\"Product name\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Product name\",\"de-DE\":\"Produktname\"},\"valueIds\":[{\"value_id\":\"COMPACT_NSX\",\"translation\":{\"en-GB\":\"ComPact NSX\",\"de-DE\":\"ComPact NSX\"}}]},{\"id\":\"D_RANGE\",\"short_description\":\"Range of produc\",\"long_description\":\"Range of produc\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Range of produc\",\"de-DE\":\"Produktbereich\"},\"valueIds\":[{\"value_id\":\"COMPACT_NSX100...250\",\"translation\":{\"en-GB\":\"ComPact NSX100...250\",\"de-DE\":\"ComPact NSX100 - 250\"}}]},{\"id\":\"D_DEVICE_SHORT_NAME\",\"short_description\":\"Device short name\",\"long_description\":\"Device short name\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Device short name\",\"de-DE\":\"Kurzbezeichnung des Geräts\"},\"valueIds\":[{\"value_id\":\"NSX160F\",\"translation\":{\"en-GB\":\"NSX160F\",\"de-DE\":\"NSX160F\"}}]},{\"id\":\"D_PRODUCT_OR_COMPONENT_TYPE\",\"short_description\":\"Product or component type\",\"long_description\":\"Product or component type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Product or component type\",\"de-DE\":\"Produkt- oder Komponententyp\"},\"valueIds\":[{\"value_id\":\"CIRCUIT_BREAKER\",\"translation\":{\"en-GB\":\"Circuit breaker\",\"de-DE\":\"Leistungsschalter\"}}]},{\"id\":\"D_DEVICE_APPLICATION\",\"short_description\":\"Device application\",\"long_description\":\"Device application\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Device application\",\"de-DE\":\"Geräteanwendung\"},\"valueIds\":[{\"value_id\":\"DISTRIBUTION\",\"translation\":{\"en-GB\":\"Distribution\",\"de-DE\":\"Verteilung\"}}]},{\"id\":\"D_POLES_DESCRIPTION\",\"short_description\":\"Poles description\",\"long_description\":\"Poles description\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Poles description\",\"de-DE\":\"Beschreibung der Pole\"},\"valueIds\":[{\"value_id\":\"3P\",\"translation\":{\"en-GB\":\"3P\",\"de-DE\":\"3P\"}}]},{\"id\":\"D_PROTECTED_POLES_DESCRIPTION\",\"short_description\":\"Protected poles description\",\"long_description\":\"Protected poles description\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Protected poles description\",\"de-DE\":\"Beschreibung der geschützten Pole\"},\"valueIds\":[{\"value_id\":\"3T\",\"translation\":{\"en-GB\":\"3t\",\"de-DE\":\"3t\"}}]},{\"id\":\"A_RATED_CURRENT\",\"short_description\":\"[In] rated current\",\"long_description\":\"In rated current\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[In] rated current\",\"de-DE\":\"[In] Bemessungsstrom\"},\"valueIds\":[{\"value_id\":\"160_A_AT_40_\u00b0C\",\"translation\":{\"en-GB\":\"160\u00a0A at 40\u00a0\u00b0C\",\"de-DE\":\"160\u00a0A bei 40\u00a0\u00b0C\"}}]},{\"id\":\"A_RATED_OPERATIONAL_VOLTAGE\",\"short_description\":\"[Ue] rated operational voltage\",\"long_description\":\"Ue rated operational voltage\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[Ue] rated operational voltage\",\"de-DE\":\"[Ue] Betriebsbemessungsspannung\"},\"valueIds\":[{\"value_id\":\"690_V_AC_50/60_HZ\",\"translation\":{\"en-GB\":\"690 V AC 50/60 Hz\",\"de-DE\":\"690 V AC 50/60 Hz\"}}]},{\"id\":\"D_NETWORK_TYPE\",\"short_description\":\"Network type\",\"long_description\":\"Network type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Network type\",\"de-DE\":\"Netzwerktyp\"},\"valueIds\":[{\"value_id\":\"AC\",\"translation\":{\"en-GB\":\"AC\",\"de-DE\":\"AC\"}}]},{\"id\":\"D_NETWORK_FREQUENCY\",\"short_description\":\"Network frequency\",\"long_description\":\"Network frequency\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Network frequency\",\"de-DE\":\"Netzwerkfrequenz\"},\"valueIds\":[{\"value_id\":\"50_60_HZ\",\"translation\":{\"en-GB\":\"50/60 Hz\",\"de-DE\":\"50/60 Hz\"}}]},{\"id\":\"A_SUITABILITY_FOR_ISOLATION\",\"short_description\":\"Suitability for isolation\",\"long_description\":\"suitability for isolation\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Suitability for isolation\",\"de-DE\":\"Eignung für Isolation\"},\"valueIds\":[{\"value_id\":\"YES_CONFORMING_TO_EN/IEC_60947-2\",\"translation\":{\"en-GB\":\"Yes conforming to EN/IEC 60947-2\",\"de-DE\":\"Ja entspricht EN/IEC 60947-2\"}}]},{\"id\":\"D_UTILISATION_CATEGORY\",\"short_description\":\"utilisation category\",\"long_description\":\"utilisation category\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"utilisation category\",\"de-DE\":\"Nutzungskategorie\"},\"valueIds\":[{\"value_id\":\"A\",\"translation\":{\"en-GB\":\"Category A\",\"de-DE\":\"Kategorie A\"}}]},{\"id\":\"A_BREAKING_CAPACITY\",\"short_description\":\"Breaking capacity\",\"long_description\":\"breaking capacity\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Breaking capacity\",\"de-DE\":\"Ausschaltvermögen\"},\"valueIds\":[{\"value_id\":\"10_KA_AT_600_V_AC_50/60_HZ_CONFORMING_TO_UL_508\",\"translation\":{\"en-GB\":\"10\u00a0kA at 600 V AC 50/60 Hz conforming to UL 508\",\"de-DE\":\"10\u00a0kA bei 600 V AC 50/60 Hz entspricht UL 508\"}},{\"value_id\":\"85_KA_AT_240_V_AC_50/60_HZ_CONFORMING_TO_UL_508\",\"translation\":{\"en-GB\":\"85\u00a0kA at 240 V AC 50/60 Hz conforming to UL 508\",\"de-DE\":\"85\u00a0kA bei 240 V AC 50/60 Hz entspricht UL 508\"}},{\"value_id\":\"22_KA_ICU_AT_525_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"22\u00a0kA Icu at 525 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"22\u00a0kA Icu bei 525 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"35_KA_ICU_AT_440_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"35\u00a0kA Icu at 440 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"35\u00a0kA Icu bei 440 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"36_KA_ICU_AT_380/415_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"36\u00a0kA Icu at 380/415 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"36\u00a0kA Icu bei 380/415 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"8_KA_ICU_AT_660/690_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"8\u00a0kA Icu at 660/690 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"8\u00a0kA Icu bei 660/690 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"85_KA_ICU_AT_220/240_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"85\u00a0kA Icu at 220/240 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"85\u00a0kA Icu bei 220/240 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"35_KA_AT_480_V_AC_50/60_HZ_CONFORMING_TO_UL_508\",\"translation\":{\"en-GB\":\"35\u00a0kA at 480 V AC 50/60 Hz conforming to UL 508\",\"de-DE\":\"35\u00a0kA bei 480 V AC 50/60 Hz entspricht UL 508\"}},{\"value_id\":\"30_KA_ICU_AT_500_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"30\u00a0kA Icu at 500 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"30\u00a0kA Icu bei 500 V AC 50/60 Hz entspricht IEC 60947-2\"}}]},{\"id\":\"A_CIRCUIT_BREAKER_RATING_CODE\",\"short_description\":\"Breaking capacity code\",\"long_description\":\"Breaking capacity code\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Breaking capacity code\",\"de-DE\":\"Ausschaltvermögen\"},\"valueIds\":[{\"value_id\":\"F_36_KA_415_V_AC\",\"translation\":{\"en-GB\":\"F 36\u00a0kA 415 V AC\",\"de-DE\":\"F 36\u00a0kA 415 V AC\"}}]},{\"id\":\"D_TRIP_UNIT_NAME\",\"short_description\":\"Trip unit name\",\"long_description\":\"Trip unit name\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Trip unit name\",\"de-DE\":\"Name des Auslösers\"},\"valueIds\":[{\"value_id\":\"MICROLOGIC_5.2_A\",\"translation\":{\"en-GB\":\"MicroLogic 5.2 A\",\"de-DE\":\"Micrologic 5.2 A\"}}]},{\"id\":\"D_TRIP_UNIT_TECHNOLOGY\",\"short_description\":\"Trip unit technology\",\"long_description\":\"Trip unit technology\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Trip unit technology\",\"de-DE\":\"Auslöser-Technologie\"},\"valueIds\":[{\"value_id\":\"ELECTRONIC\",\"translation\":{\"en-GB\":\"Electronic\",\"de-DE\":\"Elektronisch\"}}]},{\"id\":\"D_TRIP_UNIT_FUNCTION\",\"short_description\":\"Trip unit protection functions\",\"long_description\":\"Trip unit protection functions\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Trip unit protection functions\",\"de-DE\":\"Schutzfunktionen des Auslösers\"},\"valueIds\":[{\"value_id\":\"LSI\",\"translation\":{\"en-GB\":\"LSI\",\"de-DE\":\"LSI\"}}]},{\"id\":\"D_CONTROL_TYPE\",\"short_description\":\"control type\",\"long_description\":\"control type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"control type\",\"de-DE\":\"Kontrolltyp\"},\"valueIds\":[{\"value_id\":\"TOGGLE\",\"translation\":{\"en-GB\":\"Toggle\",\"de-DE\":\"Kippschalter\"}}]},{\"id\":\"D_MOUNTING_MODE\",\"short_description\":\"Mounting mode\",\"long_description\":\"Mounting mode\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Mounting mode\",\"de-DE\":\"Montagemodus\"},\"valueIds\":[{\"value_id\":\"FIXED\",\"translation\":{\"en-GB\":\"Fixed\",\"de-DE\":\"Fixiert\"}}]}]},\"translation\":{\"en-GB\":\"Main\",\"de-DE\":\"Hauptmerkmale\"}},{\"id\":\"109\",\"label\":\"Complementary\",\"characteristic_list\":{\"characteristic\":[{\"id\":\"A_RATED_INSULATION_VOLTAGE\",\"short_description\":\"[Ui] rated insulation voltage\",\"long_description\":\"Ui rated insulation voltage\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[Ui] rated insulation voltage\",\"de-DE\":\"[Ui] Bemessungs-Isolationsspannung\"},\"valueIds\":[{\"value_id\":\"800_V_AC_50/60_HZ\",\"translation\":{\"en-GB\":\"800\u00a0V AC 50/60 Hz\",\"de-DE\":\"800\u00a0V AC 50/60 Hz\"}}]},{\"id\":\"A_RATED_IMP_WITHSTAND_VOLTAGE\",\"short_description\":\"[Uimp] rated impulse withstand voltage\",\"long_description\":\"Uimp rated imp wstd voltage\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[Uimp] rated impulse withstand voltage\",\"de-DE\":\"[Uimp] Bemessungs-Stoßspannungsfestigkeit\"},\"valueIds\":[{\"value_id\":\"8_KV\",\"translation\":{\"en-GB\":\"8\u00a0kV\",\"de-DE\":\"8\u00a0kV\"}}]},{\"id\":\"A_RATED_SER_BREAKING_CAP_IN_KA\",\"short_description\":\"[Ics] rated service breaking capacity\",\"long_description\":\"Ics rated service breaking cap\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[Ics] rated service breaking capacity\",\"de-DE\":\"[Ics] Bemessungsbetriebs-Ausschaltvermögen\"},\"valueIds\":[{\"value_id\":\"35_KA_AT_440_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"35\u00a0kA at 440 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"35\u00a0kA bei 440 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"36_KA_AT_380/415_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"36\u00a0kA at 380/415 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"36\u00a0kA bei 380/415 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"85_KA_AT_220/240_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"85\u00a0kA at 220/240 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"85\u00a0kA bei 220/240 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"22_KA_AT_525_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"22\u00a0kA at 525 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"22\u00a0kA bei 525 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"30_KA_AT_500_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"30\u00a0kA at 500 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"30\u00a0kA bei 500 V AC 50/60 Hz entspricht IEC 60947-2\"}},{\"value_id\":\"8_KA_AT_660/690_V_AC_50/60_HZ_CONFORMING_TO_IEC_60947-2\",\"translation\":{\"en-GB\":\"8\u00a0kA at 660/690 V AC 50/60 Hz conforming to IEC 60947-2\",\"de-DE\":\"8\u00a0kA bei 660/690 V AC 50/60 Hz entspricht IEC 60947-2\"}}]},{\"id\":\"D_MECHANICAL_SERVICE_LIFE\",\"short_description\":\"Mechanical durability\",\"long_description\":\"Mechanical durability\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Mechanical durability\",\"de-DE\":\"Mechanische Lebensdauer\"},\"valueIds\":[{\"value_id\":\"40000_CYCLES\",\"translation\":{\"en-GB\":\"40000\u00a0cycles\",\"de-DE\":\"40000\u00a0Zyklen\"}}]},{\"id\":\"A_ELECTRICAL_SERVICE_LIFE\",\"short_description\":\"Electrical durability\",\"long_description\":\"electrical durability\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Electrical durability\",\"de-DE\":\"Elektrische Lebensdauer\"},\"valueIds\":[{\"value_id\":\"7500_CYCLES_AT_690_V_IN\",\"translation\":{\"en-GB\":\"7500\u00a0cycles at 690 V In\",\"de-DE\":\"7500\u00a0Zyklen bei 690 V In\"}},{\"value_id\":\"15000_CYCLES_AT_690_V_IN/2\",\"translation\":{\"en-GB\":\"15000\u00a0cycles at 690 V In/2\",\"de-DE\":\"15000\u00a0Zyklen bei 690 V In/2\"}},{\"value_id\":\"20000_CYCLES_AT_440_V_IN\",\"translation\":{\"en-GB\":\"20000\u00a0cycles at 440 V In\",\"de-DE\":\"20000\u00a0Zyklen bei 440 V In\"}},{\"value_id\":\"40000_CYCLES_AT_440_V_IN/2\",\"translation\":{\"en-GB\":\"40000\u00a0cycles at 440 V In/2\",\"de-DE\":\"40000\u00a0Zyklen bei 440 V In/2\"}}]},{\"id\":\"D_MOUNTING_SUPPORT\",\"short_description\":\"mounting support\",\"long_description\":\"mounting support\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"mounting support\",\"de-DE\":\"Montagehalterung\"},\"valueIds\":[{\"value_id\":\"BACKPLATE\",\"translation\":{\"en-GB\":\"Backplate\",\"de-DE\":\"Rückwand\"}}]},{\"id\":\"D_UPSIDE_CONNECTION\",\"short_description\":\"Upside connection\",\"long_description\":\"Upside connection\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Upside connection\",\"de-DE\":\"Anschluss auf der Oberseite\"},\"valueIds\":[{\"value_id\":\"FRONT\",\"translation\":{\"en-GB\":\"Front\",\"de-DE\":\"Vorne\"}}]},{\"id\":\"D_DOWNSIDE_CONNECTION\",\"short_description\":\"downside connection\",\"long_description\":\"downside connection\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"downside connection\",\"de-DE\":\"Anschluss auf der Unterseite\"},\"valueIds\":[{\"value_id\":\"FRONT\",\"translation\":{\"en-GB\":\"Front\",\"de-DE\":\"Vorne\"}}]},{\"id\":\"A_CONNECTION_PITCH\",\"short_description\":\"Connection pitch\",\"long_description\":\"connection pitch\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Connection pitch\",\"de-DE\":\"Anschlussraster\"},\"valueIds\":[{\"value_id\":\"35_MM\",\"translation\":{\"en-GB\":\"35\u00a0mm\",\"de-DE\":\"35\u00a0mm\"}}]},{\"id\":\"A_PROTECTION_TYPE\",\"short_description\":\"Protection type\",\"long_description\":\"protection type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Protection type\",\"de-DE\":\"Schutzart\"},\"valueIds\":[{\"value_id\":\"L_:_FOR_OVERLOAD_PROTECTION_(LONG_TIME)\",\"translation\":{\"en-GB\":\"L : for overload protection (long time)\",\"de-DE\":\"L : für Überlastschutz (Langzeit)\"}},{\"value_id\":\"S_:_FOR_SHORT_TIME_SHORT-CIRCUIT_PROTECTION\",\"translation\":{\"en-GB\":\"S : for short time short-circuit protection\",\"de-DE\":\"S : für Kurzzeit-Kurzschlussschutz\"}},{\"value_id\":\"I_:_FOR_INSTANTANEOUS_SHORT-CIRCUIT_PROTECTION\",\"translation\":{\"en-GB\":\"I : for instantaneous short-circuit protection\",\"de-DE\":\"I : für unverzögerter Kurzschlussschutz\"}}]},{\"id\":\"A_TRIP_UNIT_RATING\",\"short_description\":\"Trip unit rating\",\"long_description\":\"trip unit rating\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Trip unit rating\",\"de-DE\":\"Auslöserleistung\"},\"valueIds\":[{\"value_id\":\"160_A_AT_40_\u00b0C\",\"translation\":{\"en-GB\":\"160\u00a0A at 40\u00a0\u00b0C\",\"de-DE\":\"160\u00a0A bei 40\u00a0\u00b0C\"}}]},{\"id\":\"D_LG_TIME_PICK_UP_ADJ_TYPE_IR\",\"short_description\":\"Long time pick-up adjustment type Ir\",\"long_description\":\"Long time pick-up adjustment type Ir\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Long time pick-up adjustment type Ir\",\"de-DE\":\"[Ir] Typ der Einstellung der Langzeitaufnahme\"},\"valueIds\":[{\"value_id\":\"ADJUSTABLE\",\"translation\":{\"en-GB\":\"Adjustable\",\"de-DE\":\"Einstellbar\"}}]},{\"id\":\"D_LONG_TIME_PICK_UP_ADJ_RANGE\",\"short_description\":\"Long time pick-up adjustment range\",\"long_description\":\"Long time pick-up adjustment range\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Long time pick-up adjustment range\",\"de-DE\":\"Einstellbereich der Langzeitaufnahme\"},\"valueIds\":[{\"value_id\":\"63..160_A\",\"translation\":{\"en-GB\":\"63...160 A\",\"de-DE\":\"63 - 160 A\"}}]},{\"id\":\"D_LONG_TIME_DELAY_ADJ_TYPE\",\"short_description\":\"Long time delay adjustment type\",\"long_description\":\"Long time delay adjustment type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Long time delay adjustment type\",\"de-DE\":\"Typ der Einstellung der Langzeitverzögerung\"},\"valueIds\":[{\"value_id\":\"ADJUSTABLE\",\"translation\":{\"en-GB\":\"Adjustable\",\"de-DE\":\"Einstellbar\"}}]},{\"id\":\"A_LONG_TIME_DELAY_ADJ_RANGE\",\"short_description\":\"[tr] long-time delay adjustment range\",\"long_description\":\"tr long-time delay adjust rng\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[tr] long-time delay adjustment range\",\"de-DE\":\"[tr] Einstellbereich der Langzeitverzögerung\"},\"valueIds\":[{\"value_id\":\"15…400_S_AT_1.5_X_IR\",\"translation\":{\"en-GB\":\"15…400\u00a0s at 1.5 x Ir\",\"de-DE\":\"15…400\u00a0s bei 1,5 x Ir\"}},{\"value_id\":\"0.35…11_S_AT_7.2_X_IR\",\"translation\":{\"en-GB\":\"0.35…11\u00a0s at 7.2 x Ir\",\"de-DE\":\"0,35…11\u00a0s bei 7,2 x Ir\"}},{\"value_id\":\"0.5…16_S_AT_6_X_IR\",\"translation\":{\"en-GB\":\"0.5…16\u00a0s at 6 x Ir\",\"de-DE\":\"0,5…16\u00a0s bei 6 x Ir\"}}]},{\"id\":\"D_THERMAL_MEMORY\",\"short_description\":\"thermal memory\",\"long_description\":\"thermal memory\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"thermal memory\",\"de-DE\":\"Thermischer Speicher\"},\"valueIds\":[{\"value_id\":\"20_MINUTES_BFR+AFTER_TRIPPING\",\"translation\":{\"en-GB\":\"20 minutes before and after tripping\",\"de-DE\":\"20 Minuten vor und nach der Auslösung\"}}]},{\"id\":\"D_SH_TIME_PICK_UP_ADJ_TYPE_ISD\",\"short_description\":\"Short-time pick-up adjustment type Isd\",\"long_description\":\"Short-time pick-up adjustment type Isd\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Short-time pick-up adjustment type Isd\",\"de-DE\":\"[Isd] Typ der Einstellung des Kurzzeitaufnahme\"},\"valueIds\":[{\"value_id\":\"ADJUSTABLE\",\"translation\":{\"en-GB\":\"Adjustable\",\"de-DE\":\"Einstellbar\"}}]},{\"id\":\"D_SHORT_TIME_PICK_UP_ADJ_RG\",\"short_description\":\"[Isd] short-time pick-up adjustment range\",\"long_description\":\"[Isd] short-time pick-up adjustment range\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[Isd] short-time pick-up adjustment range\",\"de-DE\":\"[Isd] Einstellbereich der Kurzzeitaufnahme\"},\"valueIds\":[{\"value_id\":\"1.5..10_X_IR\",\"translation\":{\"en-GB\":\"1.5...10 x Ir\",\"de-DE\":\"1,5 - 10 x Ir\"}}]},{\"id\":\"D_SHORT_TIME_DELAY_ADJ_TYPE\",\"short_description\":\"Short-time delay adjustment type\",\"long_description\":\"Short-time delay adjustment type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Short-time delay adjustment type\",\"de-DE\":\"Typ der Einstellung der Kurzzeitverzögerung\"},\"valueIds\":[{\"value_id\":\"ADJUSTABLE\",\"translation\":{\"en-GB\":\"Adjustable\",\"de-DE\":\"Einstellbar\"}}]},{\"id\":\"A_SHORT_TIME_DELAY_ADJ_RANGE\",\"short_description\":\"[tsd] short-time delay adjustment range\",\"long_description\":\"tsd short-time delay adj\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"[tsd] short-time delay adjustment range\",\"de-DE\":\"[tsd] Einstellbereich der Kurzzeitverzögerung\"},\"valueIds\":[{\"value_id\":\"0…0.4_S\",\"translation\":{\"en-GB\":\"0…0.4\u00a0s\",\"de-DE\":\"0…0,4\u00a0s\"}}]},{\"id\":\"D_INSTT_PICK_UP_ADJ_TYPE_II\",\"short_description\":\"Instantaneous pick-up adjustment type Ii\",\"long_description\":\"Instantaneous pick-up adjustment type Ii\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Instantaneous pick-up adjustment type Ii\",\"de-DE\":\"[Ii] Typ der Einstellung des unverzögerten Kurzschlusses\"},\"valueIds\":[{\"value_id\":\"ADJUSTABLE\",\"translation\":{\"en-GB\":\"Adjustable\",\"de-DE\":\"Einstellbar\"}}]},{\"id\":\"D_INSTANTANEOUS_PICK_UP_ADJ_RG\",\"short_description\":\"instantaneous pick-up adjustment range\",\"long_description\":\"instantaneous pick-up adjustment range\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"instantaneous pick-up adjustment range\",\"de-DE\":\"Einstellbereich des unverzögerten Kurzschlusses\"},\"valueIds\":[{\"value_id\":\"1.5..15_X_IN\",\"translation\":{\"en-GB\":\"1.5...15 x In\",\"de-DE\":\"1,5 - 15 x In\"}}]},{\"id\":\"D_EARTH_LEAKAGE_PROTECTION\",\"short_description\":\"earth-leakage protection\",\"long_description\":\"earth-leakage protection\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"earth-leakage protection\",\"de-DE\":\"Erdschlussschutz\"},\"valueIds\":[{\"value_id\":\"WITHOUT\",\"translation\":{\"en-GB\":\"Without\",\"de-DE\":\"Ohne\"}}]},{\"id\":\"D_ZONE_SELECTIVE_INTERLOCKING\",\"short_description\":\"Zone selective interlocking ZSI\",\"long_description\":\"Zone selective interlocking ZSI\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Zone selective interlocking ZSI\",\"de-DE\":\"Zonenselektive Verriegelung ZSI\"},\"valueIds\":[{\"value_id\":\"WITH\",\"translation\":{\"en-GB\":\"With\",\"de-DE\":\"Mit\"}}]},{\"id\":\"A_NUMBER_OF_SLOTS\",\"short_description\":\"Number of slots\",\"long_description\":\"number of slots\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Number of slots\",\"de-DE\":\"Anzahl der Steckplätze\"},\"valueIds\":[{\"value_id\":\"5_SLOT(S)\",\"translation\":{\"en-GB\":\"5 slot(s)\",\"de-DE\":\"5 Steckplatz (Steckplätze)\"}}]},{\"id\":\"A_LOCAL_SIGNALLING\",\"short_description\":\"Local signalling\",\"long_description\":\"local signalling\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Local signalling\",\"de-DE\":\"Lokale Signalisierung\"},\"valueIds\":[{\"value_id\":\"FLASHING_LED_(GREEN)_FOR_READY_TO_OPERATE\",\"translation\":{\"en-GB\":\"Flashing LED (green) for ready to operate\",\"de-DE\":\"Blinkende LED (grün) für betriebsbereit\"}},{\"value_id\":\"LED_105_%_IR_(RED)_FOR_OVERLOAD\",\"translation\":{\"en-GB\":\"LED 105 % Ir (red) for overload\",\"de-DE\":\"LED 105 % Ir (rot) für Überlast\"}},{\"value_id\":\"LED_90_%_IR_(ORANGE)_FOR_OVERLOAD\",\"translation\":{\"en-GB\":\"LED 90 % Ir (orange) for overload\",\"de-DE\":\"LED 90 % Ir (orange) für Überlast\"}}]},{\"id\":\"D_DISPLAY_TYPE\",\"short_description\":\"Display type\",\"long_description\":\"Display type\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Display type\",\"de-DE\":\"Anzeigetyp\"},\"valueIds\":[{\"value_id\":\"LCD_DISPLAY\",\"translation\":{\"en-GB\":\"LCD display\",\"de-DE\":\"LCD-Anzeige\"}}]},{\"id\":\"D_TYPE_OF_MEASUREMENT\",\"short_description\":\"Type of measurement\",\"long_description\":\"Type of measurement\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Type of measurement\",\"de-DE\":\"Messart\"},\"valueIds\":[{\"value_id\":\"AMMETER\",\"translation\":{\"en-GB\":\"Ammeter\",\"de-DE\":\"Amperemeter\"}}]},{\"id\":\"D_COMMUNICATION_OF_DATA\",\"short_description\":\"communication of data\",\"long_description\":\"communication of data\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"communication of data\",\"de-DE\":\"Übermittlung der Daten\"},\"valueIds\":[{\"value_id\":\"MAINTENANCE_INDICATORS\",\"translation\":{\"en-GB\":\"Maintenance indicators\",\"de-DE\":\"Wartungsanzeigen\"}},{\"value_id\":\"DEMAND_CURRENT_AND_POWER\",\"translation\":{\"en-GB\":\"Demand current and power\",\"de-DE\":\"Abfrage Strom und Leitung\"}},{\"value_id\":\"MAXIMETERS_MINIMETERS\",\"translation\":{\"en-GB\":\"Maximeters/minimeters\",\"de-DE\":\"Maximeter/Minimeter\"}},{\"value_id\":\"POWER_QUALITY\",\"translation\":{\"en-GB\":\"Power quality\",\"de-DE\":\"Qualität der Stromversorgung\"}},{\"value_id\":\"INSTANTANEOUS_+_DEMAND_VALUES\",\"translation\":{\"en-GB\":\"Instantaneous and demand values\",\"de-DE\":\"Momentane und angeforderte Werte\"}},{\"value_id\":\"TM-STP_HISTORIES+EVENT_TABLES\",\"translation\":{\"en-GB\":\"Time-stamped histories and event tables\",\"de-DE\":\"Zeitgestempelte Verläufe und Ereignistabellen\"}},{\"value_id\":\"ENERGY_METERING\",\"translation\":{\"en-GB\":\"Energy metering\",\"de-DE\":\"Energieverbrauchsmessung\"}},{\"value_id\":\"PROTECTION_AND_ALARM_SETTINGS\",\"translation\":{\"en-GB\":\"Protection and alarm settings\",\"de-DE\":\"Schutz- und Alarmeinstellungen\"}}]},{\"id\":\"D_WIDTH\",\"short_description\":\"Width\",\"long_description\":\"Width\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Width\",\"de-DE\":\"Breite\"},\"valueIds\":[{\"value_id\":\"105_MM\",\"translation\":{\"en-GB\":\"105\u00a0mm\",\"de-DE\":\"105\u00a0mm\"}}]},{\"id\":\"D_HEIGHT\",\"short_description\":\"height\",\"long_description\":\"height\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"height\",\"de-DE\":\"Höhe\"},\"valueIds\":[{\"value_id\":\"161_MM\",\"translation\":{\"en-GB\":\"161\u00a0mm\",\"de-DE\":\"161\u00a0mm\"}}]},{\"id\":\"D_DEPTH\",\"short_description\":\"Depth\",\"long_description\":\"Depth\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Depth\",\"de-DE\":\"Tiefe\"},\"valueIds\":[{\"value_id\":\"86_MM\",\"translation\":{\"en-GB\":\"86\u00a0mm\",\"de-DE\":\"86\u00a0mm\"}}]},{\"id\":\"D_PRODUCT_WEIGHT\",\"short_description\":\"Net weight\",\"long_description\":\"Net weight\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Net weight\",\"de-DE\":\"Produktgewicht\"},\"valueIds\":[{\"value_id\":\"2.2_KG\",\"translation\":{\"en-GB\":\"2.2\u00a0kg\",\"de-DE\":\"2,2\u00a0kg\"}}]},{\"id\":\"D_X_R_COMPATIBILY_CODE\",\"short_description\":\"Compatibility code\",\"long_description\":\"Compatibility code\",\"isVisible\":\"false\",\"translation\":{\"en-GB\":\"Compatibility code\",\"de-DE\":\"Kompatibilitätscode\"},\"valueIds\":[{\"value_id\":\"NSX160\",\"translation\":{\"en-GB\":\"NSX160\",\"de-DE\":\"NSX160\"}}]}]},\"translation\":{\"en-GB\":\"Complementary\",\"de-DE\":\"Zusatzmerkmale\"}},{\"id\":\"119\",\"label\":\"Environment\",\"characteristic_list\":{\"characteristic\":[{\"id\":\"D_STANDARDS\",\"short_description\":\"Standards\",\"long_description\":\"Standards\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Standards\",\"de-DE\":\"Normen\"},\"valueIds\":[{\"value_id\":\"EN_IEC_60947\",\"translation\":{\"en-GB\":\"EN/IEC 60947\",\"de-DE\":\"EN/IEC 60947\"}}]},{\"id\":\"D_CERTIFICATIONS\",\"short_description\":\"product certifications\",\"long_description\":\"product certifications\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"product certifications\",\"de-DE\":\"Produktzertifizierungen\"},\"valueIds\":[{\"value_id\":\"CCC\",\"translation\":{\"en-GB\":\"CCC\",\"de-DE\":\"CCC\"}},{\"value_id\":\"EAC\",\"translation\":{\"en-GB\":\"EAC\",\"de-DE\":\"EAC\"}},{\"value_id\":\"MARINE\",\"translation\":{\"en-GB\":\"Marine\",\"de-DE\":\"Marine\"}}]},{\"id\":\"D_OVERVOLTAGE_CATEGORY\",\"short_description\":\"Overvoltage category\",\"long_description\":\"Overvoltage category\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Overvoltage category\",\"de-DE\":\"Überspannungskategorie\"},\"valueIds\":[{\"value_id\":\"CLASS_II\",\"translation\":{\"en-GB\":\"Class II\",\"de-DE\":\"Klasse II\"}}]},{\"id\":\"D_ELECTRIC_SHOCK_PROT\",\"short_description\":\"Electrical shock protection class\",\"long_description\":\"Electrical shock protection class\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Electrical shock protection class\",\"de-DE\":\"Schutzklasse für Stromschläge\"},\"valueIds\":[{\"value_id\":\"CLASS_II\",\"translation\":{\"en-GB\":\"Class II\",\"de-DE\":\"Klasse II\"}}]},{\"id\":\"A_POLLUTION_DEGREE\",\"short_description\":\"Pollution degree\",\"long_description\":\"pollution degree\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Pollution degree\",\"de-DE\":\"Verschmutzungsgrad\"},\"valueIds\":[{\"value_id\":\"3_CONFORMING_TO_IEC_60664-1\",\"translation\":{\"en-GB\":\"3 conforming to IEC 60664-1\",\"de-DE\":\"3 entspricht IEC 60664-1\"}}]},{\"id\":\"A_IP_PROTECTION\",\"short_description\":\"IP degree of protection\",\"long_description\":\"IP degree of protection\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"IP degree of protection\",\"de-DE\":\"Schutzart (IP)\"},\"valueIds\":[{\"value_id\":\"IP40_CONFORMING_TO_IEC_60529\",\"translation\":{\"en-GB\":\"IP40 conforming to IEC 60529\",\"de-DE\":\"IP40 entspricht IEC 60529\"}}]},{\"id\":\"A_IK_PROTECTION\",\"short_description\":\"IK degree of protection\",\"long_description\":\"IK degree of protection\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"IK degree of protection\",\"de-DE\":\"Schutzart (IK)\"},\"valueIds\":[{\"value_id\":\"IK07_CONFORMING_TO_IEC_62262\",\"translation\":{\"en-GB\":\"IK07 conforming to IEC 62262\",\"de-DE\":\"IK07 entspricht IEC 62262\"}}]},{\"id\":\"D_AMBIANT_AIR_TEMPERATURE\",\"short_description\":\"ambient air temperature for operation\",\"long_description\":\"ambient air temperature for operation\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"ambient air temperature for operation\",\"de-DE\":\"Umgebungstemperatur bei Betrieb\"},\"valueIds\":[{\"value_id\":\"-25…70_\u00b0C\",\"translation\":{\"en-GB\":\"-25…70\u00a0\u00b0C\",\"de-DE\":\"-25…70\u00a0\u00b0C\"}}]},{\"id\":\"D_STORAGE_AIR_TEMPERATURE\",\"short_description\":\"Ambient air temperature for storage\",\"long_description\":\"Ambient air temperature for storage\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Ambient air temperature for storage\",\"de-DE\":\"Umgebungstemperatur bei Lagerung\"},\"valueIds\":[{\"value_id\":\"-40…85_\u00b0C\",\"translation\":{\"en-GB\":\"-40…85\u00a0\u00b0C\",\"de-DE\":\"-40…85\u00a0\u00b0C\"}}]},{\"id\":\"A_RELATIVE_HUMIDITY\",\"short_description\":\"Relative humidity\",\"long_description\":\"relative humidity\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Relative humidity\",\"de-DE\":\"Relative Luftfeuchtigkeit\"},\"valueIds\":[{\"value_id\":\"0…95_%\",\"translation\":{\"en-GB\":\"0…95\u00a0%\",\"de-DE\":\"0…95\u00a0%\"}}]},{\"id\":\"A_OPERATING_ALTITUDE\",\"short_description\":\"Operating altitude\",\"long_description\":\"operating altitude\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Operating altitude\",\"de-DE\":\"Betriebshöhe\"},\"valueIds\":[{\"value_id\":\"0...2000_M_WITHOUT_DERATING\",\"translation\":{\"en-GB\":\"0...2000 m without derating\",\"de-DE\":\"0 - 2.000 m ohne Leistungsminderung\"}},{\"value_id\":\"2000_M...5000_M_WITH_DERATING\",\"translation\":{\"en-GB\":\"2000 m...5000 m with derating\",\"de-DE\":\"2.000 - 5.000 m mit Unterlastung\"}}]}]},\"translation\":{\"en-GB\":\"Environment\",\"de-DE\":\"Montage\"}},{\"id\":\"ATG_PACKING_UNITS\",\"label\":\"Packing Units\",\"characteristic_list\":{\"characteristic\":[{\"id\":\"ATS_UNIT_TYPE_OF_PACKAGE_1\",\"short_description\":\"Unit Type of Package 1\",\"long_description\":\"Unit Type of Package 1\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Unit Type of Package 1\",\"de-DE\":\"VPE 1 Art\"},\"valueIds\":[{\"value_id\":\"PCE\",\"translation\":{\"en-GB\":\"PCE\"}}]},{\"id\":\"P_PKG_QUANTITY\",\"short_description\":\"Number of Units in Package 1\",\"long_description\":\"Number of Units in Package 1\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Number of Units in Package 1\",\"de-DE\":\"VPE 1 Menge\"},\"valueIds\":[{\"value_id\":\"1\",\"translation\":{\"en-GB\":\"1\",\"de-DE\":\"1\"}}]},{\"id\":\"ATS_PACKAGE_1_HEIGHT\",\"short_description\":\"Package 1 Height\",\"long_description\":\"Package 1 Height\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Package 1 Height\",\"de-DE\":\"VPE 1 Höhe\"},\"valueIds\":[{\"value_id\":\"10_CM\",\"translation\":{\"en-GB\":\"10\u00a0cm\",\"de-DE\":\"10\u00a0cm\"}}]},{\"id\":\"ATS_PACKAGE_1_WIDTH\",\"short_description\":\"Package 1 Width\",\"long_description\":\"Package 1 Width\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Package 1 Width\",\"de-DE\":\"VPE 1 Breite\"},\"valueIds\":[{\"value_id\":\"13.7_CM\",\"translation\":{\"en-GB\":\"13.7\u00a0cm\",\"de-DE\":\"13,7\u00a0cm\"}}]},{\"id\":\"ATS_PACKAGE_1_LENGTH\",\"short_description\":\"Package 1 Length\",\"long_description\":\"Package 1 Length\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Package 1 Length\",\"de-DE\":\"VPE 1 Länge\"},\"valueIds\":[{\"value_id\":\"17.5_CM\",\"translation\":{\"en-GB\":\"17.5\u00a0cm\",\"de-DE\":\"17,5\u00a0cm\"}}]},{\"id\":\"P_PKG_WEIGHT\",\"short_description\":\"Package 1 Weight\",\"long_description\":\"Package 1 Weight\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Package 1 Weight\",\"de-DE\":\"VPE 1 Gewicht\"},\"valueIds\":[{\"value_id\":\"2.003_KG\",\"translation\":{\"en-GB\":\"2.003\u00a0kg\",\"de-DE\":\"2,003\u00a0kg\"}}]}]},\"translation\":{\"en-GB\":\"Packing Units\",\"de-DE\":\"Verpackungseinheiten\"}},{\"id\":\"ATG_OFFER_SUSTAINABILITY\",\"label\":\"Offer Sustainability\",\"characteristic_list\":{\"characteristic\":[{\"id\":\"P_SUST_OFFER_STATUS\",\"short_description\":\"Sustainable offer status\",\"long_description\":\"Sustainable offer status\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Sustainable offer status\",\"de-DE\":\"Angebotsstatus nachhaltiges Produkt\"},\"valueIds\":[{\"value_id\":\"GREEN_PREMIUM_PRODUCT\",\"translation\":{\"en-GB\":\"Green Premium product\",\"de-DE\":\"Green Premium Produkt\"}}]},{\"id\":\"PA_ROHS\",\"short_description\":\"EU RoHS Directive\",\"long_description\":\"EU RoHS Directive\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"EU RoHS Directive\",\"de-DE\":\"EU-RoHS-Richtlinie\"},\"valueIds\":[{\"value_id\":\"COMPLIANT\",\"translation\":{\"en-GB\":\"Compliant\",\"de-DE\":\"Konform\"}}]},{\"id\":\"ATS_MERCURY_FREE\",\"short_description\":\"Mercury free\",\"long_description\":\"Mercury free\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Mercury free\",\"de-DE\":\"Quecksilberfrei\"},\"valueIds\":[{\"value_id\":\"1\",\"translation\":{\"en-GB\":\"Yes\",\"de-DE\":\"Ja\"}}]},{\"id\":\"ATS_ROHS_CHINA\",\"short_description\":\"China RoHS Regulation\",\"long_description\":\"China RoHS Regulation\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"China RoHS Regulation\",\"de-DE\":\"RoHS-Richtlinie für China\"},\"valueIds\":[{\"value_id\":\"PRODUCT_OUT\",\"translation\":{\"en-GB\":\"Product out of China RoHS scope. Substance declaration for your information\",\"de-DE\":\"Produkt außerhalb des RoHS-Bereichs für China. Erklärung der Substanzen zu Ihrer Information.\"}}]},{\"id\":\"ATS_ROHS_EXEMPTION_INFORMATION\",\"short_description\":\"RoHS exemption information\",\"long_description\":\"RoHS exemption information\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"RoHS exemption information\",\"de-DE\":\"Informationen zu RoHS-Ausnahmen\"},\"valueIds\":[{\"value_id\":\"1\",\"translation\":{\"en-GB\":\"Yes\",\"de-DE\":\"Ja\"}}]},{\"id\":\"P_PROD_ENV_PROFILE\",\"short_description\":\"Environmental Disclosure\",\"long_description\":\"Environmental Disclosure\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Environmental Disclosure\",\"de-DE\":\"Umweltproduktdeklaration\"},\"valueIds\":[{\"value_id\":\"ENVPEP120606EN\",\"translation\":{\"en-GB\":\"ENVPEP120606EN\"}}]},{\"id\":\"P_PROD_END_OF_LIFE\",\"short_description\":\"Circularity Profile\",\"long_description\":\"Circularity Profile\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"Circularity Profile\",\"de-DE\":\"Kreislaufwirtschafts-Profil\"},\"valueIds\":[{\"value_id\":\"ENVEOLI120604EN\",\"translation\":{\"en-GB\":\"ENVEOLI120604EN\"}}]},{\"id\":\"ATS_WEEE\",\"short_description\":\"WEEE\",\"long_description\":\"WEEE\",\"isVisible\":\"true\",\"translation\":{\"en-GB\":\"WEEE\",\"de-DE\":\"WEEE\"},\"valueIds\":[{\"value_id\":\"WEEE\",\"translation\":{\"en-GB\":\"The product must be disposed on European Union markets following specific waste collection and never end up in rubbish bins\",\"de-DE\":\"Das Produkt muss entsprechend bestimmter Hinweise auf Märkten der Europäischen Union entsorgt werden und darf nicht in Haushaltsabfälle gelangen.\"}}]}]},\"translation\":{\"en-GB\":\"Offer Sustainability\",\"de-DE\":\"Nachhaltigkeit\"}}]},\"isActive\":true,\"long_desc\":{\"translation\":{\"en-GB\":\"Circuit breaker, ComPact NSX160F, 36kA/415VAC, MicroLogic 5.2A trip unit 160A, 3 poles 3d\",\"de-DE\":\"Kompaktleistungsschalter ComPact NSX160F mit Micrologic 5.2A 3P3D 160A, 36kA/415V AC\"}}}}";
}