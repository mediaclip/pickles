using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Strike.V8;

namespace PicklesDoc.Pickles
{
	public class MarkdownifyProvider : IMarkdownProvider
	{
		private readonly Markdownify markdownify;

		public MarkdownifyProvider()
		{
			this.markdownify = new Markdownify();
		}
		
		public string Transform(string text)
		{
			var transform = markdownify.Transform(text);
			transform = transform.Replace("&nbsp;", string.Empty);
			return transform;
		}
	}
}

