using System;
using Microsoft.StylusInput;
using Microsoft.StylusInput.PluginData;

// Token: 0x02000A67 RID: 2663
public sealed class 1560 : IStylusAsyncPlugin
{
	// Token: 0x1700030B RID: 779
	// (get) Token: 0x060049C6 RID: 18886 RVA: 0x001D42D1 File Offset: 0x001D24D1
	public DataInterestMask DataInterest
	{
		get
		{
			return (DataInterestMask)2688;
		}
	}

	// Token: 0x060049C7 RID: 18887 RVA: 0x001D42D8 File Offset: 0x001D24D8
	internal 1560(1562 1)
	{
		this.1 = 1;
	}

	// Token: 0x060049C8 RID: 18888 RVA: 0x001D42E7 File Offset: 0x001D24E7
	public void StylusDown(RealTimeStylus 1, StylusDownData 2)
	{
		this.1.2 = true;
		this.1.3 = 199.Pressed;
	}

	// Token: 0x060049C9 RID: 18889 RVA: 0x001D4301 File Offset: 0x001D2501
	public void StylusUp(RealTimeStylus 1, StylusUpData 2)
	{
		this.1.3 = 199.Released;
		bool 3 = this.1.2;
	}

	// Token: 0x060049CA RID: 18890 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void TabletRemoved(RealTimeStylus 1, TabletRemovedData 2)
	{
	}

	// Token: 0x060049CB RID: 18891 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void CustomStylusDataAdded(RealTimeStylus 1, CustomStylusData 2)
	{
	}

	// Token: 0x060049CC RID: 18892 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void RealTimeStylusDisabled(RealTimeStylus 1, RealTimeStylusDisabledData 2)
	{
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void StylusOutOfRange(RealTimeStylus 1, StylusOutOfRangeData 2)
	{
	}

	// Token: 0x060049CE RID: 18894 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void StylusButtonUp(RealTimeStylus 1, StylusButtonUpData 2)
	{
	}

	// Token: 0x060049CF RID: 18895 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void StylusInRange(RealTimeStylus 1, StylusInRangeData 2)
	{
	}

	// Token: 0x060049D0 RID: 18896 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void RealTimeStylusEnabled(RealTimeStylus 1, RealTimeStylusEnabledData 2)
	{
	}

	// Token: 0x060049D1 RID: 18897 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void TabletAdded(RealTimeStylus 1, TabletAddedData 2)
	{
	}

	// Token: 0x060049D2 RID: 18898 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void Error(RealTimeStylus 1, ErrorData 2)
	{
	}

	// Token: 0x060049D3 RID: 18899 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void InAirPackets(RealTimeStylus 1, InAirPacketsData 2)
	{
	}

	// Token: 0x060049D4 RID: 18900 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void Packets(RealTimeStylus 1, PacketsData 2)
	{
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00053ADC File Offset: 0x00051CDC
	public void SystemGesture(RealTimeStylus 1, SystemGestureData 2)
	{
		throw new NotImplementedException();
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x00005ADD File Offset: 0x00003CDD
	public void StylusButtonDown(RealTimeStylus 1, StylusButtonDownData 2)
	{
	}

	// Token: 0x040036FD RID: 14077
	private 1562 1;
}
