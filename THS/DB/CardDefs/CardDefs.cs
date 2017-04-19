#region

using System.Collections.Generic;
using System.Xml.Serialization;

#endregion

namespace THS.DB.CardDefs
{
	[XmlRoot("CardDefs")]
	public class CardDefs
	{
		[XmlElement("Entity")]
		public List<Entity> Entites { get; set; }
	}
}