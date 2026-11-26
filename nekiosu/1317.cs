using System;

// Token: 0x02000B57 RID: 2903
public interface 1317
{
	// Token: 0x06004FF7 RID: 20471
	void SubscribeChanged(EventHandler 1);

	// Token: 0x06004FF8 RID: 20472
	void UnsubscribeChanged(EventHandler 1);

	// Token: 0x06004FF9 RID: 20473
	void ClearChangedHandlers();

	// Token: 0x06004FFA RID: 20474
	string GetConfigurationKey();

	// Token: 0x06004FFB RID: 20475
	void SetConfigurationKey(string 1);
}
