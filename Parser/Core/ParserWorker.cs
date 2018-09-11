using AngleSharp.Parser.Html;
using System;

namespace Parser.Core
{
	class ParserWorker<T> where T: class
	{
		IParser<T> parser;
		IParsetSettings parserSettings;

		HtmlLoader loader;

		bool isActive;

		#region Properties

		public IParser<T> Parser
		{
			get
			{
				return parser;
			}
			set
			{
				parser = value;
			}
		}

		public IParsetSettings ParserSettings
		{
			get
			{
				return parserSettings;
			}
			set
			{
				parserSettings = value;
				loader = new HtmlLoader(value);
			}
		}

		public bool IsActive
		{
			get
			{
				return isActive;
			}
		}

		#endregion

		public event Action<Object, T> OnNewData;
		public event Action<Object> OnCompleted;

		public ParserWorker(IParser<T> parser)
		{
			this.parser = parser;
		}

		public ParserWorker(IParser<T> parser, IParsetSettings parsetSettings): this(parser)
		{
			this.parserSettings = parsetSettings;
		}

		public void Start()
		{
			isActive = true;
			Worker(); 
		}

		public void Abort()
		{
			isActive = false;
		}

		private async void Worker()
		{
			for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
			{
				if(!isActive)
				{
					OnCompleted?.Invoke(this);
					return;
				}

				var source = await loader.GetSourceByPageId(i);
				var domParser = new HtmlParser();
					
				var document = await domParser.ParseAsync(source);

				var result = parser.Parse(document);

				OnNewData?.Invoke(this, result);
			}

			OnCompleted?.Invoke(this);
			isActive = false;
		}

	}
}
