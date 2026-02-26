using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_21_25
{
    internal static List<string> C21_1 = [];
    internal static List<string> C21_2 = [];

    internal static List<string> C22_1 = [];
    internal static List<string> C22_2 = [];

    internal static List<string> C23_1 = [];
    internal static List<string> C23_2 = [];

    internal static List<string> C24_1 = [];
    internal static List<string> C24_2 = [];

    internal static List<string> C25_1 = [];
    internal static List<string> C25_2 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("21_25"));

        C21_1 = Translation.ReadCONTACTID(myXML, "21", "1");
        C21_2 = Translation.ReadCONTACTID(myXML, "21", "2");

        C22_1 = Translation.ReadCONTACTID(myXML, "22", "1");
        C22_2 = Translation.ReadCONTACTID(myXML, "22", "2");


        C23_1 = Translation.ReadCONTACTID(myXML, "23", "1");
        C23_2 = Translation.ReadCONTACTID(myXML, "23", "2");

        C24_1 = Translation.ReadCONTACTID(myXML, "24", "1");
        C24_2 = Translation.ReadCONTACTID(myXML, "24", "2");

        C25_1 = Translation.ReadCONTACTID(myXML, "25", "1");
        C25_2 = Translation.ReadCONTACTID(myXML, "25", "2");
    }

}
