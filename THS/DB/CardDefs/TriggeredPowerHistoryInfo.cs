#region

using System.Xml.Serialization;

#endregion

namespace THS.DB.CardDefs
{
	public class TriggeredPowerHistoryInfo
	{
		[XmlAttribute("effectIndex")]
		public int EffectIndex { get; set; }

		[XmlAttribute("showInHistory")]
		public string ShowInHistory { get; set; }
	}
}