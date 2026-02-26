using LPCallouts.Internals;
using Rage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace LPCallouts.Translations;

internal class Translation
{
    /// <summary>
    /// Diese Dateien werden bei Start auf Vorhandenheit überprüft!
    /// </summary>
    internal static List<string> XmlTranslationFiles { get; set; } =
    [
        // ganz unten neue Dateien einfügen

        // ContentDefinitions
        "01_05",
        "06_10",
        "11_15",
        "16_20",
        "21_25",
        "26_30",
        "31_35",
        "36_37",

        "SuspectDialogues",

        // ... Callouts
        "AssistAvoidDrifter",
        "AssistBeach",
        "AssistCornerCut",
        "AssistCyclist",
        "AssistRunOver",
        "NoiseComplaint",

        "SuspectHandler",
        "FiberHandler",
        "Dispatch",
    ];

    static List<Action<string>> TranslationClasses { get; set; } =
    [
        // ContentDefinitions
        Translation_01_05.ReadMyXml,
        Translation_06_10.ReadMyXml,
        Translation_11_15.ReadMyXml,
        Translation_16_20.ReadMyXml,
        Translation_21_25.ReadMyXml,
        Translation_26_30.ReadMyXml,
        Translation_31_35.ReadMyXml,
        Translation_36_37.ReadMyXml,

        SuspectDialogueTranslation.ReadMyXml,

        // ... Callouts
        AssistAvoidDrifterTranslation.ReadMyXml,
        AssistBeachTranslation.ReadMyXml,
        AssistCornerCutTranslation.ReadMyXml,
        AssistCyclistTranslation.ReadMyXml,
        AssistRunOverTranslation.ReadMyXml,
        NoiseComplaintTranslation.ReadMyXml,

        SuspectHandlerTranslation.ReadMyXml,
        FiberHandlerTranslation.ReadMyXml,
        DispatchTranslation.ReadMyXml,
    ];


    internal static void DoTranslationFilesExist()
    {
        foreach (var file in XmlTranslationFiles)
        {
            if (File.Exists(@$"plugins\LSPDFR\LPCallouts\Translations\{GameHandler.ini_language}\{file}.xml"))
                Game.LogTrivial($"LPCallouts :) Found translation xml - {file}");
            else 
                ErrorHandler.WarningMessage($"[FATAL ERROR] ;( Missing translation xml - {file}", 999);
        }
    }


    internal static void LoadXmlsForLanguage()
    {
        DoTranslationFilesExist();

        Game.LogTrivial($"LPCallouts: Loading XML translations for language {GameHandler.ini_language}...");

        foreach (Action<string> loadAction in TranslationClasses)
        {
            loadAction.Invoke(GameHandler.ini_language);
        }

        Game.LogTrivial($"LPCallouts: Finished loading translations!");
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="xmlName">kein .xml mit dazu schreiben!!!</param>
    /// <returns></returns>
    internal static string GetPath(string xmlName)
        => @$"plugins\LSPDFR\LPCallouts\Translations\{GameHandler.ini_language}\{xmlName}.xml";


    internal static List<string> ReadCONTACTID(XDocument xDoc, string calloutId, string contactId)
    {
        // Falls das Dokument nicht geladen wurde, leere Liste zurückgeben
        if (xDoc?.Root == null) return [];

        return xDoc.Root
            .Elements("CALLOUTID")
            .FirstOrDefault(c => (string)c.Attribute("ID") == calloutId)
            ?.Elements("CONTACTID")
            .FirstOrDefault(con => (string)con.Attribute("ID") == contactId)
            ?.Elements("TEXT")
            .Select(x => x.Value) // Nimmt den reinen Textinhalt ohne Trim-Filter
            .ToList() ?? [];
    }


    /// <summary>
    /// Liest alle <TEXT>-Elemente innerhalb einer bestimmten <DIALOGID> aus.
    /// </summary>
    internal static List<string> ReadDIALOGID(XDocument xDoc, string dialogId)
    {
        // Falls das Dokument nicht geladen wurde oder keine Root hat, leere Liste zurückgeben
        if (xDoc?.Root == null) return [];

        return xDoc.Root
            .Elements("DIALOGID")
            .FirstOrDefault(d => (string)d.Attribute("ID") == dialogId)
            ?.Elements("TEXT")
            .Select(x => x.Value)
            .ToList() ?? [];
    }
}
