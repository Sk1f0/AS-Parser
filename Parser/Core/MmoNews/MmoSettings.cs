
namespace Parser.Core.MmoNews
{
	class MmoSettings : IParsetSettings
	{
		public MmoSettings(int start, int end)
		{
			StartPoint = start;
			EndPoint = end;
		}

		public string BaseUrl { get; set; } = "http://mmo13.ru/";
		public string Prefix { get; set; } = "news/page-{CurrentId}";
		public int StartPoint { get; set; }
		public int EndPoint { get; set; }
	}
}
