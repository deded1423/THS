#region

using System.Xml.Serialization;

#endregion

namespace THS.DB.CardDefs
{
	public class EntourageCard
	{
		[XmlAttribute("cardID")]
		public string CardId { get; set; }
	}
}