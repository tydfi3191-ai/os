using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000655 RID: 1621
public sealed class 2251 : IDisposable
{
	// Token: 0x0600316B RID: 12651 RVA: 0x00127754 File Offset: 0x00125954
	public 2251()
	{
		this.1();
	}

	// Token: 0x0600316C RID: 12652 RVA: 0x00127778 File Offset: 0x00125978
	internal void 1()
	{
		this.2();
		if (!Directory.Exists("Plugins/AiMod"))
		{
			return;
		}
		AppDomain appDomain = AppDomain.CreateDomain("AiModPluginInterface", AppDomain.CurrentDomain.Evidence, new AppDomainSetup
		{
			ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase,
			PrivateBinPath = "Plugins/AiMod",
			DisallowCodeDownload = true,
			ApplicationName = "AiModPluginInterface"
		});
		if (Directory.Exists("Plugins/AiMod"))
		{
			foreach (string text in Directory.GetFiles("Plugins/AiMod", "*.dll"))
			{
				2252[] array = (appDomain.CreateInstanceAndUnwrap("osu!framework", typeof(2253).FullName) as 2253).LoadAssemblyAttributes(text);
				if (array.Length != 0)
				{
					this.1.Add(this.4(array[0]));
				}
			}
		}
		AppDomain.Unload(appDomain);
	}

	// Token: 0x0600316D RID: 12653 RVA: 0x0012785C File Offset: 0x00125A5C
	internal void 2()
	{
		if (this.2 == null)
		{
			return;
		}
		foreach (AppDomain domain in this.2.Values)
		{
			AppDomain.Unload(domain);
		}
		this.2.Clear();
	}

	// Token: 0x0600316E RID: 12654 RVA: 0x001278C8 File Offset: 0x00125AC8
	private AppDomain 3(2252 1)
	{
		AppDomainSetup appDomainSetup = new AppDomainSetup
		{
			ApplicationName = 1.RulesetName,
			ConfigurationFile = 1.RulesetName + ".dll.config",
			ApplicationBase = AppDomain.CurrentDomain.BaseDirectory,
			DisallowCodeDownload = true,
			PrivateBinPath = "Plugins/AiMod"
		};
		return AppDomain.CreateDomain(appDomainSetup.ApplicationName, AppDomain.CurrentDomain.Evidence, appDomainSetup);
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x00127938 File Offset: 0x00125B38
	private 2254 4(2252 1)
	{
		AppDomain appDomain;
		if (!this.2.TryGetValue(1, out appDomain))
		{
			appDomain = this.3(1);
			this.2[1] = appDomain;
		}
		return (2254)appDomain.CreateInstanceAndUnwrap(1.RulesetName, 1.EntryType);
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x00127981 File Offset: 0x00125B81
	public void Dispose()
	{
		this.2();
	}

	// Token: 0x04002467 RID: 9319
	internal List<2254> 1 = new List<2254>();

	// Token: 0x04002468 RID: 9320
	private Dictionary<2252, AppDomain> 2 = new Dictionary<2252, AppDomain>();
}
