using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

// Token: 0x0200096A RID: 2410
public sealed class 1727 : 1689
{
	// Token: 0x060043E7 RID: 17383 RVA: 0x001ABB28 File Offset: 0x001A9D28
	internal 1727() : base("Sprite Library", true)
	{
		this.18 = new 1417(new 207(0, 50, 640, 360), new 208(640f, 480f), false, 0f, 1545.Dialog);
		if (1272.5().61)
		{
			1272.5().62((1262.1266)2, false);
			this.29 = 1272.5().53();
		}
		else
		{
			this.29 = 1272.5().44();
		}
		this.21 = new List<string>();
		1361 <<EMPTY_NAME>> = new 1361("Cancel", new 208(40f, 440f), new 208(240f, 30f), 1f, 198.Gray, new EventHandler(this.13), true, false, null, true);
		this.7.14<1433>(<<EMPTY_NAME>>.1);
		<<EMPTY_NAME>> = new 1361("Browse...", new 208(360f, 440f), new 208(240f, 30f), 1f, 198.Orange, new EventHandler(this.14), true, false, null, true);
		this.7.14<1433>(<<EMPTY_NAME>>.1);
		string[] files = Directory.GetFiles(this.29, "*.png", SearchOption.AllDirectories);
		this.21.AddRange(files);
		string[] files2 = Directory.GetFiles(this.29, "*.jpg", SearchOption.AllDirectories);
		this.21.AddRange(files2);
	}

