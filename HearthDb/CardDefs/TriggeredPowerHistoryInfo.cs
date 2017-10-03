#region

using System;
using System.Xml.Serialization;

#endregion

namespace HearthDb.CardDefs
{
    [Serializable]
    public class TriggeredPowerHistoryInfo
	{
		[XmlAttribute("effectIndex")]
		public int EffectIndex { get; set; }

		[XmlAttribute("showInHistory")]
		public string ShowInHistory { get; set; }
	}
}