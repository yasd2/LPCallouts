using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_31_35
{
    internal static List<string> C31_1 = [];
    internal static List<string> C31_2 = [];
    internal static List<string> C31_3 = [];
    internal static List<string> C31_4 = [];
    internal static List<string> C31_5 = [];

    internal static List<string> C32_1 = [];
    internal static List<string> C32_2 = [];
    internal static List<string> C32_3 = [];
    internal static List<string> C32_4 = [];
    internal static List<string> C32_5 = [];

    internal static List<string> C33_1 = [];
    internal static List<string> C33_2 = [];
    internal static List<string> C33_3 = [];
    internal static List<string> C33_4 = [];
    internal static List<string> C33_5 = [];

    internal static List<string> C34_1 = [];
    internal static List<string> C34_2 = [];
    internal static List<string> C34_3 = [];
    internal static List<string> C34_4 = [];
    internal static List<string> C34_5 = [];

    internal static List<string> C35_1 = [];
    internal static List<string> C35_2 = [];
    internal static List<string> C35_3 = [];
    internal static List<string> C35_4 = [];
    internal static List<string> C35_5 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("31_35"));

        C31_1 = Translation.ReadCONTACTID(myXML, "31", "1");
        C31_2 = Translation.ReadCONTACTID(myXML, "31", "2");
        C31_3 = Translation.ReadCONTACTID(myXML, "31", "3");
        C31_4 = Translation.ReadCONTACTID(myXML, "31", "4");
        C31_5 = Translation.ReadCONTACTID(myXML, "31", "5");

        C32_1 = Translation.ReadCONTACTID(myXML, "32", "1");
        C32_2 = Translation.ReadCONTACTID(myXML, "32", "2");
        C32_3 = Translation.ReadCONTACTID(myXML, "32", "3");
        C32_4 = Translation.ReadCONTACTID(myXML, "32", "4");
        C32_5 = Translation.ReadCONTACTID(myXML, "32", "5");

        C33_1 = Translation.ReadCONTACTID(myXML, "33", "1");
        C33_2 = Translation.ReadCONTACTID(myXML, "33", "2");
        C33_3 = Translation.ReadCONTACTID(myXML, "33", "3");
        C33_4 = Translation.ReadCONTACTID(myXML, "33", "4");
        C33_5 = Translation.ReadCONTACTID(myXML, "33", "5");

        C34_1 = Translation.ReadCONTACTID(myXML, "34", "1");
        C34_2 = Translation.ReadCONTACTID(myXML, "34", "2");
        C34_3 = Translation.ReadCONTACTID(myXML, "34", "3");
        C34_4 = Translation.ReadCONTACTID(myXML, "34", "4");
        C34_5 = Translation.ReadCONTACTID(myXML, "34", "5");

        C35_1 = Translation.ReadCONTACTID(myXML, "35", "1");
        C35_2 = Translation.ReadCONTACTID(myXML, "35", "2");
        C35_3 = Translation.ReadCONTACTID(myXML, "35", "3");
        C35_4 = Translation.ReadCONTACTID(myXML, "35", "4");
        C35_5 = Translation.ReadCONTACTID(myXML, "35", "5");
    }
}
