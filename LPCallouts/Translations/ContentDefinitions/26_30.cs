using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_26_30
{
    internal static List<string> C26_1 = [];
    internal static List<string> C26_2 = [];

    internal static List<string> C27_1 = [];
    internal static List<string> C27_2 = [];

    internal static List<string> C28_1 = [];
    internal static List<string> C28_2 = [];

    internal static List<string> C29_1 = [];
    internal static List<string> C29_2 = [];

    internal static List<string> C30_1 = [];
    internal static List<string> C30_2 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("26_30"));

        C26_1 = Translation.ReadCONTACTID(myXML, "26", "1");
        C26_2 = Translation.ReadCONTACTID(myXML, "26", "2");

        C27_1 = Translation.ReadCONTACTID(myXML, "27", "1");
        C27_2 = Translation.ReadCONTACTID(myXML, "27", "2");

        C28_1 = Translation.ReadCONTACTID(myXML, "28", "1");
        C28_2 = Translation.ReadCONTACTID(myXML, "28", "2");

        C29_1 = Translation.ReadCONTACTID(myXML, "29", "1");
        C29_2 = Translation.ReadCONTACTID(myXML, "29", "2");

        C30_1 = Translation.ReadCONTACTID(myXML, "30", "1");
        C30_2 = Translation.ReadCONTACTID(myXML, "30", "2");
    }

}
