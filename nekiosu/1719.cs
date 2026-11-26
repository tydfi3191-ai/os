using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200095E RID: 2398
public sealed partial class 1719 : 1488
{
	// Token: 0x060043AE RID: 17326 RVA: 0x001A9DAC File Offset: 0x001A7FAC
	public 1719(1327 1)
	{
		this.28();
		switch (3)
		{
		case (1327)0:
			this.6.DoWork += this.23;
			break;
		case (1327)1:
			this.6.DoWork += this.24;
			break;
		case (1327)2:
			if (!1345.5)
			{
				base.TopMost = false;
			}
			base.ShowInTaskbar = true;
			this.Text = "osu! updater";
			this.6.DoWork += delegate(object 1, DoWorkEventArgs 2)
			{
				this.18();
				try
				{
					2667 4 = 2667.Stable40;
					bool flag = File.Exists("OpenTK.dll");
					List<string> list = new List<string>(Directory.GetFiles(Environment.CurrentDirectory));
					bool flag2 = (File.Exists("osu!.cfg") || list.Count == 1) && !Environment.CurrentDirectory.ToUpper().Contains("TEMP");
					if (flag2 && 1345.3() != "osu!.exe")
					{
						byte[] array = File.ReadAllBytes(1345.1());
						using (FileStream fileStream = File.Create("osu!.exe"))
						{
							fileStream.Write(array, 0, array.Length);
						}
						2672.20(1345.1());
						try
						{
							this.21();
						}
						catch
						{
							261.Start("osu!.exe");
						}
						1345.16();
					}
					if (!flag)
					{
						string text;
						for (;;)
						{
							IL_C7:
							if (!flag2)
							{
								this.14 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "osu!");
								this.21.Click += this.22;
								int i = 10;
								while (i > 0)
								{
									this.25(string.Format(1568.1(2679.Maintenance_InstallationPath) + "\n" + 1568.1(2679.Maintenance_InstallationPath2), this.14, i), true);
									Thread.Sleep(1000);
									i--;
									while (this.14 == null)
									{
										Thread.Sleep(100);
									}
								}
								this.21.Click -= this.22;
							}
							while (this.14 != Environment.CurrentDirectory)
							{
								text = Path.Combine(this.14, "osu!.exe");
								try
								{
									if (!Directory.Exists(this.14))
									{
										Directory.CreateDirectory(this.14);
									}
									try
									{
										File.Delete(text);
									}
									catch (IOException)
									{
									}
									byte[] array2 = File.ReadAllBytes(1345.1());
									using (FileStream fileStream2 = File.Create(text))
									{
										fileStream2.Write(array2, 0, array2.Length);
									}
								}
								catch (UnauthorizedAccessException)
								{
									if (!1345.18())
									{
										if (!1345.17("-allowuserwrites " + this.14, true))
										{
											goto IL_C7;
										}
										continue;
									}
								}
								goto IL_20E;
							}
							goto IL_25D;
						}
						IL_20E:
						try
						{
							using (File.Create(Path.Combine(this.14, ".require_update")))
							{
							}
						}
						catch
						{
						}
						261.Start(text);
						1345.16();
					}
					IL_25D:
					try
					{
						if (flag)
						{
							4 = 1304.198.GetValue();
						}
					}
					catch (Exception 5)
					{
						1345.15(true, 5);
					}
					this.25(string.Empty, false);
					for (;;)
					{
						this.16(0f, 2679.Maintenance_Hi);
						if (flag)
						{
							1304.7();
						}
						1336.5(new 2666(1719.1721.instance.1), 4, ThreadPriority.Normal);
						for (;;)
						{
							switch (1336.10)
							{
							case 2665.NoUpdate:
								goto IL_347;
							case 2665.Checking:
								this.25(1336.3(false), this.17);
								this.16(0f, 2679.Maintenance_Hi);
								Thread.Sleep(20);
								continue;
							case 2665.Updating:
								this.25(1336.3(false), false);
								this.16(1336.2(), 2679.Maintenance_Hi);
								Thread.Sleep(20);
								continue;
							case 2665.Error:
								goto IL_364;
							case 2665.NeedsRestart:
							case 2665.Completed:
								goto IL_331;
							}
							goto Block_14;
						}
						IL_364:
						1336.10(true);
						try
						{
							new 1625<List<1650>>(string.Format(1336.2 + "?action=error&stream={0}&time={1}", 1336.9.ToString().ToLower(), DateTime.Now.Ticks), Array.Empty<object>()).Start();
						}
						catch
						{
						}
						if (1650.useBackgroundThread)
						{
							1650.useBackgroundThread = false;
							1336.1("Disabling threaded downloads", new object[0]);
						}
						this.16(0f, 2679.Maintenance_Hi);
						this.25(1568.1(2679.Maintenance_ErrorOccurred), true);
						Thread.Sleep(this.15);
						this.15 = (int)Math.Min(300000.0, (double)this.15 * (1.0 + 1196.3()));
					}
					Block_14:
					goto IL_3D9;
					IL_331:
					this.25(1568.1(2679.CommonUpdater_Updated), false);
					goto IL_3D9;
					IL_347:
					this.25(1568.1(2679.CommonUpdater_Updated), true);
					Thread.Sleep(1000);
					IL_3D9:
					if (!1181.1() && !flag)
					{
						1167.1(1719.13(), Path.Combine(Environment.CurrentDirectory, "osu!.exe"), "osu!", string.Empty);
						1167.1(1719.14(), Path.Combine(Environment.CurrentDirectory, "osu!.exe"), "osu!", string.Empty);
					}
					this.7.Dispose();
					base.DialogResult = DialogResult.OK;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error occured (please report this!):\\n\\n" + ex.ToString());
				}
			};
			break;
		case (1327)3:
			if (!1345.5)
			{
				base.TopMost = false;
			}
			base.ShowInTaskbar = true;
			this.Text = "osu! uninstaller";
			this.6.DoWork += this.20;
			break;
		}
		this.6.WorkerReportsProgress = true;
		this.6.ProgressChanged += this.17;
		this.6.RunWorkerCompleted += delegate(object 1, RunWorkerCompletedEventArgs 2)
		{
			base.Close();
		};
		this.6.RunWorkerAsync();
		this.9.Tick += this.15;
		this.9.Interval = 20;
		this.9.Start();
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x001A9F5C File Offset: 0x001A815C
	private static string 13()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "osu!.lnk");
	}

	// Token: 0x060043B0 RID: 17328 RVA: 0x001A9F6F File Offset: 0x001A816F
	private static string 14()
	{
		return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu), "Programs", "osu!.lnk");
	}

	// Token: 0x060043B1 RID: 17329 RVA: 0x001A9F87 File Offset: 0x001A8187
	private void 15(object 1, EventArgs 2)
	{
		this.8 += 0.01f;
	}

	// Token: 0x060043B2 RID: 17330 RVA: 0x001A9F9C File Offset: 0x001A819C
	protected override void OnPaint(PaintEventArgs 1)
	{
		Image image = this.10;
		Graphics graphics = 1.Graphics;
		float num = 1.Graphics.DpiX / 96f;
		int width = (int)Math.Ceiling((double)(380f * num));
		int height = (int)Math.Ceiling((double)(350f * num));
		graphics.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, 380, 350, GraphicsUnit.Pixel);
		base.OnPaint(1);
	}

	// Token: 0x060043B3 RID: 17331 RVA: 0x001AA009 File Offset: 0x001A8209
	protected override void OnClosing(CancelEventArgs 1)
	{
		if (this.9 != null)
		{
			this.9.Dispose();
		}
		base.OnClosing(1);
	}

	// Token: 0x060043B4 RID: 17332 RVA: 0x001AA028 File Offset: 0x001A8228
	private void 16(float 1, 2679 2)
	{
		1719.1723 CS_0024_003C_003E8__locals11 = new 1719.1723();
		CS_0024_003C_003E8__locals11.1 = 1;
		CS_0024_003C_003E8__locals11.2 = this;
		CS_0024_003C_003E8__locals11.3 = 2;
		base.5(delegate
		{
			if (CS_0024_003C_003E8__locals11.1 <= 0f)
			{
				CS_0024_003C_003E8__locals11.2.20.7(0);
				CS_0024_003C_003E8__locals11.2.22.Text = 1568.1(CS_0024_003C_003E8__locals11.3);
				return;
			}
			CS_0024_003C_003E8__locals11.2.20.7((int)CS_0024_003C_003E8__locals11.1);
			CS_0024_003C_003E8__locals11.2.22.Text = ((int)CS_0024_003C_003E8__locals11.1).ToString() + "%";
		});
	}

	// Token: 0x060043B5 RID: 17333 RVA: 0x001AA07C File Offset: 0x001A827C
	private void 17(object 1, ProgressChangedEventArgs 2)
	{
		this.20.7(2.ProgressPercentage);
	}

	// Token: 0x060043B6 RID: 17334 RVA: 0x001AA090 File Offset: 0x001A8290
	private void 18()
	{
		try
		{
			1719.1722 <<EMPTY_NAME>> = new 1719.1722();
			1726.14();
			base.3();
			<<EMPTY_NAME>>.1 = 1568.2;
			if (!<<EMPTY_NAME>>.1)
			{
				base.5(new MethodInvoker(<<EMPTY_NAME>>.1));
				int num = 20000;
				while (!<<EMPTY_NAME>>.1 && (num -= 100) > 0)
				{
					this.25("Downloading localisation...", true);
					Thread.Sleep(100);
				}
			}
			for (;;)
			{
				try
				{
					this.7 = new 1126(1345.2, 500);
				}
				catch (1155)
				{
					if (!1181.1())
					{
						this.25(1568.1(2679.Maintenance_OsuIsAlreadyRunning), true);
						Thread.Sleep(100);
						continue;
					}
				}
				break;
			}
			if (!1120.2(1121.dotnet4, true))
			{
				string text = (Environment.OSVersion.Version.Major < 6) ? "dotNetFx40_Full_setup.exe" : "NDP452-KB2901954-Web.exe";
				this.25(1568.1(2679.Maintenance_DotNetInstall), true);
				1620 2 = new 1620(text, "http://m1.offline.invalid/r/" + text);
				2.8(new 1621.1623(this.29));
				try
				{
					2.RunSynchronously();
					Process process = 261.Start(text, "/passive /promptrestart");
					while (process != null && !process.HasExited)
					{
						this.25(1568.1(2679.Maintenance_WaitingForDotNetComplete), true);
						this.16(0f, 2679.Maintenance_Hi);
						Thread.Sleep(500);
					}
				}
				catch
				{
				}
				2672.20(text);
				this.21.Click += this.19;
				while (!1120.2(1121.dotnet4, false))
				{
					this.25(1568.1(2679.Maintenance_DotNetFailed), true);
					this.16(0f, 2679.Maintenance_Hi);
					Thread.Sleep(500);
				}
				this.21.Click -= this.19;
			}
			this.25(null, false);
			this.16(0f, 2679.Maintenance_Hi);
		}
		catch
		{
		}
	}

	// Token: 0x060043B7 RID: 17335 RVA: 0x001AA2C4 File Offset: 0x001A84C4
	private void 19(object 1, EventArgs 2)
	{
		261.Start("https://www.microsoft.com/download/details.aspx?id=42643");
	}

	// Token: 0x060043B8 RID: 17336 RVA: 0x001AA2D4 File Offset: 0x001A84D4
	private void 20(object 1, DoWorkEventArgs 2)
	{
		if (!1345.18())
		{
			1345.17("-uninstall", false);
			return;
		}
		try
		{
			1719.1724 CS_0024_003C_003E8__locals2 = new 1719.1724();
			this.18();
			this.16(0f, 2679.Maintenance_Bye);
			int i = 10;
			while (i > 0)
			{
				this.25(string.Format(1568.1(2679.Maintenance_Uninstall) + "\n" + 1568.1(2679.Maintenance_Uninstall2), i), true);
				Thread.Sleep(1000);
				i--;
				while (this.14 == null)
				{
					Thread.Sleep(100);
				}
			}
			this.25(1568.1(2679.Maintenance_Uninstalling), true);
			IEnumerable<string> directories = Directory.GetDirectories(Environment.CurrentDirectory);
			Func<string, string> selector;
			if ((selector = 1719.<>O.<0>__GetFileName) == null)
			{
				selector = (1719.<>O.<0>__GetFileName = new Func<string, string>(Path.GetFileName));
			}
			string[] array = directories.Select(selector).ToArray<string>();
			string[] second = new string[]
			{
				"_staging",
				"_cleanup",
				"_pending",
				"Data",
				"Downloads",
				"Exports",
				"Logs",
				"Screenshots",
				"Skins",
				"Songs"
			};
			string[] array2 = array.Except(second).ToArray<string>();
			string[] files = Directory.GetFiles(Environment.CurrentDirectory);
			CS_0024_003C_003E8__locals2.1 = new string[]
			{
				".db",
				".cfg",
				".exe",
				".dll",
				".lnk",
				".version"
			};
			IEnumerable<string> source = from 1 in files
			where !CS_0024_003C_003E8__locals2.1.Contains(Path.GetExtension(1))
			select 1;
			Func<string, string> selector2;
			if ((selector2 = 1719.<>O.<0>__GetFileName) == null)
			{
				selector2 = (1719.<>O.<0>__GetFileName = new Func<string, string>(Path.GetFileName));
			}
			string[] array3 = source.Select(selector2).ToArray<string>();
			string text = string.Empty;
			if (array2.Length != 0)
			{
				text = text + "\n\nDirectories:\n" + 1719.30(string.Join(", ", array2), 200);
			}
			if (array3.Length != 0)
			{
				text = text + "\n\nFiles:\n" + 1719.30(string.Join(", ", array3), 200);
			}
			if (!string.IsNullOrEmpty(text) && 1705.2("SUPER IMPORTANT: Files or directories were found which may not be related to osu!. If you use the built-in uninstaller these will be deleted:" + text + "\n\nIf unsure, please cancel and manually delete osu! files.", "An important confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				261.Start(Environment.CurrentDirectory);
				1345.16();
			}
			else
			{
				int num = array.Length + 8;
				int num2 = 0;
				string[] array4 = array;
				foreach (string path in array4)
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					try
					{
						Directory.Delete(path, true);
					}
					catch
					{
					}
					Thread.Sleep(100);
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					Directory.Delete(Environment.CurrentDirectory, true);
				}
				catch
				{
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					array4 = Directory.GetFiles(Environment.CurrentDirectory);
					for (int k = 0; k < array4.Length; k++)
					{
						2672.19(array4[k]);
					}
				}
				catch
				{
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					Directory.Delete(Environment.CurrentDirectory);
				}
				catch
				{
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					2672.19(Environment.CurrentDirectory);
				}
				catch
				{
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					1127.1();
				}
				catch
				{
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					File.Delete(1719.13());
					File.Delete(1719.14());
				}
				catch
				{
				}
				try
				{
					this.16((float)((int)((float)(++num2) / (float)num * 100f)), 2679.Maintenance_Hi);
					2672.7("osu!");
					2672.6("osu");
					1830.4();
				}
				catch
				{
				}
				this.16(100f, 2679.Maintenance_Hi);
				this.25(1568.1(2679.Maintenance_Farewell), true);
				Thread.Sleep(5000);
			}
		}
		catch
		{
		}
	}

	// Token: 0x060043B9 RID: 17337 RVA: 0x0008A6A8 File Offset: 0x000888A8
	private void 21()
	{
		if (!string.IsNullOrEmpty(1345.11))
		{
			261.Start("osu!.exe", "-devserver " + 1345.11);
			return;
		}
		261.Start("osu!.exe");
	}

	// Token: 0x060043BA RID: 17338 RVA: 0x001AA828 File Offset: 0x001A8A28
	private void 22(object 1, EventArgs 2)
	{
		1719.1720 3 = new 1719.1720();
		3.1 = this;
		3.2 = this.14;
		this.14 = null;
		base.5(new MethodInvoker(3.1));
	}

	// Token: 0x060043BB RID: 17339 RVA: 0x001AA868 File Offset: 0x001A8A68
	private void 23(object 1, DoWorkEventArgs 2)
	{
		if (Directory.Exists("Avatars"))
		{
			string[] files = Directory.GetFiles("Avatars");
			for (int i = 0; i < files.Length; i++)
			{
				File.Delete(files[i]);
				this.6.ReportProgress((int)((float)i / (float)files.Length * 100f));
			}
			Directory.Delete("Avatars", true);
		}
		base.DialogResult = DialogResult.OK;
	}

	// Token: 0x060043BC RID: 17340 RVA: 0x001AA8D0 File Offset: 0x001A8AD0
	private void 24(object 1, DoWorkEventArgs 2)
	{
		2230.4.Clear();
		if (Directory.Exists(2230.2()))
		{
			string[] files = Directory.GetFiles(2230.2());
			for (int i = 0; i < files.Length; i++)
			{
				2230.19(files[i], false);
				this.6.ReportProgress((int)((float)i / (float)files.Length * 100f));
			}
			base.DialogResult = DialogResult.OK;
		}
	}

	// Token: 0x060043BD RID: 17341 RVA: 0x001AA938 File Offset: 0x001A8B38
	private void 25(string 1, bool 2)
	{
		if (1 != null)
		{
			this.17 = 2;
			this.16 = 1;
		}
		if (this.18 || this.17)
		{
			base.5(new MethodInvoker(this.31));
			return;
		}
		base.5(new MethodInvoker(this.32));
	}

	// Token: 0x060043BE RID: 17342 RVA: 0x001AA98B File Offset: 0x001A8B8B
	private void 26(object 1, EventArgs 2)
	{
		this.18 = true;
		this.25(null, false);
	}

	// Token: 0x060043BF RID: 17343 RVA: 0x001AA99C File Offset: 0x001A8B9C
	private void 27(object 1, EventArgs 2)
	{
		this.18 = false;
		this.25(null, false);
	}

	// Token: 0x060043C1 RID: 17345 RVA: 0x001AA9CC File Offset: 0x001A8BCC
	private void 28()
	{
		this.21 = new Label();
		this.20 = new 1458();
		this.22 = new Label();
		this.23 = new PictureBox();
		this.24 = new 1481();
		((ISupportInitialize)this.23).BeginInit();
		base.SuspendLayout();
		this.21.BackColor = Color.Transparent;
		this.21.Dock = DockStyle.Bottom;
		this.21.Font = new Font("Segoe UI", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.21.ForeColor = Color.FromArgb(85, 85, 85);
		this.21.Location = new Point(0, 295);
		this.21.Name = "label";
		this.21.Size = new Size(380, 55);
		this.21.TabIndex = 1;
		this.21.Text = "osu! is performing some maintenance";
		this.21.TextAlign = ContentAlignment.TopCenter;
		this.21.MouseEnter += this.26;
		this.21.MouseLeave += this.27;
		this.20.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.20.BackColor = Color.FromArgb(85, 85, 85);
		this.20.ForeColor = Color.FromArgb(255, 102, 170);
		this.20.Location = new Point(20, 220);
		this.20.Margin = new Padding(0);
		this.20.5(100);
		this.20.4(0);
		this.20.Name = "progressBar1";
		this.20.8(Color.FromArgb(255, 102, 170));
		this.20.Size = new Size(340, 5);
		this.20.TabIndex = 0;
		this.20.7(0);
		this.22.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.22.BackColor = Color.Transparent;
		this.22.Font = new Font("Segoe UI", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
		this.22.ForeColor = Color.FromArgb(85, 85, 85);
		this.22.Location = new Point(117, 260);
		this.22.Name = "label1";
		this.22.Size = new Size(146, 35);
		this.22.TabIndex = 2;
		this.22.Text = "Hi!";
		this.22.TextAlign = ContentAlignment.MiddleCenter;
		this.23.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.23.BackColor = Color.Transparent;
		this.23.Image = 277.GetUpdaterLogoImage();
		this.23.Location = new Point(117, 37);
		this.23.Name = "pictureBox1";
		this.23.Size = new Size(146, 146);
		this.23.SizeMode = PictureBoxSizeMode.Zoom;
		this.23.TabIndex = 3;
		this.23.TabStop = false;
		this.24.ActiveLinkColor = Color.FromArgb(246, 99, 165);
		this.24.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.24.AutoSize = true;
		this.24.BackColor = Color.Transparent;
		this.24.LinkColor = Color.FromArgb(56, 56, 56);
		this.24.Location = new Point(342, 3);
		this.24.Name = "linkLabel1";
		this.24.Size = new Size(35, 15);
		this.24.TabIndex = 5;
		this.24.TabStop = true;
		this.24.Text = "help?";
		this.24.TextAlign = ContentAlignment.TopRight;
		this.24.VisitedLinkColor = Color.FromArgb(56, 56, 56);
		this.24.LinkClicked += delegate(object 1, LinkLabelLinkClickedEventArgs 2)
		{
			261.Start("https://osu.offline.invalid/p/download?help=1");
		};
		base.AutoScaleDimensions = new SizeF(96f, 96f);
		base.AutoScaleMode = AutoScaleMode.Dpi;
		this.BackColor = Color.FromArgb(241, 239, 241);
		base.ClientSize = new Size(380, 350);
		base.Controls.Add(this.24);
		base.Controls.Add(this.23);
		base.Controls.Add(this.22);
		base.Controls.Add(this.21);
		base.Controls.Add(this.20);
		this.DoubleBuffered = true;
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "Maintenance";
		base.ShowIcon = false;
		base.ShowInTaskbar = false;
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "Maintenance";
		base.TopMost = true;
		((ISupportInitialize)this.23).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x060043C2 RID: 17346 RVA: 0x001AAF32 File Offset: 0x001A9132
	private void 29(1621 1, long 2, long 3)
	{
		this.16((float)2 / (float)3 * 100f, 2679.Maintenance_DotNetInstall);
	}

	// Token: 0x060043C3 RID: 17347 RVA: 0x001AAF4A File Offset: 0x001A914A
	internal static string 30(string 1, int 2)
	{
		if (1.Length > 2)
		{
			return 1.Substring(0, 2) + " (and more not listed here)";
		}
		return 1;
	}

	// Token: 0x060043C4 RID: 17348 RVA: 0x001AAF69 File Offset: 0x001A9169
	private void 31()
	{
		this.21.Text = this.16;
	}

	// Token: 0x060043C5 RID: 17349 RVA: 0x001AAF7C File Offset: 0x001A917C
	private void 32()
	{
		this.21.Text = 1568.1(2679.CommonUpdater_UpdatingGeneral);
	}

	// Token: 0x0400319F RID: 12703
	private BackgroundWorker 6 = new BackgroundWorker();

	// Token: 0x040031A0 RID: 12704
	private new 1126 7;

	// Token: 0x040031A1 RID: 12705
	private new float 8;

	// Token: 0x040031A2 RID: 12706
	private System.Windows.Forms.Timer 9 = new System.Windows.Forms.Timer();

	// Token: 0x040031A3 RID: 12707
	private Image 10 = 277.GetUpdaterGrid1Image();

	// Token: 0x040031A4 RID: 12708
	private new Image 11 = 277.GetUpdaterGrid2Image();

	// Token: 0x040031A5 RID: 12709
	private new Image 12 = 277.GetUpdaterGrid3Image();

	// Token: 0x040031A6 RID: 12710
	private Image 13 = 277.GetUpdaterGrid4Image();

	// Token: 0x040031A7 RID: 12711
	private string 14 = Environment.CurrentDirectory;

	// Token: 0x040031A8 RID: 12712
	private int 15 = 5000;

	// Token: 0x040031A9 RID: 12713
	private string 16 = string.Empty;

	// Token: 0x040031AA RID: 12714
	private bool 17;

	// Token: 0x040031AB RID: 12715
	private bool 18;

	// Token: 0x040031AD RID: 12717
	private 1458 20;

	// Token: 0x040031AE RID: 12718
	private Label 21;

	// Token: 0x040031AF RID: 12719
	private Label 22;

	// Token: 0x040031B0 RID: 12720
	private PictureBox 23;

	// Token: 0x040031B1 RID: 12721
	private 1481 24;

	// Token: 0x0200095F RID: 2399
	public sealed class 1720
	{
		// Token: 0x060043C8 RID: 17352 RVA: 0x001AB54C File Offset: 0x001A974C
		internal void 1()
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = 1568.1(2679.Maintenance_ChooseInstallFolder);
			folderBrowserDialog.ShowNewFolderButton = true;
			folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
			if (folderBrowserDialog.ShowDialog(this.1) != DialogResult.OK)
			{
				this.1.14 = this.2;
				return;
			}
			this.1.14 = folderBrowserDialog.SelectedPath;
			if (!Directory.Exists(this.1.14))
			{
				this.1.14 = this.2;
				return;
			}
			if (!File.Exists(Path.Combine(this.1.14, "osu!.exe")) && !File.Exists(Path.Combine(this.1.14, "osu!ui.dll")) && !File.Exists(Path.Combine(this.1.14, "osu!.cfg")) && Directory.GetDirectories(this.1.14).Length + Directory.GetFiles(this.1.14).Length > 0)
			{
				this.1.14 = Path.Combine(this.1.14, "osu!");
			}
		}

		// Token: 0x040031B2 RID: 12722
		public 1719 1;

		// Token: 0x040031B3 RID: 12723
		public string 2;
	}

	// Token: 0x02000960 RID: 2400
	[Serializable]
	public sealed class 1721
	{
		// Token: 0x060043CA RID: 17354 RVA: 0x00005ADD File Offset: 0x00003CDD
		internal void 1(2665 1)
		{
		}

		// Token: 0x040031B4 RID: 12724
		public static readonly 1719.1721 instance = new 1719.1721();

		// Token: 0x040031B5 RID: 12725
		public static 2666 _recoveredType10655579;
	}

	// Token: 0x02000961 RID: 2401
	public sealed class 1722
	{
		// Token: 0x060043CD RID: 17357 RVA: 0x001AB682 File Offset: 0x001A9882
		internal void 1()
		{
			1568.2(null, false, new 1189(this.2), 277.GetEnglishLocalisation());
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x001AB69D File Offset: 0x001A989D
		internal void 2()
		{
			this.1 = true;
		}

		// Token: 0x040031B6 RID: 12726
		public bool 1;
	}

	// Token: 0x02000962 RID: 2402
	public sealed class 1724
	{
		// Token: 0x040031B7 RID: 12727
		public string[] 1;
	}

	// Token: 0x02000963 RID: 2403
	public sealed class 1723
	{
		// Token: 0x040031B8 RID: 12728
		public float 1;

		// Token: 0x040031B9 RID: 12729
		public 1719 2;

		// Token: 0x040031BA RID: 12730
		public 2679 3;
	}

	// Token: 0x02000964 RID: 2404
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040031BB RID: 12731
		public static Func<string, string> <0>__GetFileName;
	}
}
