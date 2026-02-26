using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_06_10
{
    internal static List<string> C06_1 = [];
    internal static List<string> C06_2 = [];
    internal static List<string> C06_3 = [];

    internal static List<string> C07_1 = [];
    internal static List<string> C07_2 = [];
    internal static List<string> C07_3 = [];

    internal static List<string> C08_1 = [];
    internal static List<string> C08_2 = [];
    internal static List<string> C08_3 = [];

    internal static List<string> C09_1 = [];
    internal static List<string> C09_2 = [];
    internal static List<string> C09_3 = [];

    internal static List<string> C10_1 = [];
    internal static List<string> C10_2 = [];
    internal static List<string> C10_3 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("06_10"));

        C06_1 = Translation.ReadCONTACTID(myXML, "6", "1");
        C06_2 = Translation.ReadCONTACTID(myXML, "6", "2");
        C06_3 = Translation.ReadCONTACTID(myXML, "6", "3");

        C07_1 = Translation.ReadCONTACTID(myXML, "7", "1");
        C07_2 = Translation.ReadCONTACTID(myXML, "7", "2");
        C07_3 = Translation.ReadCONTACTID(myXML, "7", "3");

        C08_1 = Translation.ReadCONTACTID(myXML, "8", "1");
        C08_2 = Translation.ReadCONTACTID(myXML, "8", "2");
        C08_3 = Translation.ReadCONTACTID(myXML, "8", "3");

        C09_1 = Translation.ReadCONTACTID(myXML, "9", "1");
        C09_2 = Translation.ReadCONTACTID(myXML, "9", "2");
        C09_3 = Translation.ReadCONTACTID(myXML, "9", "3");

        C10_1 = Translation.ReadCONTACTID(myXML, "10", "1");
        C10_2 = Translation.ReadCONTACTID(myXML, "10", "2");
        C10_3 = Translation.ReadCONTACTID(myXML, "10", "3");
    }

}
