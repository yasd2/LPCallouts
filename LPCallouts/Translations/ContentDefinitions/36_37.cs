using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_36_37
{
    internal static List<string> C36_1 = [];
    internal static List<string> C36_2 = [];
    internal static List<string> C36_3 = [];
    internal static List<string> C36_4 = [];
    internal static List<string> C36_5 = [];

    internal static List<string> C37_1 = [];
    internal static List<string> C37_2 = [];
    internal static List<string> C37_3 = [];
    internal static List<string> C37_4 = [];
    internal static List<string> C37_5 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("36_37"));

        C36_1 = Translation.ReadCONTACTID(myXML, "36", "1");
        C36_2 = Translation.ReadCONTACTID(myXML, "36", "2");
        C36_3 = Translation.ReadCONTACTID(myXML, "36", "3");
        C36_4 = Translation.ReadCONTACTID(myXML, "36", "4");
        C36_5 = Translation.ReadCONTACTID(myXML, "36", "5");

        C37_1 = Translation.ReadCONTACTID(myXML, "37", "1");
        C37_2 = Translation.ReadCONTACTID(myXML, "37", "2");
        C37_3 = Translation.ReadCONTACTID(myXML, "37", "3");
        C37_4 = Translation.ReadCONTACTID(myXML, "37", "4");
        C37_5 = Translation.ReadCONTACTID(myXML, "37", "5");

    }

}
