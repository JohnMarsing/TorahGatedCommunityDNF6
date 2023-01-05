using Microsoft.AspNetCore.Components;
using TorahGatedCommunityDNF6.Pages.Bible.Models;

namespace TorahGatedCommunityDNF6.Pages.Bible;

public partial class WordTable
{
	[Parameter] public int Id { get; set; }

	public List<WordTableVM>? Words { get; set; } = new List<WordTableVM>();

	
	protected override void OnInitialized()
	{ 
		base.OnInitialized();

		if (Id==1)
		{
			WordTableVM wt = new()
			{
				WordCount = 1,
				Strongs = 7225,
				Hebrew = "<span class='nrl'>בְּ</span>רֵאשִׁית",
				KjvWord = "In the beginning",
				Transliteration = "be·re·Shit",
				ScriptureID = 1
			};
			Words!.Add(wt);

		}
		else
		{
			WordTableVM wt = new()
			{
				WordCount = 1,
				Strongs = 776,
				Hebrew = "<span class='nrl'>וְהָ</span>אָרֶץ",
				KjvWord = "And the earth",
				Transliteration = "ve·ha·'A·retz",
				ScriptureID = 2
			};
			Words!.Add(wt);
		}

		
	}

}
/*
WordCount	Strongs	Hebrew													KjvWord						Transliteration	ScriptureID
1					7225		<span class='nrl'>בְּ</span>רֵאשִׁית	In the beginning	be·re·Shit			1


1	776	<span class='nrl'>וְהָ</span>אָרֶץ	And the earth	ve·ha·'A·retz,	2
*/