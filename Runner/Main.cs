using System;
using MarkdownSharp;
using System.IO;

namespace Runner
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Markdown md = new Markdown ();
			var markup = File.ReadAllText (args[0]);
			var html = md.Transform (markup);
			Console.WriteLine (html);
		}
	}
}
