using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom.Html;

namespace Parser.Core.MmoNews
{
	class MmoParser : IParser<string[]>
	{
		public string[] Parse(IHtmlDocument document)
		{
			var list = new List<string>();
			var items = document.QuerySelectorAll("h3").Where(item => item.ClassName != null &&
			item.ClassName.Contains("view-news-title"));
			   
			foreach(var item in items)
			{
				list.Add(item.TextContent);
			}

			return list.ToArray();

		}
	}
}
