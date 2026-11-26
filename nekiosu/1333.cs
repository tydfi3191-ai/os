using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

// Token: 0x02000B2C RID: 2860
public sealed class 1333
{
	// Token: 0x06004F27 RID: 20263 RVA: 0x001F414C File Offset: 0x001F234C
	public 1333()
	{
		1304.89.SubscribeChanged(new EventHandler(this.10));
		this.Reset();
		if (!1662.47)
		{
			this.2();
		}
	}

	// Token: 0x06004F28 RID: 20264 RVA: 0x001F41C4 File Offset: 0x001F23C4
	internal void 1(1189 1)
	{
		1189 2 = this.1;
		1189 3;
		do
		{
			3 = 2;
			1189 value = (1189)Delegate.Combine(3, 1);
			2 = Interlocked.CompareExchange<1189>(ref this.1, value, 3);
		}
		while (2 != 3);
	}

	// Token: 0x06004F29 RID: 20265 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void 2()
	{
	}

	// Token: 0x06004F2A RID: 20266 RVA: 0x001F41FC File Offset: 0x001F23FC
	internal void Reset()
	{
		this.8 = 99.0;
		this.9 = 250.0;
		this.11 = 0;
		this.10 = 0.0;
		this.7 = 0.0;
	}

	// Token: 0x06004F2B RID: 20267 RVA: 0x001F424C File Offset: 0x001F244C
	internal double 3()
	{
		return (double)(1662.50() ? 1000 : 30);
	}

	// Token: 0x06004F2C RID: 20268 RVA: 0x001F4260 File Offset: 0x001F2460
	internal void 4()
	{
		double num = Math.Pow(0.05, 1662.82 / 1000.0);
		this.11++;
		this.9 -= 1662.82;
		this.10 += 1662.82;
		if (this.9 <= 0.0)
		{
			this.9 += 250.0;
			this.7 = (double)((this.11 != 0) ? ((int)Math.Ceiling(Math.Min((double)((float)this.11 * 1000f) / this.10, 1662.34()))) : 0);
			this.10 = (double)(this.11 = 0);
		}
		if (1662.82 > this.3())
		{
			this.5();
		}
		1189 <<EMPTY_NAME>> = this.2;
		if (<<EMPTY_NAME>> != null)
		{
			<<EMPTY_NAME>>();
		}
		this.8 = num * this.8 + (1.0 - num) * 1662.82;
		this.4.Clear();
		this.5.Clear();
		this.6.Clear();
		this.14 = null;
		this.8();
	}

	// Token: 0x06004F2D RID: 20269 RVA: 0x001F43A0 File Offset: 0x001F25A0
	internal void 5()
	{
		StackTrace stackTrace = this.14;
		this.13.11(string.Empty, (1114)1);
		this.13.11(string.Format("---------- Slow Frame Detected at {0}s in {1} ----------", (1662.33 / 1000).ToString("#0.00", 1662.18), 1662.78), (1114)1);
		string text = "Statuses: ";
		if (1662.11.2())
		{
			text += "[Active] ";
		}
		if (1535.1())
		{
			text += "[Replay] ";
		}
		if (2486.14)
		{
			text += "[Playing] ";
		}
		if (1662.50())
		{
			text += "[CanRunSlow] ";
		}
		if (1662.87() > 30000)
		{
			text += "[Idle] ";
		}
		if (1662.107())
		{
			text += "[Tray] ";
		}
		if (1662.82 > Math.Min(20.0, this.8 * 8.0))
		{
			text += "[Severe] ";
		}
		this.13.11(text.Trim(), (1114)1);
		this.13.11(string.Empty, (1114)1);
		this.13.11("Game      " + 1662.33.ToString("#,0", 1662.18).PadLeft(6), (1114)1);
		this.13.11("Mode      " + 1662.56.ToString("#,0", 1662.18).PadLeft(6), (1114)1);
		this.13.11("Audio     " + 1226.16.ToString("#,0", 1662.18).PadLeft(6), (1114)1);
		this.13.11(string.Empty, (1114)1);
		foreach (KeyValuePair<1335, double> keyValuePair in this.4)
		{
			if (keyValuePair.Value > 5E-324)
			{
				this.13.11(keyValuePair.Key.ToString().PadRight(16) + keyValuePair.Value.ToString("#0.00", 1662.18).PadLeft(6), (1114)1);
			}
		}
		this.13.11(string.Empty, (1114)1);
		this.13.11("This Frame " + 1662.82.ToString("#0.00", 1662.18).PadLeft(6), (1114)1);
		this.13.11("Avg. Frame " + this.8.ToString("#0.00", 1662.18).PadLeft(6), (1114)1);
		this.13.11("Curr FPS   " + this.7.ToString("##.##", 1662.18).PadLeft(6), (1114)1);
		this.13.11(string.Empty, (1114)1);
		foreach (KeyValuePair<1056, int> keyValuePair2 in this.6)
		{
			if ((double)keyValuePair2.Value > 5E-324)
			{
				this.13.11(keyValuePair2.Key.ToString().PadRight(16) + keyValuePair2.Value.ToString("#,0", 1662.18).PadLeft(6), (1114)1);
			}
		}
		this.13.11(string.Empty, (1114)1);
		if (stackTrace != null)
		{
			this.13.11("Call stack follows:", (1114)1);
			this.13.11(string.Empty, (1114)1);
			foreach (StackFrame stackFrame in stackTrace.GetFrames())
			{
				this.13.11(string.Format("- {0} @ {1}", stackFrame.GetMethod(), stackFrame.GetNativeOffset()), (1114)1);
			}
		}
		else
		{
			this.13.11("Call stack was not recorded.", (1114)1);
		}
		1189 <<EMPTY_NAME>> = this.1;
		if (<<EMPTY_NAME>> == null)
		{
			return;
		}
		<<EMPTY_NAME>>();
	}

