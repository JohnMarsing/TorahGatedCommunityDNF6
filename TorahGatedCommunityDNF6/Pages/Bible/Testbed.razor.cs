using Microsoft.AspNetCore.Components;

namespace TorahGatedCommunityDNF6.Pages.Bible;

public partial class Testbed
{
	public bool ContentIsShowing = false;
	private string Color => ContentIsShowing ? "btn-success" : "btn-warning";
	private string Title => ContentIsShowing ? "Hide Content" : "Show Content";
	private string Icon => ContentIsShowing ? "fas fa-chevron-up" : "fas fa-chevron-down";

	public bool ShowWordTable001 = false;
	public bool ShowWordTable002 = false;

	protected void ToggleButtonClick()
	{
		ContentIsShowing = !ContentIsShowing;
		// Do something
	}

	protected void OnClickShowWordTable(int id)
	{
		if (id == 1)
		{
			ShowWordTable001 = true;
		}
		else
		{
			ShowWordTable001 = false;
		}
		StateHasChanged();
	}

	protected void OnClickHideWordTable(int id)
	{
		if (id == 1)
		{
			ShowWordTable001 = false;
		}
		else
		{
			ShowWordTable002 = true;
		}

		StateHasChanged();

	}

	//PopulateWordTable(id);

	//private void PopulateWordTable(int id)
	//{

	//}

}
