using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_16_20
{
    internal static List<string> C16_1 = [];
    internal static List<string> C16_2 = [];
    internal static List<string> C16_3 = [];
    internal static List<string> C16_4 = [];

    internal static List<string> C17_1 = [];
    internal static List<string> C17_2 = [];
    internal static List<string> C17_3 = [];
    internal static List<string> C17_4 = [];
    internal static List<string> C17_5 = [];

    internal static List<string> C18_1 = [];
    internal static List<string> C18_2 = [];
    internal static List<string> C18_3 = [];
    internal static List<string> C18_4 = [];
    internal static List<string> C18_5 = [];

    internal static List<string> C19_1 = [];
    internal static List<string> C19_2 = [];

    internal static List<string> C20_1 = [];
    internal static List<string> C20_2 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("16_20"));

        C16_1 = Translation.ReadCONTACTID(myXML, "16", "1");
        C16_2 = Translation.ReadCONTACTID(myXML, "16", "2");
        C16_3 = Translation.ReadCONTACTID(myXML, "16", "3");
        C16_4 = Translation.ReadCONTACTID(myXML, "16", "4");

        C17_1 = Translation.ReadCONTACTID(myXML, "17", "1");
        C17_2 = Translation.ReadCONTACTID(myXML, "17", "2");
        C17_3 = Translation.ReadCONTACTID(myXML, "17", "3");
        C17_4 = Translation.ReadCONTACTID(myXML, "17", "4");
        C17_5 = Translation.ReadCONTACTID(myXML, "17", "5");

        C18_1 = Translation.ReadCONTACTID(myXML, "18", "1");
        C18_2 = Translation.ReadCONTACTID(myXML, "18", "2");
        C18_3 = Translation.ReadCONTACTID(myXML, "18", "3");
        C18_4 = Translation.ReadCONTACTID(myXML, "18", "4");
        C18_5 = Translation.ReadCONTACTID(myXML, "18", "5");

        C19_1 = Translation.ReadCONTACTID(myXML, "19", "1");
        C19_2 = Translation.ReadCONTACTID(myXML, "19", "2");

        C20_1 = Translation.ReadCONTACTID(myXML, "20", "1");
        C20_2 = Translation.ReadCONTACTID(myXML, "20", "2");
    }

}
