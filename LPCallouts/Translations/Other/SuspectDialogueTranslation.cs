using System.Collections.Generic;
using System.Xml.Linq;
using static LPCallouts.Translations.Translation;

namespace LPCallouts.Translations;

internal class SuspectDialogueTranslation
{
    internal static List<string> D01 = [];
    internal static List<string> D02 = [];
    internal static List<string> D03 = [];
    internal static List<string> D04 = [];
    internal static List<string> D05 = [];
    internal static List<string> D06 = [];
    internal static List<string> D07 = [];
    internal static List<string> D08 = [];
    internal static List<string> D09 = [];
    internal static List<string> D10 = [];
    internal static List<string> D11 = [];
    internal static List<string> D12 = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("SuspectDialogues"));

        D01 = ReadDIALOGID(myXML, "1");
        D02 = ReadDIALOGID(myXML, "2");
        D03 = ReadDIALOGID(myXML, "3");
        D04 = ReadDIALOGID(myXML, "4");
        D05 = ReadDIALOGID(myXML, "5");
        D06 = ReadDIALOGID(myXML, "6");
        D07 = ReadDIALOGID(myXML, "7");
        D08 = ReadDIALOGID(myXML, "8");
        D09 = ReadDIALOGID(myXML, "9");
        D10 = ReadDIALOGID(myXML, "10");
        D11 = ReadDIALOGID(myXML, "11");
        D12 = ReadDIALOGID(myXML, "12");
    }
}