	// Token: 0x060043E8 RID: 17384 RVA: 0x001ABCB8 File Offset: 0x001A9EB8
	private void 12()
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Images (jpg/png)|*.jpg;*.png";
		openFileDialog.InitialDirectory = Path.GetFullPath(this.29);
		openFileDialog.RestoreDirectory = true;
		this.26 = false;
		if (DialogResult.OK != openFileDialog.ShowDialog(1662.13()))
		{
			return;
		}
		string fileName = openFileDialog.FileName;
		if (fileName.StartsWith(this.29))
		{
			return;
		}
		string text = Path.Combine(this.29, Path.GetFileName(fileName));
		if (fileName.Contains("0."))
		{
			this.27 = 0;
			for (;;)
			{
				string text2 = fileName.Replace("0.", this.27.ToString() + ".");
				if (!File.Exists(text2))
				{
					break;
				}
				try
				{
					File.Delete(Path.Combine(this.29, Path.GetFileName(text2)));
					File.Copy(text2, Path.Combine(this.29, Path.GetFileName(text2)));
				}
				catch (Exception)
				{
				}
				if (this.27 > 0)
				{
					this.26 = true;
				}
				this.27++;
			}
		}
		else
		{
			try
			{
				File.Delete(text);
				File.Copy(fileName, text);
			}
			catch
			{
			}
		}
		this.25 = text;
		1662.89.Schedule(new 1189(this.15), false);
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x001ABE10 File Offset: 0x001AA010
	internal override void DrawDialog()
	{
		base.DrawDialog();
		this.18.21();
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x001ABE24 File Offset: 0x001AA024
	public override void Update()
	{
		1727.1728 <<EMPTY_NAME>> = new 1727.1728();
		<<EMPTY_NAME>>.1 = this;
		if (this.23 && 1662.33 - this.24 > 40)
		{
			if (this.21.Count > 0)
			{
				this.19 = (float)(80 + 100 * (this.22 % 6));
				this.20 = (float)(50 + this.22 / 6 * 100);
				this.22++;
				<<EMPTY_NAME>>.3 = this.21[0].Replace(this.29 + Path.DirectorySeparatorChar.ToString(), string.Empty);
				<<EMPTY_NAME>>.2 = null;
				<<EMPTY_NAME>>.4 = 0;
				if (this.21.Count > 1 && <<EMPTY_NAME>>.3[<<EMPTY_NAME>>.3.Length - 5] == '0')
				{
					List<1381> list = new List<1381>();
					int num = 0;
					for (;;)
					{
						string text = <<EMPTY_NAME>>.3.Replace("0.", num++.ToString() + ".");
						1381 2 = 1455.2(text, (1416)4, null);
						if (2 == null)
						{
							break;
						}
						this.21.Remove(text);
						list.Add(2);
					}
					if (list.Count > 1)
					{
						1351 3 = new 1351(list.ToArray(), (1376)15, 1065.Centre, (1044)0, new 208(this.19, this.20), 0.98f, true, 198.White, null);
						3.15 = 98f / (float)Math.Max(3.39, 3.38);
						this.18.22.12(3);
						<<EMPTY_NAME>>.2 = 3;
						<<EMPTY_NAME>>.3 = <<EMPTY_NAME>>.3.Replace("0.", ".");
						<<EMPTY_NAME>>.4 = (int)((1226.73() != null) ? (1226.73().1 * 2.0 / (double)list.Count) : 500.0);
						3.53((double)<<EMPTY_NAME>>.4);
					}
				}
				if (<<EMPTY_NAME>>.2 == null)
				{
					<<EMPTY_NAME>>.2 = new 1433(1455.2(<<EMPTY_NAME>>.3, (1416)4, null), (1376)15, 1065.Centre, (1044)0, new 208(this.19, this.20), 0.98f, true, 198.White, null);
					<<EMPTY_NAME>>.2.15 = 98f / (float)Math.Max(<<EMPTY_NAME>>.2.39, <<EMPTY_NAME>>.2.38);
					this.18.22.12(<<EMPTY_NAME>>.2);
				}
				1433 4 = new 1433(1662.34, (1376)15, 1065.TopLeft, (1044)0, new 208(this.19 - 39f, this.20 - 39f), 0.9f, true, new 198(15, 15, 15, byte.MaxValue), null);
				4.42 = new 1445(4.6, new 198(50, 50, 50, byte.MaxValue), 0, 100);
				4.8 = <<EMPTY_NAME>>.2;
				4.3(new EventHandler(<<EMPTY_NAME>>.1));
				4.10 = true;
				4.20 = new 208(100f, 100f);
				this.18.22.12(4);
				1452 5 = new 1452(<<EMPTY_NAME>>.3, 8f, new 208(this.19 - 39f, this.20 - 50f), new 208(100f, 100f), 1f, true, 198.White, true);
				5.85 = false;
				5.74 = false;
				5.63(true);
				this.18.22.12(5);
				this.21.RemoveAt(0);
			}
			this.18.17(new 208(this.19 + 100f, this.20 + 100f));
			this.24 = 1662.33;
			if (this.21.Count == 0)
			{
				this.23 = false;
			}
		}
		this.18.Update();
		base.Update();
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x001AC254 File Offset: 0x001AA454
	protected override void Dispose(bool 1)
	{
		this.18.Dispose();
		base.Dispose(1);
	}

	// Token: 0x060043EC RID: 17388 RVA: 0x0015D36C File Offset: 0x0015B56C
	private void 13(object 1, EventArgs 2)
	{
		this.Close(false);
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x001AC268 File Offset: 0x001AA468
	private new void 14(object 1, EventArgs 2)
	{
		this.12();
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x0015D36C File Offset: 0x0015B56C
	private new void 15()
	{
		this.Close(false);
	}

	// Token: 0x040031C6 RID: 12742
	private readonly 1417 18;

	// Token: 0x040031C7 RID: 12743
	private float 19;

	// Token: 0x040031C8 RID: 12744
	private float 20;

	// Token: 0x040031C9 RID: 12745
	private List<string> 21;

	// Token: 0x040031CA RID: 12746
	private int 22;

	// Token: 0x040031CB RID: 12747
	private bool 23 = true;

	// Token: 0x040031CC RID: 12748
	private int 24;

	// Token: 0x040031CD RID: 12749
	internal string 25;

	// Token: 0x040031CE RID: 12750
	internal bool 26;

	// Token: 0x040031CF RID: 12751
	internal int 27;

	// Token: 0x040031D0 RID: 12752
	public double 28;

	// Token: 0x040031D1 RID: 12753
	private string 29;

	// Token: 0x0200096B RID: 2411
	public sealed class 1728
	{
		// Token: 0x060043EF RID: 17391 RVA: 0x001AC270 File Offset: 0x001AA470
		internal void 1(object 1, EventArgs 2)
		{
			this.1.26 = (this.2 is 1351);
			this.1.25 = this.3;
			if (this.1.26)
			{
				this.1.28 = (double)this.4;
				this.1.27 = ((1351)this.2).73;
			}
			this.1.Close(false);
		}

		// Token: 0x040031D2 RID: 12754
		public 1727 1;

		// Token: 0x040031D3 RID: 12755
		public 1433 2;

		// Token: 0x040031D4 RID: 12756
		public string 3;

		// Token: 0x040031D5 RID: 12757
		public int 4;
	}
}
