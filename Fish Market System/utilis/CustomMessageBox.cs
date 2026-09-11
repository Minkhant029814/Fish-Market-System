using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fish_Market_System.utilis
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }


        
        public enum MessageType { Success, Warning, Error, Question }

        public static DialogResult Show(string message,
                                         string title = "အသိပေးချက်",
                                         MessageType type = MessageType.Success)
        {
            using (var frm = new CustomMessageBox(message, title, type))
            {
                return frm.ShowDialog();
            }
        }

        private CustomMessageBox(string message, string title, MessageType type)
        {
            // Form Setup
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(420, 220);
            this.BackColor = Color.White;
            this.Padding = new Padding(1);

            // Border
            Panel border = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(230, 230, 230),
                Padding = new Padding(2)
            };
            this.Controls.Add(border);

            // Icon + Color
            Color accent;
            string icon;
            switch (type)
            {
                case MessageType.Success:
                    accent = Color.FromArgb(46, 204, 113);
                    icon = "✅";
                    break;
                case MessageType.Warning:
                    accent = Color.FromArgb(241, 196, 15);
                    icon = "⚠️";
                    break;
                case MessageType.Error:
                    accent = Color.FromArgb(231, 76, 60);
                    icon = "❌";
                    break;
                default:
                    accent = Color.FromArgb(52, 152, 219);
                    icon = "❓";
                    break;
            }

            // Title bar
            Panel titleBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 45,
                BackColor = accent
            };
            titleBar.Controls.Add(new Label
            {
                Text = $"{icon}  {title}",
                Font = new Font("Pyidaungsu", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            });

            // Close button
            Guna2Button btnClose = new Guna2Button
            {
                Text = "✕",
                Size = new Size(45, 45),
                Dock = DockStyle.Right,
                FillColor = accent,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                BorderRadius = 0,
                Cursor = Cursors.Hand,
                HoverState = { FillColor = Color.FromArgb(200, 50, 50) }
            };
            btnClose.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            titleBar.Controls.Add(btnClose);

            // Message Label
            Label lblMessage = new Label
            {
                Text = message,
                Font = new Font("Pyidaungsu", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(40, 40, 40),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(20)
            };

            // OK Button
            Guna2Button btnOk = new Guna2Button
            {
                Text = "OK",
                Size = new Size(110, 40),
                FillColor = accent,
                ForeColor = Color.White,
                Font = new Font("Pyidaungsu", 11, FontStyle.Bold),
                BorderRadius = 10,
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.None,
                HoverState = { FillColor = ControlPaint.Light(accent) }
            };
            btnOk.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };

            Panel btnPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 65,
                BackColor = Color.White
            };
            btnPanel.Controls.Add(btnOk);
            btnOk.Location = new Point((btnPanel.Width - btnOk.Width) / 2, 10);
            btnPanel.Resize += (s, e) =>
                btnOk.Location = new Point((btnPanel.Width - btnOk.Width) / 2, 10);

            border.Controls.Add(lblMessage);
            border.Controls.Add(btnPanel);
            border.Controls.Add(titleBar);

            // Drag to move
            titleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    NativeMethods.ReleaseCapture();
                    NativeMethods.SendMessage(Handle, 0xA1, 0x2, 0);
                }
            };
        }

        private static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool ReleaseCapture();
            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        }
    }
}

