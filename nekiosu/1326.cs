using System;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x02000B3E RID: 2878
public sealed class 1326
{
	// Token: 0x06004F70 RID: 20336 RVA: 0x001F5BC4 File Offset: 0x001F3DC4
	public 1326()
	{
		if (!1662.47 || 1662.48)
		{
			1662.72(delegate
			{
				this.2++;
			});
			1662.90.2(new 1189(this.2), 1000, true);
		}
	}

	// Token: 0x06004F71 RID: 20337 RVA: 0x001F5C28 File Offset: 0x001F3E28
	internal bool 1(bool 1)
	{
		if (!this.3)
		{
			return false;
		}
		if (!this.4.Wait(1 ? 10000 : 1000))
		{
			return false;
		}
		if (!this.3)
		{
			return false;
		}
		this.3 = !1;
		bool result;
		try
		{
			bool flag = true;
			string text = "settings";
			Action action;
			if ((action = 1326.<>O.<0>__SaveConfiguration) == null)
			{
				action = (1326.<>O.<0>__SaveConfiguration = new Action(1304.6));
			}
			bool flag2 = flag & 1326.3(text, action) & 1326.3("collections", delegate
			{
				1297.Save(false);
			}) & 1326.3("scores", delegate
			{
				2230.17(false);
			});
			string text2 = "beatmap list";
			Action action2;
			if ((action2 = 1326.<>O.<1>__SaveDatabase) == null)
			{
				action2 = (1326.<>O.<1>__SaveDatabase = new Action(1272.13));
			}
			result = (flag2 & 1326.3(text2, action2));
		}
		finally
		{
			this.1 = 1662.33;
			this.2 = 0;
			this.4.Release();
		}
		return result;
	}

	// Token: 0x06004F72 RID: 20338 RVA: 0x001F5D48 File Offset: 0x001F3F48
	private void 2()
	{
		if (!1304.219 && (1662.33 - this.1 >= 600000 || 1662.87() >= 60000) && this.2 >= (1662.50() ? 2 : 10) && this.4.CurrentCount != 0)
		{
			1677 <<EMPTY_NAME>> = 1662.78;
			if (<<EMPTY_NAME>> - 1677.Play > 1 && <<EMPTY_NAME>> - 1677.Busy > 1 && <<EMPTY_NAME>> != 1677.BeatmapImport)
			{
				1662.17(new 1189(this.5));
			}
		}
	}

	// Token: 0x06004F73 RID: 20339 RVA: 0x001F5DCC File Offset: 0x001F3FCC
	private static bool 3(string 1, Action 2)
	{
		bool result;
		try
		{
			2();
			result = true;
		}
		catch (Exception ex)
		{
			1338.4(ex, "saving the " + 1, 1341.Runtime);
			result = false;
		}
		return result;
	}

	// Token: 0x06004F74 RID: 20340 RVA: 0x001F5E0C File Offset: 0x001F400C
	internal static void 4()
	{
		object obj = 1326.5;
		lock (obj)
		{
			if (1326.6)
			{
				return;
			}
			1326.6 = true;
		}
		1662.89.2(delegate
		{
			object obj2 = 1326.5;
			lock (obj2)
			{
				1326.6 = false;
			}
			1662.17(delegate
			{
				1326.3("scores", delegate
				{
					2230.17(false);
				});
				string text = "beatmap list";
				Action action;
				if ((action = 1326.<>O.<1>__SaveDatabase) == null)
				{
					action = (1326.<>O.<1>__SaveDatabase = new Action(1272.13));
				}
				1326.3(text, action);
				1326.3("collections", delegate
				{
					1297.Save(false);
				});
			});
		}, 1500, false);
	}

	// Token: 0x06004F75 RID: 20341 RVA: 0x001F5E84 File Offset: 0x001F4084
	private void 5()
	{
		1338.6("Performing background save..", 1341.Runtime, (1114)1);
		this.1(false);
		1338.6("Done!", 1341.Runtime, (1114)1);
	}

	// Token: 0x04003B6D RID: 15213
	private int 1;

	// Token: 0x04003B6E RID: 15214
	private int 2;

	// Token: 0x04003B6F RID: 15215
	private bool 3 = true;

	// Token: 0x04003B70 RID: 15216
	private SemaphoreSlim 4 = new SemaphoreSlim(1);

	// Token: 0x04003B71 RID: 15217
	private static readonly object 5 = new object();

	// Token: 0x04003B72 RID: 15218
	private static bool 6;

	// Token: 0x02000B3F RID: 2879
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04003B73 RID: 15219
		public static Action <0>__SaveConfiguration;

		// Token: 0x04003B74 RID: 15220
		public static Action <1>__SaveDatabase;
	}
}
