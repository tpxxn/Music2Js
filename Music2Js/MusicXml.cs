/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Music2Js
{
    [XmlRoot(ElementName = "work")]
    public class Work
    {
        [XmlElement(ElementName = "work-title")]
        public string Worktitle { get; set; }
    }

    [XmlRoot(ElementName = "supports")]
    public class Supports
    {
        [XmlAttribute(AttributeName = "element")]
        public string Element { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "attribute")]
        public string Attribute { get; set; }
        [XmlAttribute(AttributeName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "encoding")]
    public class Encoding
    {
        [XmlElement(ElementName = "software")]
        public string Software { get; set; }
        [XmlElement(ElementName = "encoding-date")]
        public string Encodingdate { get; set; }
        [XmlElement(ElementName = "supports")]
        public List<Supports> Supports { get; set; }
    }

    [XmlRoot(ElementName = "identification")]
    public class Identification
    {
        [XmlElement(ElementName = "encoding")]
        public Encoding Encoding { get; set; }
    }

    [XmlRoot(ElementName = "scaling")]
    public class Scaling
    {
        [XmlElement(ElementName = "millimeters")]
        public string Millimeters { get; set; }
        [XmlElement(ElementName = "tenths")]
        public string Tenths { get; set; }
    }

    [XmlRoot(ElementName = "page-margins")]
    public class Pagemargins
    {
        [XmlElement(ElementName = "left-margin")]
        public string Leftmargin { get; set; }
        [XmlElement(ElementName = "right-margin")]
        public string Rightmargin { get; set; }
        [XmlElement(ElementName = "top-margin")]
        public string Topmargin { get; set; }
        [XmlElement(ElementName = "bottom-margin")]
        public string Bottommargin { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "page-layout")]
    public class Pagelayout
    {
        [XmlElement(ElementName = "page-height")]
        public string Pageheight { get; set; }
        [XmlElement(ElementName = "page-width")]
        public string Pagewidth { get; set; }
        [XmlElement(ElementName = "page-margins")]
        public List<Pagemargins> Pagemargins { get; set; }
    }

    [XmlRoot(ElementName = "word-font")]
    public class Wordfont
    {
        [XmlAttribute(AttributeName = "font-family")]
        public string Fontfamily { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
    }

    [XmlRoot(ElementName = "lyric-font")]
    public class Lyricfont
    {
        [XmlAttribute(AttributeName = "font-family")]
        public string Fontfamily { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
    }

    [XmlRoot(ElementName = "defaults")]
    public class Defaults
    {
        [XmlElement(ElementName = "scaling")]
        public Scaling Scaling { get; set; }
        [XmlElement(ElementName = "page-layout")]
        public Pagelayout Pagelayout { get; set; }
        [XmlElement(ElementName = "word-font")]
        public Wordfont Wordfont { get; set; }
        [XmlElement(ElementName = "lyric-font")]
        public Lyricfont Lyricfont { get; set; }
    }

    [XmlRoot(ElementName = "credit-words")]
    public class Creditwords
    {
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlAttribute(AttributeName = "justify")]
        public string Justify { get; set; }
        [XmlAttribute(AttributeName = "valign")]
        public string Valign { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "credit")]
    public class Credit
    {
        [XmlElement(ElementName = "credit-type")]
        public string Credittype { get; set; }
        [XmlElement(ElementName = "credit-words")]
        public Creditwords Creditwords { get; set; }
        [XmlAttribute(AttributeName = "page")]
        public string Page { get; set; }
    }

    [XmlRoot(ElementName = "score-instrument")]
    public class Scoreinstrument
    {
        [XmlElement(ElementName = "instrument-name")]
        public string Instrumentname { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "midi-device")]
    public class Mididevice
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "port")]
        public string Port { get; set; }
    }

    [XmlRoot(ElementName = "midi-instrument")]
    public class Midiinstrument
    {
        [XmlElement(ElementName = "midi-channel")]
        public string Midichannel { get; set; }
        [XmlElement(ElementName = "midi-program")]
        public string Midiprogram { get; set; }
        [XmlElement(ElementName = "volume")]
        public string Volume { get; set; }
        [XmlElement(ElementName = "pan")]
        public string Pan { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "score-part")]
    public class Scorepart
    {
        [XmlElement(ElementName = "part-name")]
        public string Partname { get; set; }
        [XmlElement(ElementName = "part-abbreviation")]
        public string Partabbreviation { get; set; }
        [XmlElement(ElementName = "score-instrument")]
        public Scoreinstrument Scoreinstrument { get; set; }
        [XmlElement(ElementName = "midi-device")]
        public Mididevice Mididevice { get; set; }
        [XmlElement(ElementName = "midi-instrument")]
        public Midiinstrument Midiinstrument { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "part-list")]
    public class Partlist
    {
        [XmlElement(ElementName = "score-part")]
        public Scorepart Scorepart { get; set; }
    }

    [XmlRoot(ElementName = "system-margins")]
    public class Systemmargins
    {
        [XmlElement(ElementName = "left-margin")]
        public string Leftmargin { get; set; }
        [XmlElement(ElementName = "right-margin")]
        public string Rightmargin { get; set; }
    }

    [XmlRoot(ElementName = "system-layout")]
    public class Systemlayout
    {
        [XmlElement(ElementName = "system-margins")]
        public Systemmargins Systemmargins { get; set; }
        [XmlElement(ElementName = "top-system-distance")]
        public string Topsystemdistance { get; set; }
        [XmlElement(ElementName = "system-distance")]
        public string Systemdistance { get; set; }
    }

    [XmlRoot(ElementName = "print")]
    public class Print
    {
        [XmlElement(ElementName = "system-layout")]
        public Systemlayout Systemlayout { get; set; }
        [XmlAttribute(AttributeName = "new-system")]
        public string Newsystem { get; set; }
    }

    [XmlRoot(ElementName = "key")]
    public class Key
    {
        [XmlElement(ElementName = "fifths")]
        public string Fifths { get; set; }
    }

    [XmlRoot(ElementName = "time")]
    public class Time
    {
        [XmlElement(ElementName = "beats")]
        public string Beats { get; set; }
        [XmlElement(ElementName = "beat-type")]
        public string Beattype { get; set; }
    }

    [XmlRoot(ElementName = "clef")]
    public class Clef
    {
        [XmlElement(ElementName = "sign")]
        public string Sign { get; set; }
        [XmlElement(ElementName = "line")]
        public string Line { get; set; }
    }

    [XmlRoot(ElementName = "attributes")]
    public class Attributes
    {
        [XmlElement(ElementName = "divisions")]
        public string Divisions { get; set; }
        [XmlElement(ElementName = "key")]
        public Key Key { get; set; }
        [XmlElement(ElementName = "time")]
        public Time Time { get; set; }
        [XmlElement(ElementName = "clef")]
        public Clef Clef { get; set; }
    }

    [XmlRoot(ElementName = "words")]
    public class Words
    {
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "relative-y")]
        public string Relativey { get; set; }
        [XmlAttribute(AttributeName = "font-weight")]
        public string Fontweight { get; set; }
        [XmlAttribute(AttributeName = "font-size")]
        public string Fontsize { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "direction-type")]
    public class Directiontype
    {
        [XmlElement(ElementName = "words")]
        public Words Words { get; set; }
    }

    [XmlRoot(ElementName = "sound")]
    public class Sound
    {
        [XmlAttribute(AttributeName = "tempo")]
        public string Tempo { get; set; }
    }

    [XmlRoot(ElementName = "direction")]
    public class Direction
    {
        [XmlElement(ElementName = "direction-type")]
        public Directiontype Directiontype { get; set; }
        [XmlElement(ElementName = "sound")]
        public Sound Sound { get; set; }
        [XmlAttribute(AttributeName = "placement")]
        public string Placement { get; set; }
    }

    [XmlRoot(ElementName = "pitch")]
    public class Pitch
    {
        [XmlElement(ElementName = "step")]
        public string Step { get; set; }
        [XmlElement(ElementName = "octave")]
        public string Octave { get; set; }
    }

    [XmlRoot(ElementName = "beam")]
    public class Beam
    {
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "note")]
    public class Note
    {
        [XmlElement(ElementName = "pitch")]
        public Pitch Pitch { get; set; }
        [XmlElement(ElementName = "duration")]
        public string Duration { get; set; }
        [XmlElement(ElementName = "voice")]
        public string Voice { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "stem")]
        public string Stem { get; set; }
        [XmlElement(ElementName = "beam")]
        public Beam Beam { get; set; }
        [XmlAttribute(AttributeName = "default-x")]
        public string Defaultx { get; set; }
        [XmlAttribute(AttributeName = "default-y")]
        public string Defaulty { get; set; }
        [XmlElement(ElementName = "dot")]
        public string Dot { get; set; }
        [XmlElement(ElementName = "tie")]
        public Tie Tie { get; set; }
        [XmlElement(ElementName = "notations")]
        public Notations Notations { get; set; }
        [XmlElement(ElementName = "rest")]
        public Rest Rest { get; set; }
    }

    [XmlRoot(ElementName = "measure")]
    public class Measure
    {
        [XmlElement(ElementName = "print")]
        public Print Print { get; set; }
        [XmlElement(ElementName = "attributes")]
        public Attributes Attributes { get; set; }
        [XmlElement(ElementName = "direction")]
        public Direction Direction { get; set; }
        [XmlElement(ElementName = "note")]
        public List<Note> Note { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
        [XmlAttribute(AttributeName = "width")]
        public string Width { get; set; }
        [XmlElement(ElementName = "barline")]
        public Barline Barline { get; set; }
    }

    [XmlRoot(ElementName = "tie")]
    public class Tie
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "tied")]
    public class Tied
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "notations")]
    public class Notations
    {
        [XmlElement(ElementName = "tied")]
        public Tied Tied { get; set; }
    }

    [XmlRoot(ElementName = "rest")]
    public class Rest
    {
        [XmlAttribute(AttributeName = "measure")]
        public string Measure { get; set; }
    }

    [XmlRoot(ElementName = "barline")]
    public class Barline
    {
        [XmlElement(ElementName = "bar-style")]
        public string Barstyle { get; set; }
        [XmlAttribute(AttributeName = "location")]
        public string Location { get; set; }
    }

    [XmlRoot(ElementName = "part")]
    public class Part
    {
        [XmlElement(ElementName = "measure")]
        public List<Measure> Measure { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    [XmlRoot(ElementName = "score-partwise")]
    public class MusicXml
    {
        [XmlElement(ElementName = "work")]
        public Work Work { get; set; }
        [XmlElement(ElementName = "identification")]
        public Identification Identification { get; set; }
        [XmlElement(ElementName = "defaults")]
        public Defaults Defaults { get; set; }
        [XmlElement(ElementName = "credit")]
        public Credit Credit { get; set; }
        [XmlElement(ElementName = "part-list")]
        public Partlist Partlist { get; set; }
        [XmlElement(ElementName = "part")]
        public Part Part { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

}
