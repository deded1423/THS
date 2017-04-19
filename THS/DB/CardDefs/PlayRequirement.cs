#region

using System.Xml.Serialization;

#endregion

namespace THS.DB.CardDefs
{
	public class PlayRequirement
	{
		[XmlAttribute("param")]
		public string Param { get; set; }

		[XmlAttribute("reqID")]
		public string ReqId { get; set; }
	}
}