	// Token: 0x06004F2E RID: 20270 RVA: 0x001F480C File Offset: 0x001F2A0C
	internal void 6(1056 1)
	{
		1333.1334 2 = new 1333.1334();
		2.1 = this;
		2.2 = 1;
		1662.89.Schedule(new 1189(2.1), false);
	}

	// Token: 0x06004F2F RID: 20271 RVA: 0x001F4848 File Offset: 0x001F2A48
	internal void 7(1335 1)
	{
		if (!this.3.IsRunning)
		{
			this.3.Start();
		}
		if (this.5.Count > 0)
		{
			1335 2 = this.5.Peek();
			if (!this.4.ContainsKey(2))
			{
				this.4[2] = 0.0;
			}
			Dictionary<1335, double> dictionary = this.4;
			1335 key = 2;
			dictionary[key] += this.8();
		}
		this.5.Push(1);
	}

	// Token: 0x06004F30 RID: 20272 RVA: 0x001F48D4 File Offset: 0x001F2AD4
	private double 8()
	{
		double num = this.12;
		this.12 = this.3.GetElapsedMilliseconds();
		return this.12 - num;
	}

	// Token: 0x06004F31 RID: 20273 RVA: 0x001F4904 File Offset: 0x001F2B04
	internal void 9(1335 1)
	{
		if (this.5.Count == 0 || this.5.Peek() != 1)
		{
			this.4();
			return;
		}
		this.5.Pop();
		if (!this.4.ContainsKey(1))
		{
			this.4[1] = 0.0;
		}
		Dictionary<1335, double> dictionary = this.4;
		dictionary[1] += this.8();
	}

	// Token: 0x06004F32 RID: 20274 RVA: 0x001F4980 File Offset: 0x001F2B80
	private void 10(object 1, EventArgs 2)
	{
		this.Reset();
	}

	// Token: 0x04003B2A RID: 15146
	private 1189 1;

	// Token: 0x04003B2B RID: 15147
	private 1189 2;

	// Token: 0x04003B2C RID: 15148
	internal Stopwatch 3 = new Stopwatch();

	// Token: 0x04003B2D RID: 15149
	internal Dictionary<1335, double> 4 = new Dictionary<1335, double>();

	// Token: 0x04003B2E RID: 15150
	internal Stack<1335> 5 = new Stack<1335>();

	// Token: 0x04003B2F RID: 15151
	internal Dictionary<1056, int> 6 = new Dictionary<1056, int>();

	// Token: 0x04003B30 RID: 15152
	internal double 7;

	// Token: 0x04003B31 RID: 15153
	internal double 8;

	// Token: 0x04003B32 RID: 15154
	private double 9;

	// Token: 0x04003B33 RID: 15155
	private double 10;

	// Token: 0x04003B34 RID: 15156
	private int 11;

	// Token: 0x04003B35 RID: 15157
	private double 12;

	// Token: 0x04003B36 RID: 15158
	private 1338 13 = 1338.7(1341.Performance, true);

	// Token: 0x04003B37 RID: 15159
	private StackTrace 14;

	// Token: 0x02000B2D RID: 2861
	public sealed class 1334
	{
		// Token: 0x06004F33 RID: 20275 RVA: 0x001F4988 File Offset: 0x001F2B88
		internal void 1()
		{
			if (!this.1.6.ContainsKey(this.2))
			{
				this.1.6[this.2] = 1;
				return;
			}
			Dictionary<1056, int> <<EMPTY_NAME>> = this.1.6;
			1056 key = this.2;
			int num = <<EMPTY_NAME>>[key];
			<<EMPTY_NAME>>[key] = num + 1;
		}

		// Token: 0x04003B38 RID: 15160
		public 1333 1;

		// Token: 0x04003B39 RID: 15161
		public 1056 2;
	}
}
