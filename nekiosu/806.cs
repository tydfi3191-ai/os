using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

// Token: 0x020001F7 RID: 503
[ComVisible(false)]
[242(1)]
[241(0)]
public class 806 : 902
{
	// Token: 0x06000FED RID: 4077 RVA: 0x000362C4 File Offset: 0x000344C4
	public 806(Type 1) : base(1)
	{
		this._recoveredType17440783 = (659)3;
		this.SetRecoveredType206110432_13503(358.Method1490(1));
		this.flag5 = true;
		815 internalReadType;
		if (806.dictionary.TryGetValue(this.nonNullableUnderlyingType, out internalReadType))
		{
			this.internalReadType = internalReadType;
		}
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x0003630D File Offset: 0x0003450D
	internal 723 GetRecoveredType206110432_13502()
	{
		return this._recoveredType206110432;
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00036315 File Offset: 0x00034515
	internal void SetRecoveredType206110432_13503(723 1)
	{
		this._recoveredType206110432 = 1;
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00036320 File Offset: 0x00034520
	// Note: this type is marked as 'beforefieldinit'.
	static 806()
	{
		Dictionary<Type, 815> dictionary = new Dictionary<Type, 815>();
		Type typeFromHandle = typeof(byte[]);
		dictionary[typeFromHandle] = (815)3;
		Type typeFromHandle2 = typeof(byte);
		dictionary[typeFromHandle2] = (815)1;
		Type typeFromHandle3 = typeof(short);
		dictionary[typeFromHandle3] = (815)1;
		Type typeFromHandle4 = typeof(int);
		dictionary[typeFromHandle4] = (815)1;
		Type typeFromHandle5 = typeof(decimal);
		dictionary[typeFromHandle5] = (815)5;
		Type typeFromHandle6 = typeof(bool);
		dictionary[typeFromHandle6] = (815)9;
		Type typeFromHandle7 = typeof(string);
		dictionary[typeFromHandle7] = (815)4;
		Type typeFromHandle8 = typeof(DateTime);
		dictionary[typeFromHandle8] = (815)6;
		Type typeFromHandle9 = typeof(DateTimeOffset);
		dictionary[typeFromHandle9] = (815)7;
		Type typeFromHandle10 = typeof(float);
		dictionary[typeFromHandle10] = (815)8;
		Type typeFromHandle11 = typeof(double);
		dictionary[typeFromHandle11] = (815)8;
		Type typeFromHandle12 = typeof(long);
		dictionary[typeFromHandle12] = (815)2;
		806.dictionary = dictionary;
	}

	// Token: 0x040007B7 RID: 1975
	private 723 _recoveredType206110432;

	// Token: 0x040007B8 RID: 1976
	private static readonly Dictionary<Type, 815> dictionary;
}
