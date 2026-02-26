using System.Collections.Generic;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation_11_15
{
    internal static List<string> C11_1 = [];
    internal static List<string> C11_2 = [];

    internal static List<string> C12_1 = [];
    internal static List<string> C12_2 = [];

    internal static List<string> C13_1 = [];
    internal static List<string> C13_2 = [];
    internal static List<string> C13_3 = [];
    internal static List<string> C13_4 = [];

    internal static List<string> C14_1 = [];
    internal static List<string> C14_2 = [];
    internal static List<string> C14_3 = [];
    internal static List<string> C14_4 = [];

    internal static List<string> C15_1 = [];
    internal static List<string> C15_2 = [];
    internal static List<string> C15_3 = [];
    internal static List<string> C15_4 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("11_15"));

        C11_1 = Translation.ReadCONTACTID(myXML, "11", "1");
        C11_2 = Translation.ReadCONTACTID(myXML, "11", "2");

        C12_1 = Translation.ReadCONTACTID(myXML, "12", "1");
        C12_2 = Translation.ReadCONTACTID(myXML, "12", "2");

        C13_1 = Translation.ReadCONTACTID(myXML, "13", "1");
        C13_2 = Translation.ReadCONTACTID(myXML, "13", "2");
        C13_3 = Translation.ReadCONTACTID(myXML, "13", "3");
        C13_4 = Translation.ReadCONTACTID(myXML, "13", "4");

        C14_1 = Translation.ReadCONTACTID(myXML, "14", "1");
        C14_2 = Translation.ReadCONTACTID(myXML, "14", "2");
        C14_3 = Translation.ReadCONTACTID(myXML, "14", "3");
        C14_4 = Translation.ReadCONTACTID(myXML, "14", "4");

        C15_1 = Translation.ReadCONTACTID(myXML, "15", "1");
        C15_2 = Translation.ReadCONTACTID(myXML, "15", "2");
        C15_3 = Translation.ReadCONTACTID(myXML, "15", "3");
        C15_4 = Translation.ReadCONTACTID(myXML, "15", "4");
    }

}
