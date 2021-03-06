using UnityEngine;

namespace Tools.Utils
{
	public static class OpenURL
	{
		public static void Open(string link)
		{
			if (!string.IsNullOrEmpty(link))
			{
				Application.OpenURL(link);
			}
		}

		public static void RedirectToTwitterProfile()
		{
			Application.OpenURL(Constants.TWITTER_PROFILE);
		}

		public static void RedirectToItchProfile()
		{
			Application.OpenURL(Constants.ITCH_PROFILE);
		}
	}
}
