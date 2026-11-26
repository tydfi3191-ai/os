using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x020003CF RID: 975
internal sealed partial class 252 : Form
{
	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00078903 File Offset: 0x00076B03
	// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x0007890B File Offset: 0x00076B0B
	internal 258 Choice { get; private set; }

	// Token: 0x06001EE7 RID: 7911 RVA: 0x00078914 File Offset: 0x00076B14
	private static Font 1(float 1, bool 2)
	{
		FontStyle style = 2 ? FontStyle.Bold : FontStyle.Regular;
		foreach (string text in new string[]
		{
			"Segoe UI Variable Display",
			"Segoe UI"
		})
		{
			Font font = new Font(text, 1, style, GraphicsUnit.Point);
			if (string.Equals(font.Name, text, StringComparison.OrdinalIgnoreCase))
			{
				return font;
			}
			font.Dispose();
		}
		return new Font(FontFamily.GenericSansSerif, 1, style, GraphicsUnit.Point);
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x00078984 File Offset: 0x00076B84
	private static GraphicsPath 2(RectangleF 1, float 2)
	{
		float num = 2 * 2f;
		GraphicsPath graphicsPath = new GraphicsPath();
		graphicsPath.AddArc(1.X, 1.Y, num, num, 180f, 90f);
		graphicsPath.AddArc(1.Right - num, 1.Y, num, num, 270f, 90f);
		graphicsPath.AddArc(1.Right - num, 1.Bottom - num, num, num, 0f, 90f);
		graphicsPath.AddArc(1.X, 1.Bottom - num, num, num, 90f, 90f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00078A2C File Offset: 0x00076C2C
	private static void 3(Graphics 1)
	{
		1.SmoothingMode = SmoothingMode.AntiAlias;
		1.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00078A3C File Offset: 0x00076C3C
	private static GraphicsPath 4()
	{
		GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);
		graphicsPath.StartFigure();
		graphicsPath.AddLine(20.317f, 4.3698f, 15.4319f, 2.8546f);
		graphicsPath.AddLine(15.4319f, 2.8546f, 15.3534f, 2.8917f);
		graphicsPath.AddBezier(15.3534f, 2.8917f, 15.1424f, 3.267f, 14.9087f, 3.7565f, 14.7451f, 4.1412f);
		graphicsPath.AddBezier(14.7451f, 4.1412f, 12.9004f, 3.865f, 11.0651f, 3.865f, 9.2583f, 4.1412f);
		graphicsPath.AddBezier(9.2583f, 4.1412f, 9.0947f, 3.7479f, 8.8525f, 3.267f, 8.6406f, 2.8917f);
		graphicsPath.AddLine(8.6406f, 2.8917f, 8.5621f, 2.8547f);
		graphicsPath.AddLine(8.5621f, 2.8547f, 3.6769f, 4.3697f);
		graphicsPath.AddLine(3.6769f, 4.3697f, 3.6448f, 4.3974f);
		graphicsPath.AddBezier(3.6448f, 4.3974f, 0.5334f, 9.0458f, -0.319f, 13.5799f, 0.0992f, 18.0578f);
		graphicsPath.AddLine(0.0992f, 18.0578f, 0.1304f, 18.1139f);
		graphicsPath.AddBezier(0.1304f, 18.1139f, 2.1832f, 19.6215f, 4.1717f, 20.5367f, 6.1233f, 21.1433f);
		graphicsPath.AddLine(6.1233f, 21.1433f, 6.2075f, 21.1157f);
		graphicsPath.AddBezier(6.2075f, 21.1157f, 6.6691f, 20.4853f, 7.0806f, 19.8205f, 7.4335f, 19.1215f);
		graphicsPath.AddLine(7.4335f, 19.1215f, 7.3919f, 19.0158f);
		graphicsPath.AddBezier(7.3919f, 19.0158f, 6.7391f, 18.7682f, 6.1176f, 18.4663f, 5.5197f, 18.1235f);
		graphicsPath.AddLine(5.5197f, 18.1235f, 5.5121f, 17.9958f);
		graphicsPath.AddBezier(5.5121f, 17.9958f, 5.6379f, 17.9015f, 5.7638f, 17.8035f, 5.8839f, 17.7044f);
		graphicsPath.AddLine(5.8839f, 17.7044f, 5.9615f, 17.6939f);
		graphicsPath.AddBezier(5.9615f, 17.6939f, 9.8893f, 19.4872f, 14.1415f, 19.4872f, 18.0229f, 17.6939f);
		graphicsPath.AddLine(18.0229f, 17.6939f, 18.1014f, 17.7034f);
		graphicsPath.AddBezier(18.1014f, 17.7034f, 18.2216f, 17.8024f, 18.3474f, 17.9015f, 18.4742f, 17.9958f);
		graphicsPath.AddLine(18.4742f, 17.9958f, 18.4676f, 18.1234f);
		graphicsPath.AddLine(18.4676f, 18.1234f, 16.5946f, 19.0148f);
		graphicsPath.AddLine(16.5946f, 19.0148f, 16.5539f, 19.1215f);
		graphicsPath.AddBezier(16.5539f, 19.1215f, 16.9143f, 19.8195f, 17.3258f, 20.4843f, 17.7789f, 21.1147f);
		graphicsPath.AddLine(17.7789f, 21.1147f, 17.8631f, 21.1433f);
		graphicsPath.AddBezier(17.8631f, 21.1433f, 19.8241f, 20.5366f, 21.8126f, 19.6214f, 23.8654f, 18.1139f);
		graphicsPath.AddLine(23.8654f, 18.1139f, 23.8967f, 18.0587f);
		graphicsPath.AddBezier(23.8967f, 18.0587f, 24.3971f, 12.8817f, 23.0585f, 8.3848f, 20.3482f, 4.3983f);
		graphicsPath.AddLine(20.3482f, 4.3983f, 20.317f, 4.3697f);
		graphicsPath.CloseFigure();
		graphicsPath.StartFigure();
		graphicsPath.AddBezier(8.02f, 15.3312f, 6.8375f, 15.3312f, 5.8631f, 14.2455f, 5.8631f, 12.9122f);
		graphicsPath.AddBezier(5.8631f, 12.9122f, 5.8631f, 11.579f, 6.8186f, 10.4933f, 8.0201f, 10.4933f);
		graphicsPath.AddBezier(8.0201f, 10.4933f, 9.2309f, 10.4933f, 10.1958f, 11.5885f, 10.1769f, 12.9123f);
		graphicsPath.AddBezier(10.1769f, 12.9123f, 10.1769f, 14.2455f, 9.2214f, 15.3312f, 8.02f, 15.3312f);
		graphicsPath.CloseFigure();
		graphicsPath.StartFigure();
		graphicsPath.AddBezier(15.9948f, 15.3312f, 14.8123f, 15.3312f, 13.8379f, 14.2455f, 13.8379f, 12.9122f);
		graphicsPath.AddBezier(13.8379f, 12.9122f, 13.8379f, 11.579f, 14.7933f, 10.4933f, 15.9948f, 10.4933f);
		graphicsPath.AddBezier(15.9948f, 10.4933f, 17.2056f, 10.4933f, 18.1705f, 11.5885f, 18.1516f, 12.9123f);
		graphicsPath.AddBezier(18.1516f, 12.9123f, 18.1516f, 14.2455f, 17.2056f, 15.3312f, 15.9948f, 15.3312f);
		graphicsPath.CloseFigure();
		return graphicsPath;
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x00078FF4 File Offset: 0x000771F4
	private static void 5(Graphics 1, RectangleF 2, Color 3, float 4)
	{
		using (Pen pen = new Pen(3, 4)
		{
			StartCap = LineCap.Round,
			EndCap = LineCap.Round,
			LineJoin = LineJoin.Round
		})
		{
			1.DrawLines(pen, new PointF[]
			{
				new PointF(2.X + 2.Width * 0.27f, 2.Y + 2.Height * 0.53f),
				new PointF(2.X + 2.Width * 0.44f, 2.Y + 2.Height * 0.69f),
				new PointF(2.X + 2.Width * 0.74f, 2.Y + 2.Height * 0.35f)
			});
		}
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x000790EC File Offset: 0x000772EC
	internal 252(string 1, bool 2, bool 3, bool 4, string 5, string 6, Func<string, bool> 7)
	{
		252 <>4__this = this;
		this.12 = 7;
		this.17 = 4;
		base.SuspendLayout();
		this.Text = "nekiosu";
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		base.ClientSize = new Size(640, 438);
		base.FormBorderStyle = FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.StartPosition = FormStartPosition.Manual;
		this.BackColor = 252.1;
		this.ForeColor = 252.8;
		this.Font = 252.1(10.5f, false);
		try
		{
			base.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
		}
		catch (Exception)
		{
		}
		base.Controls.Add(252.11("nekiosu", 252.1(30f, true), 252.6, 252.1, 28, 22, 400, 62));
		if (6 != null)
		{
			Label label = 252.11(6, this.Font, 252.9, 252.1, 418, 41, 200, 24);
			label.TextAlign = ContentAlignment.MiddleRight;
			base.Controls.Add(label);
		}
		252.254 8 = new 252.254
		{
			Location = new Point(22, 100),
			Size = new Size(596, 180)
		};
		8.Controls.Add(252.11("your osu! folder", 252.1(14f, true), 252.8, 252.2, 18, 14, 540, 30));
		8.Controls.Add(252.11("nekiosu runs on your current osu! install.", this.Font, 252.9, 252.2, 19, 48, 560, 22));
		8.Controls.Add(252.11("your own scores and settings aren't changed or touched.", this.Font, 252.9, 252.2, 19, 69, 560, 22));
		252.254 9 = new 252.254
		{
			Location = new Point(20, 102),
			Size = new Size(456, 34),
			1 = 252.4,
			3 = 6f
		};
		this.14 = new TextBox
		{
			Location = new Point(12, 7),
			Size = new Size(432, 22),
			BackColor = 252.4,
			ForeColor = 252.8,
			BorderStyle = BorderStyle.None,
			Font = 252.1(11f, false),
			Text = (12 ?? string.Empty)
		};
		this.14.TextChanged += delegate(object 1, EventArgs 2)
		{
			<>4__this.13();
		};
		9.Controls.Add(this.14);
		8.Controls.Add(9);
		252.253 10 = 252.12("browse...", 484, 102, 94, 34, false);
		10.BackColor = 252.2;
		10.Click += delegate(object 1, EventArgs 2)
		{
			<>4__this.14();
		};
		8.Controls.Add(10);
		this.13 = new 252.255
		{
			Location = new Point(20, 144),
			Size = new Size(556, 26),
			Font = 252.1(11f, false),
			ForeColor = 252.10,
			BackColor = 252.2
		};
		8.Controls.Add(this.13);
		base.Controls.Add(8);
		this.15 = new 252.256
		{
			Text = "enable internet (osu!direct, beatmap updates and online rankings)",
			Location = new Point(24, 296),
			Size = new Size(594, 28),
			ForeColor = Color.FromArgb(214, 218, 230),
			Font = 252.1(10.5f, false),
			1 = !13
		};
		base.Controls.Add(this.15);
		int num = this.15.Left + 20 + (int)((float)TextRenderer.MeasureText("enable internet (osu!direct, beatmap updates and ", this.15.Font, Size.Empty, TextFormatFlags.NoPadding).Width * 96f / (float)base.DeviceDpi);
		base.Controls.Add(252.11("(requires api key)", 252.1(8.5f, false), 252.9, 252.1, num, 321, 200, 16));
		this.16 = new 252.256
		{
			Text = "don't show this window on start (hold shift to open it)",
			Location = new Point(24, 338),
			Size = new Size(594, 28),
			ForeColor = Color.FromArgb(214, 218, 230),
			Font = 252.1(10.5f, false),
			1 = 3
		};
		base.Controls.Add(this.16);
		this.23 = 252.11(string.Empty, this.Font, 252.8, 252.1, 24, 374, 594, 40);
		this.23.AutoEllipsis = false;
		this.23.Visible = false;
		base.Controls.Add(this.23);
		this.21 = 252.12("check for updates", 22, 380, 164, 38, false);
		this.21.Click += delegate(object 1, EventArgs 2)
		{
			<>4__this.15();
		};
		base.Controls.Add(this.21);
		this.22 = 252.11(string.Empty, 252.1(9.5f, false), 252.9, 252.1, 194, 380, 154, 38);
		this.22.TextAlign = ContentAlignment.MiddleLeft;
		base.Controls.Add(this.22);
		this.26 = 252.12(string.Empty, 354, 380, 38, 38, false);
		this.26.2 = 252.4();
		this.26.3 = Color.FromArgb(88, 101, 242);
		this.26.Visible = false;
		this.26.Click += delegate(object 1, EventArgs 2)
		{
			if (!261.24(<>4__this.27))
			{
				<>4__this.21("could not open the browser.", 252.11);
			}
		};
		new ToolTip().SetToolTip(this.26, "nekiosu's discord");
		base.Controls.Add(this.26);
		252.253 11 = 252.12("exit", 400, 380, 100, 38, false);
		11.Font = 252.1(11f, true);
		11.Click += delegate(object 1, EventArgs 2)
		{
			<>4__this.Close();
		};
		base.Controls.Add(11);
		this.20 = 252.12("play", 510, 380, 108, 38, true);
		this.20.Font = 252.1(11.5f, true);
		this.20.Click += delegate(object 1, EventArgs 2)
		{
			<>4__this.Play();
		};
		base.Controls.Add(this.20);
		base.AcceptButton = this.20;
		base.CancelButton = 11;
		this.24.AddRange(new Control[]
		{
			this.21,
			this.22,
			this.26,
			11,
			this.20
		});
		base.Shown += delegate(object 1, EventArgs 2)
		{
			if (<>4__this.WindowState == FormWindowState.Minimized)
			{
				<>4__this.WindowState = FormWindowState.Normal;
			}
			252.8(<>4__this);
			<>4__this.ActiveControl = (7(<>4__this.FolderText) ? <>4__this.20 : <>4__this.14);
			<>4__this.15();
		};
		base.ResumeLayout(false);
		base.PerformLayout();
		this.13();
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x000798B8 File Offset: 0x00077AB8
	internal static void 6()
	{
		try
		{
			Thread thread = new Thread(delegate()
			{
				try
				{
					using (Form window = new Form())
					{
						window.Text = "nekiosu";
						window.SuspendLayout();
						window.AutoScaleDimensions = new SizeF(96f, 96f);
						window.AutoScaleMode = AutoScaleMode.Dpi;
						window.ClientSize = new Size(360, 90);
						window.FormBorderStyle = FormBorderStyle.FixedSingle;
						window.MaximizeBox = false;
						window.MinimizeBox = false;
						window.ControlBox = false;
						window.BackColor = 252.1;
						window.ForeColor = 252.8;
						window.Font = 252.1(10.5f, false);
						try
						{
							window.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
						}
						catch (Exception)
						{
						}
						window.Controls.Add(252.11("starting...", 252.1(11f, false), 252.8, 252.1, 20, 30, 320, 30));
						window.ResumeLayout(false);
						window.PerformLayout();
						window.Load += delegate(object 1, EventArgs 2)
						{
							252.9(window);
							if (252.33)
							{
								window.BeginInvoke(new MethodInvoker(window.Close));
							}
						};
						252.32 = window;
						Application.Run(window);
					}
				}
				catch (Exception)
				{
				}
				finally
				{
					252.32 = null;
				}
			});
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x00079914 File Offset: 0x00077B14
	internal static void 7()
	{
		252.33 = true;
		Form form = 252.32;
		try
		{
			if (form != null && form.IsHandleCreated)
			{
				form.BeginInvoke(new MethodInvoker(form.Close));
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06001EEF RID: 7919
	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x06001EF0 RID: 7920
	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(IntPtr 1, IntPtr 2);

	// Token: 0x06001EF1 RID: 7921
	[DllImport("user32.dll")]
	private static extern bool AttachThreadInput(uint 1, uint 2, bool 3);

	// Token: 0x06001EF2 RID: 7922
	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr 1);

	// Token: 0x06001EF3 RID: 7923
	[DllImport("kernel32.dll")]
	private static extern uint GetCurrentThreadId();

	// Token: 0x06001EF4 RID: 7924 RVA: 0x00079964 File Offset: 0x00077B64
	internal static void 8(Form 1)
	{
		try
		{
			IntPtr foregroundWindow = 252.GetForegroundWindow();
			uint num = (foregroundWindow == IntPtr.Zero) ? 0U : 252.GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero);
			uint currentThreadId = 252.GetCurrentThreadId();
			bool flag = num != 0U && num != currentThreadId && 252.AttachThreadInput(currentThreadId, num, true);
			try
			{
				1.TopMost = true;
				1.TopMost = false;
				252.SetForegroundWindow(1.Handle);
				1.BringToFront();
				1.Activate();
			}
			finally
			{
				if (flag)
				{
					252.AttachThreadInput(currentThreadId, num, false);
				}
			}
		}
		catch (Exception)
		{
			1.Activate();
		}
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x00079A08 File Offset: 0x00077C08
	protected override void OnLoad(EventArgs 1)
	{
		base.OnLoad(1);
		base.WindowState = FormWindowState.Normal;
		252.9(this);
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x00079A20 File Offset: 0x00077C20
	internal static void 9(Form 1)
	{
		Rectangle workingArea = Screen.FromPoint(Cursor.Position).WorkingArea;
		1.StartPosition = FormStartPosition.Manual;
		1.Location = new Point(workingArea.Left + Math.Max(0, (workingArea.Width - 1.Width) / 2), workingArea.Top + Math.Max(0, (workingArea.Height - 1.Height) / 2));
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x00079A8C File Offset: 0x00077C8C
	private void 10(bool 1)
	{
		this.23.Visible = 1;
		if (1 == this.25)
		{
			return;
		}
		this.25 = 1;
		int num = (int)Math.Round((double)((float)(40 * base.DeviceDpi) / 96f)) * (1 ? 1 : -1);
		foreach (Control control in this.24)
		{
			control.Top += num;
		}
		base.ClientSize = new Size(base.ClientSize.Width, base.ClientSize.Height + num);
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x00079B4C File Offset: 0x00077D4C
	private static Label 11(string 1, Font 2, Color 3, Color 4, int 5, int 6, int 7, int 8)
	{
		return new Label
		{
			Text = 1,
			Font = 2,
			ForeColor = 3,
			BackColor = 4,
			Location = new Point(5, 6),
			Size = new Size(7, 8),
			AutoEllipsis = true
		};
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x00079BA0 File Offset: 0x00077DA0
	private static 252.253 12(string 1, int 2, int 3, int 4, int 5, bool 6)
	{
		return new 252.253
		{
			Text = 1,
			Location = new Point(2, 3),
			Size = new Size(4, 5),
			1 = 6,
			Font = 252.1(10.5f, false)
		};
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00079BED File Offset: 0x00077DED
	private string FolderText
	{
		get
		{
			return this.14.Text.Trim().Trim(new char[]
			{
				'"'
			});
		}
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x00079C10 File Offset: 0x00077E10
	private void 13()
	{
		if (this.20 == null)
		{
			return;
		}
		string folderText = this.FolderText;
		bool flag = this.12(folderText);
		this.13.2 = (folderText.Length > 0);
		this.13.1 = flag;
		if (folderText.Length == 0)
		{
			this.13.Text = "choose the folder that has osu!.exe in it.";
			this.13.ForeColor = 252.9;
		}
		else if (flag)
		{
			this.13.Text = "found an osu! folder.";
			this.13.ForeColor = 252.10;
		}
		else if (!Directory.Exists(folderText))
		{
			this.13.Text = "this folder does not exist.";
			this.13.ForeColor = 252.11;
		}
		else
		{
			this.13.Text = "not an osu! install: osu!.exe and its library files should be in it.";
			this.13.ForeColor = 252.11;
		}
		this.13.Invalidate();
		this.20.Enabled = (flag && !this.30 && !this.31);
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00079D20 File Offset: 0x00077F20
	private void 14()
	{
		using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
		{
			folderBrowserDialog.Description = "choose your osu! folder (the one with osu!.exe in it).";
			folderBrowserDialog.ShowNewFolderButton = false;
			string text = this.FolderText;
			if (text.Length == 0 || !Directory.Exists(text))
			{
				text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "osu!");
			}
			if (Directory.Exists(text))
			{
				folderBrowserDialog.SelectedPath = text;
			}
			if (folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				this.14.Text = folderBrowserDialog.SelectedPath;
			}
		}
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x00079DB4 File Offset: 0x00077FB4
	private void Play()
	{
		if (this.30 || this.31)
		{
			return;
		}
		if (this.28 != null && !this.18 && !this.29)
		{
			this.18 = true;
			this.19 = true;
			this.15();
			return;
		}
		this.Choice = new 258
		{
			1 = this.FolderText,
			2 = !this.15.1,
			3 = this.16.1
		};
		base.Close();
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x00079E44 File Offset: 0x00078044
	private void 15()
	{
		if (this.29)
		{
			return;
		}
		273.274 pending = this.28;
		if (pending == null && !273.2())
		{
			this.21("no internet: update check skipped.", 252.9);
			return;
		}
		this.20(true);
		this.21((pending == null) ? "checking for updates..." : "getting the changelog...", 252.9);
		new Thread(delegate()
		{
			try
			{
				if (pending == null)
				{
					273.275 found = 273.1(268.UsageId);
					this.22(delegate
					{
						this.19(found);
					});
				}
				else
				{
					string changelog = 273.3();
					bool confirmed = false;
					this.Invoke(new MethodInvoker(delegate()
					{
						252.257 <<EMPTY_NAME>> = this.17(pending.1, changelog);
						confirmed = (<<EMPTY_NAME>> == 252.257.Update);
						if (!confirmed)
						{
							this.20(false);
							this.21("version " + pending.1 + " is out.", this.31 ? 252.11 : 252.6);
							bool flag = this.19 && <<EMPTY_NAME>> == 252.257.Later;
							this.19 = false;
							if (flag)
							{
								this.Play();
								return;
							}
						}
						else
						{
							this.19 = false;
							this.30 = true;
							this.13();
							this.21("downloading...", 252.9);
						}
					}));
					if (confirmed)
					{
						byte[] exe = 273.Download(pending, delegate(double 1)
						{
							this.22(delegate
							{
								this.21("downloading... " + ((int)(1 * 100.0)).ToString() + "%", 252.9);
							});
						});
						this.22(delegate
						{
							this.21("restarting...", 252.9);
							try
							{
								273.4(exe, pending.1);
							}
							catch (Exception ex2)
							{
								this.20(false);
								this.21("could not install: " + ex2.Message, 252.11);
							}
						});
					}
				}
			}
			catch (Exception ex)
			{
				string text = (ex is InvalidOperationException) ? ex.Message : "the update failed.";
				this.22(delegate
				{
					this.20(false);
					this.21((pending == null) ? "could not check for updates." : text, (pending == null) ? 252.9 : 252.11);
					if (this.19)
					{
						this.19 = false;
						this.Play();
					}
				});
			}
		})
		{
			IsBackground = true
		}.Start();
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x00079ED8 File Offset: 0x000780D8
	internal static bool 16(273.274 1)
	{
		string text = null;
		try
		{
			text = 273.3();
		}
		catch (Exception)
		{
		}
		252.257 4 = 252.18(null, 3.1, text, true);
		if (4 != 252.257.Update)
		{
			return 4 == 252.257.Later;
		}
		string failure = null;
		using (Form dialog = new Form())
		{
			dialog.Text = "nekiosu " + 3.1;
			dialog.SuspendLayout();
			dialog.AutoScaleDimensions = new SizeF(96f, 96f);
			dialog.AutoScaleMode = AutoScaleMode.Dpi;
			dialog.ClientSize = new Size(360, 90);
			dialog.FormBorderStyle = FormBorderStyle.FixedSingle;
			dialog.MaximizeBox = false;
			dialog.MinimizeBox = false;
			dialog.ControlBox = false;
			dialog.Load += delegate(object 1, EventArgs 2)
			{
				252.9(dialog);
			};
			dialog.BackColor = 252.1;
			dialog.ForeColor = 252.8;
			dialog.Font = 252.1(10.5f, false);
			Label progressText = 252.11("downloading...", 252.1(11f, false), 252.8, 252.1, 20, 30, 320, 30);
			dialog.Controls.Add(progressText);
			dialog.ResumeLayout(false);
			dialog.PerformLayout();
			dialog.Shown += delegate(object 1, EventArgs 2)
			{
				new Thread(delegate()
				{
					try
					{
						byte[] exe = 273.Download(3, delegate(double 1)
						{
							dialog.BeginInvoke(new MethodInvoker(delegate()
							{
								progressText.Text = "downloading... " + ((int)(1 * 100.0)).ToString() + "%";
							}));
						});
						dialog.Invoke(new MethodInvoker(delegate()
						{
							progressText.Text = "restarting...";
							273.4(exe, 3.1);
						}));
					}
					catch (Exception ex)
					{
						failure = ((ex is InvalidOperationException) ? ex.Message : "the update failed.");
						dialog.BeginInvoke(new MethodInvoker(dialog.Close));
					}
				})
				{
					IsBackground = true
				}.Start();
			};
			dialog.ShowDialog();
		}
		MessageBox.Show("Could not update: " + (failure ?? "the update failed.") + "\nnekiosu starts as it is.", "nekiosu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		return true;
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x0007A17C File Offset: 0x0007837C
	private 252.257 17(string 1, string 2)
	{
		return 252.18(this, 1, 2, this.19);
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x0007A18C File Offset: 0x0007838C
	internal static 252.257 18(IWin32Window 1, string 2, string 3, bool 4)
	{
		252.257 result;
		using (Form dialog = new Form())
		{
			dialog.Text = "nekiosu " + 8;
			dialog.SuspendLayout();
			dialog.AutoScaleDimensions = new SizeF(96f, 96f);
			dialog.AutoScaleMode = AutoScaleMode.Dpi;
			dialog.ClientSize = new Size(520, 400);
			dialog.FormBorderStyle = FormBorderStyle.FixedSingle;
			dialog.MaximizeBox = false;
			dialog.MinimizeBox = false;
			dialog.ShowInTaskbar = false;
			dialog.StartPosition = FormStartPosition.CenterParent;
			if (7 == null)
			{
				dialog.Load += delegate(object 1, EventArgs 2)
				{
					252.9(dialog);
				};
			}
			dialog.ShowInTaskbar = (7 == null);
			dialog.BackColor = 252.1;
			dialog.ForeColor = 252.8;
			dialog.Font = 252.1(10.5f, false);
			try
			{
				dialog.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			}
			catch (Exception)
			{
			}
			dialog.Controls.Add(252.11(4 ? ("update to " + 8 + " before playing?") : ("what's new in " + 8), 252.1(14f, true), 252.8, 252.1, 20, 14, 480, 30));
			252.254 5 = new 252.254
			{
				Location = new Point(20, 52),
				Size = new Size(480, 280),
				1 = 252.4,
				3 = 6f
			};
			TextBox notes = new TextBox
			{
				Location = new Point(10, 8),
				Size = new Size(460, 264),
				Multiline = true,
				ReadOnly = true,
				ScrollBars = ScrollBars.Vertical,
				BorderStyle = BorderStyle.None,
				BackColor = 252.4,
				ForeColor = 252.8,
				Font = 252.1(10.5f, false),
				Text = (string.IsNullOrEmpty(3) ? "(no notes)" : 3.Replace("\r\n", "\n").Replace("\n", "\r\n"))
			};
			5.Controls.Add(notes);
			dialog.Controls.Add(5);
			252.253 6 = 252.12(4 ? "play" : "not now", 282, 346, 100, 38, false);
			6.DialogResult = DialogResult.No;
			6.Click += delegate(object 1, EventArgs 2)
			{
				dialog.DialogResult = DialogResult.No;
			};
			dialog.Controls.Add(6);
			252.253 update = 252.12("update", 392, 346, 108, 38, true);
			update.Font = 252.1(11.5f, true);
			update.DialogResult = DialogResult.OK;
			update.Click += delegate(object 1, EventArgs 2)
			{
				dialog.DialogResult = DialogResult.OK;
			};
			dialog.Controls.Add(update);
			dialog.AcceptButton = update;
			dialog.KeyPreview = true;
			dialog.KeyDown += delegate(object 1, KeyEventArgs 2)
			{
				if (2.KeyCode == Keys.Escape)
				{
					dialog.DialogResult = DialogResult.Cancel;
				}
			};
			dialog.Shown += delegate(object 1, EventArgs 2)
			{
				if (7 == null)
				{
					252.8(dialog);
				}
				dialog.ActiveControl = update;
				notes.SelectionLength = 0;
			};
			dialog.ResumeLayout(false);
			dialog.PerformLayout();
			DialogResult dialogResult = (7 == null) ? dialog.ShowDialog() : dialog.ShowDialog(7);
			result = ((dialogResult == DialogResult.OK) ? 252.257.Update : ((dialogResult == DialogResult.No) ? 252.257.Later : 252.257.Closed));
		}
		return result;
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x0007A694 File Offset: 0x00078894
	private void 19(273.275 1)
	{
		this.28 = 1.1;
		this.31 = (1.2 || 1.3);
		this.20(false);
		this.21.Text = ((this.28 != null) ? "update now" : "check for updates");
		if (1.2)
		{
			this.21("nekiosu is off for now.", 252.11);
		}
		else if (1.3)
		{
			this.21((this.28 != null) ? ("update to " + this.28.1 + " to play.") : "this version has to update.", 252.11);
		}
		else if (this.28 != null)
		{
			this.21("version " + this.28.1 + " is out.", 252.6);
		}
		else
		{
			this.21("nekiosu is up to date.", 252.10);
		}
		this.27 = 1.5;
		this.26.Visible = (this.27 != null);
		this.23.Text = (1.4 ?? string.Empty);
		this.23.ForeColor = (this.31 ? 252.11 : 252.8);
		this.10(!string.IsNullOrEmpty(1.4));
		if (this.17 && this.28 != null && !1.2)
		{
			this.17 = false;
			base.BeginInvoke(new MethodInvoker(this.15));
		}
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x0007A820 File Offset: 0x00078A20
	private void 20(bool 1)
	{
		this.29 = 1;
		if (!1)
		{
			this.30 = false;
		}
		this.21.Enabled = !1;
		this.13();
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x0007A848 File Offset: 0x00078A48
	private void 21(string 1, Color 2)
	{
		this.22.Text = 1;
		this.22.ForeColor = 2;
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x0007A864 File Offset: 0x00078A64
	private void 22(MethodInvoker 1)
	{
		try
		{
			if (!base.IsDisposed)
			{
				base.BeginInvoke(1);
			}
		}
		catch (InvalidOperationException)
		{
		}
	}

	// Token: 0x04000FE1 RID: 4065
	private static readonly Color 1 = Color.FromArgb(21, 24, 36);

	// Token: 0x04000FE2 RID: 4066
	private static readonly Color 2 = Color.FromArgb(28, 32, 48);

	// Token: 0x04000FE3 RID: 4067
	private static readonly Color 3 = Color.FromArgb(48, 54, 76);

	// Token: 0x04000FE4 RID: 4068
	private static readonly Color 4 = Color.FromArgb(16, 18, 27);

	// Token: 0x04000FE5 RID: 4069
	private static readonly Color 5 = Color.FromArgb(38, 43, 62);

	// Token: 0x04000FE6 RID: 4070
	private static readonly Color 6 = Color.FromArgb(79, 179, 246);

	// Token: 0x04000FE7 RID: 4071
	private static readonly Color 7 = Color.FromArgb(79, 139, 246);

	// Token: 0x04000FE8 RID: 4072
	private static readonly Color 8 = Color.FromArgb(242, 244, 248);

	// Token: 0x04000FE9 RID: 4073
	private static readonly Color 9 = Color.FromArgb(170, 176, 192);

	// Token: 0x04000FEA RID: 4074
	private static readonly Color 10 = Color.FromArgb(93, 210, 122);

	// Token: 0x04000FEB RID: 4075
	private static readonly Color 11 = Color.FromArgb(255, 120, 120);

	// Token: 0x04000FEC RID: 4076
	private readonly Func<string, bool> 12;

	// Token: 0x04000FED RID: 4077
	private readonly 252.255 13;

	// Token: 0x04000FEE RID: 4078
	private readonly TextBox 14;

	// Token: 0x04000FEF RID: 4079
	private readonly 252.256 15;

	// Token: 0x04000FF0 RID: 4080
	private readonly 252.256 16;

	// Token: 0x04000FF1 RID: 4081
	private bool 17;

	// Token: 0x04000FF2 RID: 4082
	private bool 18;

	// Token: 0x04000FF3 RID: 4083
	private bool 19;

	// Token: 0x04000FF4 RID: 4084
	private readonly 252.253 20;

	// Token: 0x04000FF5 RID: 4085
	private readonly 252.253 21;

	// Token: 0x04000FF6 RID: 4086
	private readonly Label 22;

	// Token: 0x04000FF7 RID: 4087
	private readonly Label 23;

	// Token: 0x04000FF8 RID: 4088
	private readonly List<Control> 24 = new List<Control>();

	// Token: 0x04000FF9 RID: 4089
	private bool 25;

	// Token: 0x04000FFA RID: 4090
	private readonly 252.253 26;

	// Token: 0x04000FFB RID: 4091
	private string 27;

	// Token: 0x04000FFC RID: 4092
	private 273.274 28;

	// Token: 0x04000FFD RID: 4093
	private bool 29;

	// Token: 0x04000FFE RID: 4094
	private bool 30;

	// Token: 0x04000FFF RID: 4095
	private bool 31;

	// Token: 0x04001001 RID: 4097
	private static Form 32;

	// Token: 0x04001002 RID: 4098
	private static volatile bool 33;

	// Token: 0x020003D0 RID: 976
	private sealed class 254 : Panel
	{
		// Token: 0x06001F07 RID: 7943 RVA: 0x0007A979 File Offset: 0x00078B79
		public 254()
		{
			this.DoubleBuffered = true;
		}

		// Token: 0x06001F08 RID: 7944 RVA: 0x0007A9AC File Offset: 0x00078BAC
		protected override void OnPaint(PaintEventArgs 1)
		{
			252.3(1.Graphics);
			using (GraphicsPath graphicsPath = 252.2(new RectangleF(0.5f, 0.5f, (float)base.Width - 1.5f, (float)base.Height - 1.5f), this.3))
			{
				using (SolidBrush solidBrush = new SolidBrush(this.1))
				{
					using (Pen pen = new Pen(this.2))
					{
						1.Graphics.FillPath(solidBrush, graphicsPath);
						1.Graphics.DrawPath(pen, graphicsPath);
					}
				}
			}
		}

		// Token: 0x04001003 RID: 4099
		public Color 1 = 252.2;

		// Token: 0x04001004 RID: 4100
		public Color 2 = 252.3;

		// Token: 0x04001005 RID: 4101
		public float 3 = 10f;
	}

	// Token: 0x020003D1 RID: 977
	private sealed class 253 : Control, IButtonControl
	{
		// Token: 0x06001F09 RID: 7945 RVA: 0x0007AA74 File Offset: 0x00078C74
		public 253()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.Selectable | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06001F0A RID: 7946 RVA: 0x0007AA93 File Offset: 0x00078C93
		// (set) Token: 0x06001F0B RID: 7947 RVA: 0x0007AA9B File Offset: 0x00078C9B
		public DialogResult DialogResult { get; set; }

		// Token: 0x06001F0C RID: 7948 RVA: 0x00005ADD File Offset: 0x00003CDD
		public void NotifyDefault(bool 1)
		{
		}

		// Token: 0x06001F0D RID: 7949 RVA: 0x0007AAA4 File Offset: 0x00078CA4
		public void PerformClick()
		{
			if (base.Enabled)
			{
				this.OnClick(EventArgs.Empty);
			}
		}

		// Token: 0x06001F0E RID: 7950 RVA: 0x0007AAB9 File Offset: 0x00078CB9
		protected override void OnMouseEnter(EventArgs 1)
		{
			this.4 = true;
			base.Invalidate();
			base.OnMouseEnter(1);
		}

		// Token: 0x06001F0F RID: 7951 RVA: 0x0007AACF File Offset: 0x00078CCF
		protected override void OnMouseLeave(EventArgs 1)
		{
			this.4 = false;
			this.5 = false;
			base.Invalidate();
			base.OnMouseLeave(1);
		}

		// Token: 0x06001F10 RID: 7952 RVA: 0x0007AAEC File Offset: 0x00078CEC
		protected override void OnMouseDown(MouseEventArgs 1)
		{
			this.5 = true;
			base.Invalidate();
			base.OnMouseDown(1);
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x0007AB02 File Offset: 0x00078D02
		protected override void OnMouseUp(MouseEventArgs 1)
		{
			this.5 = false;
			base.Invalidate();
			base.OnMouseUp(1);
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x0007AB18 File Offset: 0x00078D18
		protected override void OnEnabledChanged(EventArgs 1)
		{
			base.Invalidate();
			base.OnEnabledChanged(1);
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x0007AB27 File Offset: 0x00078D27
		protected override void OnKeyDown(KeyEventArgs 1)
		{
			if (1.KeyCode == Keys.Space || 1.KeyCode == Keys.Return)
			{
				this.PerformClick();
			}
			base.OnKeyDown(1);
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x0007AB4C File Offset: 0x00078D4C
		protected override void OnPaint(PaintEventArgs 1)
		{
			252.3(1.Graphics);
			1.Graphics.Clear(this.BackColor);
			Color color = this.1 ? 252.6 : 252.5;
			if (!base.Enabled)
			{
				color = (this.1 ? Color.FromArgb(52, 78, 104) : Color.FromArgb(30, 34, 50));
			}
			else if (this.5)
			{
				color = ControlPaint.Dark(color, 0.08f);
			}
			else if (this.4)
			{
				color = ControlPaint.Light(color, this.1 ? 0.25f : 0.2f);
			}
			using (GraphicsPath graphicsPath = 252.2(new RectangleF(0.5f, 0.5f, (float)base.Width - 1.5f, (float)base.Height - 1.5f), 6f))
			{
				using (SolidBrush solidBrush = new SolidBrush(color))
				{
					1.Graphics.FillPath(solidBrush, graphicsPath);
					if (!this.1)
					{
						using (Pen pen = new Pen(252.3))
						{
							1.Graphics.DrawPath(pen, graphicsPath);
						}
					}
				}
			}
			if (this.2 != null)
			{
				RectangleF bounds = this.2.GetBounds();
				float num = (float)Math.Min(base.Width, base.Height) * 0.5f / Math.Max(bounds.Width, bounds.Height);
				using (GraphicsPath graphicsPath2 = (GraphicsPath)this.2.Clone())
				{
					using (Matrix matrix = new Matrix())
					{
						using (SolidBrush solidBrush2 = new SolidBrush(this.3))
						{
							matrix.Translate((float)base.Width / 2f, (float)base.Height / 2f);
							matrix.Scale(num, num);
							matrix.Translate(-(bounds.X + bounds.Width / 2f), -(bounds.Y + bounds.Height / 2f));
							graphicsPath2.Transform(matrix);
							1.Graphics.FillPath(solidBrush2, graphicsPath2);
						}
					}
				}
				return;
			}
			Color foreColor = (!base.Enabled) ? Color.FromArgb(110, 118, 138) : (this.1 ? Color.White : 252.8);
			TextRenderer.DrawText(1.Graphics, this.Text, this.Font, base.ClientRectangle, foreColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x04001006 RID: 4102
		public bool 1;

		// Token: 0x04001007 RID: 4103
		public GraphicsPath 2;

		// Token: 0x04001008 RID: 4104
		public Color 3;

		// Token: 0x04001009 RID: 4105
		private bool 4;

		// Token: 0x0400100A RID: 4106
		private bool 5;
	}

	// Token: 0x020003D2 RID: 978
	private sealed class 256 : Control
	{
		// Token: 0x06001F15 RID: 7957 RVA: 0x0007AE20 File Offset: 0x00079020
		public 256()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Selectable | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x0007AE3F File Offset: 0x0007903F
		protected override void OnClick(EventArgs 1)
		{
			this.1 = !this.1;
			base.Invalidate();
			base.OnClick(1);
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0007AE5D File Offset: 0x0007905D
		protected override void OnKeyDown(KeyEventArgs 1)
		{
			if (1.KeyCode == Keys.Space)
			{
				this.OnClick(EventArgs.Empty);
			}
			base.OnKeyDown(1);
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x0007AE7C File Offset: 0x0007907C
		protected override void OnPaint(PaintEventArgs 1)
		{
			252.3(1.Graphics);
			1.Graphics.Clear(this.BackColor);
			float num = Math.Min((float)(base.Height - 4), 18f * 1.Graphics.DpiY / 96f);
			RectangleF 2 = new RectangleF(1f, ((float)base.Height - num) / 2f, num, num);
			using (GraphicsPath graphicsPath = 252.2(2, num * 0.22f))
			{
				if (this.1)
				{
					using (SolidBrush solidBrush = new SolidBrush(252.7))
					{
						1.Graphics.FillPath(solidBrush, graphicsPath);
					}
					252.5(1.Graphics, 2, Color.White, num * 0.12f);
				}
				else
				{
					using (Pen pen = new Pen(252.9, 1.5f))
					{
						1.Graphics.DrawPath(pen, graphicsPath);
					}
				}
			}
			Rectangle bounds = new Rectangle((int)(2.Right + num * 0.55f), 0, base.Width - (int)(2.Right + num * 0.55f), base.Height);
			TextRenderer.DrawText(1.Graphics, this.Text, this.Font, bounds, this.ForeColor, TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x0400100C RID: 4108
		public bool 1;
	}

	// Token: 0x020003D3 RID: 979
	private sealed class 255 : Control
	{
		// Token: 0x06001F19 RID: 7961 RVA: 0x0007AFF8 File Offset: 0x000791F8
		public 255()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0007B00C File Offset: 0x0007920C
		protected override void OnPaint(PaintEventArgs 1)
		{
			252.3(1.Graphics);
			1.Graphics.Clear(this.BackColor);
			int num = 0;
			if (this.2)
			{
				float num2 = Math.Min((float)(base.Height - 2), 18f * 1.Graphics.DpiY / 96f);
				RectangleF rect = new RectangleF(0.5f, ((float)base.Height - num2) / 2f, num2, num2);
				using (SolidBrush solidBrush = new SolidBrush(this.ForeColor))
				{
					1.Graphics.FillEllipse(solidBrush, rect);
				}
				if (this.1)
				{
					252.5(1.Graphics, rect, Color.FromArgb(20, 40, 26), num2 * 0.11f);
				}
				else
				{
					using (Pen pen = new Pen(Color.FromArgb(60, 20, 20), num2 * 0.11f)
					{
						StartCap = LineCap.Round,
						EndCap = LineCap.Round
					})
					{
						float num3 = num2 * 0.32f;
						1.Graphics.DrawLine(pen, rect.X + num3, rect.Y + num3, rect.Right - num3, rect.Bottom - num3);
						1.Graphics.DrawLine(pen, rect.Right - num3, rect.Y + num3, rect.X + num3, rect.Bottom - num3);
					}
				}
				num = (int)(num2 * 1.55f);
			}
			TextRenderer.DrawText(1.Graphics, this.Text, this.Font, new Rectangle(num, 0, base.Width - num, base.Height), this.ForeColor, TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter);
		}

		// Token: 0x0400100D RID: 4109
		public bool 1;

		// Token: 0x0400100E RID: 4110
		public bool 2;
	}

	// Token: 0x020003D4 RID: 980
	internal enum 257
	{
		// Token: 0x04001010 RID: 4112
		Update,
		// Token: 0x04001011 RID: 4113
		Later,
		// Token: 0x04001012 RID: 4114
		Closed
	}
}
