using Microsoft.AspNetCore.Components;
using System.Text;
using TorahGatedCommunityDNF6.Pages.Products;

namespace TorahGatedCommunityDNF6.Pages.Bible.Models;

public class WordTableVM
{
	public int VerseHtmlID { get; set; }
	public byte WordCount { get; set; }
	public int? Strongs { get; set; }
	public string? Hebrew { get; set; }
	public string? KjvWord { get; set; }
	public string? Transliteration { get; set; }
	public string? Morph { get; set; }
	public bool MaqqefFollows { get; set; }
	public int ScriptureID { get; set; }
	public string? KjvBcv { get; set; }

	public MarkupString TransliterationMU
	{
		get
		{
			return new MarkupString(Transliteration ?? string.Empty);
		}
	}

	public string HebrewWithMaggef
	{
		get
		{
			if (MaqqefFollows)
			{
				return Hebrew + "־";
			}
			else
			{
				return Hebrew!;
			}
		}
	}

	public MarkupString StrongsAnchor
	{
		get
		{
			string sStrongs;
			if (Strongs == null) 	return new MarkupString(KjvWord ?? string.Empty);
			sStrongs = ScriptureID > VerseFacts.LastVerseInTaNaCh ? "G" + Strongs : "H" + Strongs;

			StringBuilder sb = new();
			sb.Append($"<a href='https://www.blueletterbible.org/lang/lexicon/lexicon.cfm?strongs={sStrongs}'");
			sb.Append(sStrongs).Append("&t=KJV\"> ").Append(sStrongs).Append("&nbsp;</a>");

			return new MarkupString(sb!.ToString());
		}
	}

	public MarkupString KjvWordSplit
	{
		get
		{
			const int OneLineThreshold = 14;
			const int MultiWordThreshold = 12;
			if (string.IsNullOrEmpty(KjvWord) || KjvWord.Length <= OneLineThreshold) 
				return new MarkupString(KjvWord ?? string.Empty);

			string[] words = KjvWord.Split(' ');
			int totalWordCount = words.Count();
			StringBuilder sb = new();
			int i = 0;
			int wordCount = 0;
			foreach (string word in words)
			{
				wordCount += 1;
				i += word.Length;
				if (wordCount < totalWordCount)
				{
					if (i > MultiWordThreshold)
					{
						sb.Append(word).Append("<br />");
						i = 0;
					}
					else
					{
						sb.Append(word).Append(" ");
					}
				}
				else // wordCount == totalWordCount
				{
					sb.Append(word); // Don't append a space
				}
			}
			return new MarkupString(sb!.ToString());
		}
	}

}
