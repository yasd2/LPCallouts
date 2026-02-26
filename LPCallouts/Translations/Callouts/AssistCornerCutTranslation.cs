using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class AssistCornerCutTranslation
{
    internal static string CALLOUTMESSAGE;
    internal static List<string> TEXT = [];

    internal static XDocument myXML;

    internal static void ReadMyXml(string language)
    {
        myXML = XDocument.Load(Translation.GetPath("AssistCornerCut"));

        CALLOUTMESSAGE = myXML.Root
            .Element("CALLOUTMESSAGE").Value;

        TEXT = ReadTEXT(myXML);

    }

    internal static List<string> ReadTEXT(XDocument xDoc)
    {
        // Falls das Dokument nicht geladen wurde oder keine Root hat, leere Liste zurückgeben
        if (xDoc?.Root == null) return [];

        return xDoc.Root
            .Elements("TEXT")
            .Select(x => x.Value)
            .ToList() ?? [];
    }

}
