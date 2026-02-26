using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_01_05
{
    internal static List<string> C01_1 = [];
    internal static List<string> C01_2 = [];

    internal static List<string> C02_1 = [];
    internal static List<string> C02_2 = [];

    internal static List<string> C03_1 = [];
    internal static List<string> C03_2 = [];

    internal static List<string> C04_1 = [];
    internal static List<string> C04_2 = [];
    internal static List<string> C04_3 = [];

    internal static List<string> C05_1 = [];
    internal static List<string> C05_2 = [];
    internal static List<string> C05_3 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("01_05"));

        C01_1 = Translation.ReadCONTACTID(myXML, "1", "1");
        C01_2 = Translation.ReadCONTACTID(myXML, "1", "2");

        C02_1 = Translation.ReadCONTACTID(myXML, "2", "1");
        C02_2 = Translation.ReadCONTACTID(myXML, "2", "2");

        C03_1 = Translation.ReadCONTACTID(myXML, "3", "1");
        C03_2 = Translation.ReadCONTACTID(myXML, "3", "2");

        C04_1 = Translation.ReadCONTACTID(myXML, "4", "1");
        C04_2 = Translation.ReadCONTACTID(myXML, "4", "2");
        C04_3 = Translation.ReadCONTACTID(myXML, "4", "3");

        C05_1 = Translation.ReadCONTACTID(myXML, "5", "1");
        C05_2 = Translation.ReadCONTACTID(myXML, "5", "2");
        C05_3 = Translation.ReadCONTACTID(myXML, "5", "3");
    }

}
