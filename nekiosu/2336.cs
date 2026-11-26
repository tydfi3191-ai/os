using System;

// Token: 0x020005A9 RID: 1449
public abstract class 2336
{
	// Token: 0x06002CFE RID: 11518 RVA: 0x000FC02C File Offset: 0x000FA22C
	internal 2336(2263 1)
	{
		this.3 = 1;
		this.4 = 1.7;
		this.5 = new 1436(true);
		this.6 = 1.8;
		this.7 = null;
	}

	// Token: 0x06002CFF RID: 11519 RVA: 0x000FC078 File Offset: 0x000FA278
	internal virtual bool IsInputEnabled()
	{
		return this.2;
	}

	// Token: 0x06002D00 RID: 11520 RVA: 0x000FC080 File Offset: 0x000FA280
	internal virtual void SetInputEnabled(bool 1)
	{
		this.2 = 1;
		this.5.22 = 1;
	}

	// Token: 0x06002D01 RID: 11521 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HasGrid()
	{
		return false;
	}

	// Token: 0x06002D02 RID: 11522 RVA: 0x000FC095 File Offset: 0x000FA295
	internal virtual void Initialize()
	{
		if (this.HasGrid())
		{
			this.CreateGrid();
		}
		this.CreateInterface();
		this.InitializeState();
		this.5.23();
	}

	// Token: 0x06002D03 RID: 11523 RVA: 0x00005ADD File Offset: 0x00003CDD
	protected virtual void CreateInterface()
	{
	}

	// Token: 0x06002D04 RID: 11524 RVA: 0x000FC0BC File Offset: 0x000FA2BC
	internal virtual void Draw()
	{
		if (this.7 != null)
		{
			this.7.5();
		}
		this.5.22();
	}

	// Token: 0x06002D05 RID: 11525
	internal abstract void Update();

	// Token: 0x06002D06 RID: 11526
	internal abstract void UpdateTimelineObjects();

	// Token: 0x06002D07 RID: 11527 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void DrawTimelineOverlay()
	{
	}

	// Token: 0x06002D08 RID: 11528 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleClick()
	{
		return false;
	}

	// Token: 0x06002D09 RID: 11529 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleRelease()
	{
		return false;
	}

	// Token: 0x06002D0A RID: 11530 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleDragStart()
	{
		return false;
	}

	// Token: 0x06002D0B RID: 11531 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void HandleDragEnd()
	{
	}

	// Token: 0x06002D0C RID: 11532 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void OnBeatmapLoaded()
	{
	}

	// Token: 0x06002D0D RID: 11533 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleKey(200 1, bool 2)
	{
		return false;
	}

	// Token: 0x06002D0E RID: 11534 RVA: 0x000FC0E0 File Offset: 0x000FA2E0
	internal virtual void Activate()
	{
		this.1 = true;
		this.5.5 = 1f;
		if (this.7 != null)
		{
			this.7.6 = true;
			1662.8.19(this.7.1());
		}
	}

	// Token: 0x06002D0F RID: 11535 RVA: 0x000FC12D File Offset: 0x000FA32D
	internal virtual void Deactivate()
	{
		this.1 = false;
		this.5.5 = 0f;
		if (this.7 != null)
		{
			this.7.6 = false;
		}
	}

	// Token: 0x06002D10 RID: 11536 RVA: 0x000FC15A File Offset: 0x000FA35A
	internal void 1(2337 1, bool 2)
	{
		if (this.7 != null)
		{
			this.7.3(1, 2);
		}
	}

	// Token: 0x06002D11 RID: 11537 RVA: 0x000FC171 File Offset: 0x000FA371
	internal virtual void CreateGrid()
	{
		this.7 = new 2332(this.3, 1304.145);
	}

	// Token: 0x06002D12 RID: 11538 RVA: 0x000FC189 File Offset: 0x000FA389
	internal virtual void Dispose()
	{
		this.5.Dispose();
	}

	// Token: 0x06002D13 RID: 11539 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void DrawTimelineContent()
	{
	}

	// Token: 0x06002D14 RID: 11540 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool IsEditingSliderPath()
	{
		return false;
	}

	// Token: 0x06002D15 RID: 11541 RVA: 0x0001702D File Offset: 0x0001522D
	internal virtual bool HandleEscape()
	{
		return true;
	}

	// Token: 0x06002D16 RID: 11542 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void SelectAll()
	{
	}

	// Token: 0x06002D17 RID: 11543 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void ClearSelection()
	{
	}

	// Token: 0x06002D18 RID: 11544 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void CopySelection()
	{
	}

	// Token: 0x06002D19 RID: 11545 RVA: 0x00005ADD File Offset: 0x00003CDD
	internal virtual void Paste()
	{
	}

	// Token: 0x06002D1A RID: 11546 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleDoubleClick()
	{
		return false;
	}

	// Token: 0x06002D1B RID: 11547
	protected abstract void InitializeState();

	// Token: 0x06002D1C RID: 11548 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleWheelDown()
	{
		return false;
	}

	// Token: 0x06002D1D RID: 11549 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleWheelUp()
	{
		return false;
	}

	// Token: 0x06002D1E RID: 11550 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleAltWheelUp()
	{
		return false;
	}

	// Token: 0x06002D1F RID: 11551 RVA: 0x0000FF75 File Offset: 0x0000E175
	internal virtual bool HandleAltWheelDown()
	{
		return false;
	}

	// Token: 0x04002121 RID: 8481
	internal bool 1;

	// Token: 0x04002122 RID: 8482
	private bool 2 = true;

	// Token: 0x04002123 RID: 8483
	internal 2263 3;

	// Token: 0x04002124 RID: 8484
	internal 2039 4;

	// Token: 0x04002125 RID: 8485
	internal 1436 5;

	// Token: 0x04002126 RID: 8486
	internal 2458 6;

	// Token: 0x04002127 RID: 8487
	internal 2332 7;
}
