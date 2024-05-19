using System.Collections.Generic;

namespace Mazi.Pipeline.WebUi.Models;

public partial class SecurityLoginModel
{
	public SecurityLoginModel()
	{
		LoginTypes = [];
	}

	public List<SecurityLoginOption> LoginTypes { get; set; }
}
