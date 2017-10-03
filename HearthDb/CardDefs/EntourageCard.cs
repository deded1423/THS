#region

using System;
using System.Xml.Serialization;

#endregion

namespace HearthDb.CardDefs
{
    [Serializable]
    public class EntourageCard
	{
		[XmlAttribute("cardID")]
		public string CardId { get; set; }
	}
}