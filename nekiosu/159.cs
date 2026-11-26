using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000103 RID: 259
[241(0)]
[242(1)]
public abstract class 159
{
	// Token: 0x060008F9 RID: 2297 RVA: 0x0001E73D File Offset: 0x0001C93D
	protected 159(158 1)
	{
		756.Method12216(1, "serializer");
		this.jsonSerializer2 = 1;
		this._recoveredType17753200 = 1.RecoveredType17751205;
	}

	// Token: 0x060008FA RID: 2298 RVA: 0x0001E763 File Offset: 0x0001C963
	internal 805<string, object> Method4116()
	{
		if (this._recoveredType24513198 == null)
		{
			this._recoveredType24513198 = new 805<string, object>(EqualityComparer<string>.Default, new 159.160(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
		}
		return this._recoveredType24513198;
	}

	// Token: 0x060008FB RID: 2299 RVA: 0x0001E794 File Offset: 0x0001C994
	protected 240 Method4117([241(2)] 612 1, 666 2)
	{
		240? nullable7775_ = 2.GetNullable7775_9913();
		if (nullable7775_ != null)
		{
			return nullable7775_.GetValueOrDefault();
		}
		240? 3 = (1 != null) ? 1.GetNullable6949_8953() : null;
		if (3 == null)
		{
			return this.jsonSerializer2.nullValueHandling2;
		}
		return 3.GetValueOrDefault();
	}

	// Token: 0x060008FC RID: 2300 RVA: 0x0001E7EA File Offset: 0x0001C9EA
	private 236 Method4118([241(2)] object 1, [241(2)] object 2, string 3, Exception 4)
	{
		if (this.errorContext2 == null)
		{
			this.errorContext2 = new 236(1, 2, 3, 4);
		}
		if (this.errorContext2.Error != 4)
		{
			throw new InvalidOperationException("Current error context error is different to requested error.");
		}
		return this.errorContext2;
	}

	// Token: 0x060008FD RID: 2301 RVA: 0x0001E824 File Offset: 0x0001CA24
	protected void Method4119()
	{
		if (this.errorContext2 == null)
		{
			throw new InvalidOperationException("Could not clear error context. Error context is already null.");
		}
		this.errorContext2 = null;
	}

	// Token: 0x060008FE RID: 2302 RVA: 0x0001E840 File Offset: 0x0001CA40
	[242(2)]
	protected bool Method4120(object 1, 902 2, object 3, 99 4, [241(1)] string 5, [241(1)] Exception 6)
	{
		236 7 = this.Method4118(1, 3, 5, 6);
		if (this._recoveredType17753200 != null && this._recoveredType17753200.GetLevelFilter() >= TraceLevel.Error && !7.GetFlag10909_14383())
		{
			7.SetFlag10909_14384(true);
			string text = (base.GetType() == typeof(166)) ? "Error serializing" : "Error deserializing";
			if (2 != null)
			{
				string str = text;
				string str2 = " ";
				Type underlyingType = 2.GetUnderlyingType();
				text = str + str2 + ((underlyingType != null) ? underlyingType.ToString() : null);
			}
			text = text + ". " + 6.Message;
			if (!(6 is 134))
			{
				text = 137.Method3522(4, 5, text);
			}
			this._recoveredType17753200.WriteTrace(TraceLevel.Error, text, 6);
		}
		if (2 != null && 1 != null)
		{
			2.InvokeErrorCallbacks(1, this.jsonSerializer2.Method1785(), 7);
		}
		if (!7.Handled)
		{
			this.jsonSerializer2.Method3857(new 713(1, 7));
		}
		return 7.Handled;
	}

	// Token: 0x040004E8 RID: 1256
	[241(2)]
	private 236 errorContext2;

	// Token: 0x040004E9 RID: 1257
	[241(new byte[]
	{
		2,
		1,
		1
	})]
	private 805<string, object> _recoveredType24513198;

	// Token: 0x040004EA RID: 1258
	internal readonly 158 jsonSerializer2;

	// Token: 0x040004EB RID: 1259
	[241(2)]
	internal readonly 665 _recoveredType17753200;

	// Token: 0x040004EC RID: 1260
	[241(2)]
	protected 366 _recoveredType03193201;

	// Token: 0x02000104 RID: 260
	[242(0)]
	public sealed class 160 : IEqualityComparer<object>
	{
		// Token: 0x060008FF RID: 2303 RVA: 0x0001E93C File Offset: 0x0001CB3C
		[242(2)]
		private bool Method4114(object 1, object 2)
		{
			return 1 == 2;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001E942 File Offset: 0x0001CB42
		bool IEqualityComparer<object>.Equals(object 1, object 2)
		{
			return this.Method4114(1, 2);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001E94C File Offset: 0x0001CB4C
		[242(1)]
		private int Method4115(object 1)
		{
			return RuntimeHelpers.GetHashCode(1);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001E954 File Offset: 0x0001CB54
		int IEqualityComparer<object>.GetHashCode(object 1)
		{
			return this.Method4115(1);
		}
	}
}
