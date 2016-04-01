using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Teacher.CustomComponents.Button
{
    public partial class BaseButton: UserControl
    {
        // 定数
        public const int Radius = 24; // 角丸サイズ
        public const int ColorDivCnt = 16;

        // フィールド
        public Color Color;
        public int ColorRatio;

        protected Task TaskAnimetionColorUp;
        protected Task TaskAnimetionColorDown;

        // プロパティ
        public string ButtonText { get; set; }
        public Point TextLocation { get; set; }
        public Color MainColor { get; set; }
        public Color HoverColor { get; set; }

        // コンストラクタ
        public BaseButton()
        {
            // プロパティデフォルト
            TextLocation = new Point(10, 10);
            Text = "";
            MainColor = Color.FromArgb(255, 192, 192);
            HoverColor = Color.FromArgb(255, 64, 64);

            // 初期化
            Color = MainColor;
            ColorRatio = 0;

            // ダブルバッファリング有効
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            InitializeComponent();
        }

        // 描画
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush b = new SolidBrush(Color);

            g.FillRectangle(b, Radius / 2, 0, this.Width - Radius, this.Height);
            g.FillRectangle(b, 0, Radius / 2, this.Width, this.Height - Radius);

            g.FillPie(b, 0, 0, Radius, Radius, 0, -180);
            g.FillPie(b, this.Width - Radius, 0, Radius, Radius, 0, -180);

            g.FillPie(b, 0, this.Height - Radius, Radius, Radius, 0, 180);
            g.FillPie(b, this.Width - Radius, this.Height - Radius, Radius, Radius, 0, 180);

            g.DrawString(ButtonText, this.Font, Brushes.Black, TextLocation);
        }

        public void OnPaintEx(PaintEventArgs e)
        {
            this.OnPaint(e);
        }

        // マウスオーバー
        protected override void OnMouseEnter(EventArgs e)
        {
            if (TaskAnimetionColorDown != null)
            {
                try
                {
                    TaskAnimetionColorDown.Wait();
                }
                catch (AggregateException) { }
                finally
                {
                    TaskAnimetionColorDown.Dispose();
                }
                TaskAnimetionColorDown = null;
            }
            if (TaskAnimetionColorUp != null)
            {
                return;
            }
            TaskAnimetionColorUp = new Task(AnimeColorUp);
            TaskAnimetionColorUp.Start();
        }

        // マウスアウト
        protected override void OnMouseLeave(EventArgs e)
        {
            if (TaskAnimetionColorUp != null)
            {
                try
                {
                    TaskAnimetionColorUp.Wait();
                }
                catch (AggregateException) { }
                finally
                {
                    TaskAnimetionColorUp.Dispose();
                }
                TaskAnimetionColorUp = null;
            }
            if (TaskAnimetionColorDown != null)
            {
                return;
            }
            TaskAnimetionColorDown = new Task(AnimeColorDown);
            TaskAnimetionColorDown.Start();
        }

        // 色アニメーションUp
        private void AnimeColorUp()
        {
            while (ColorRatio <= ColorDivCnt)
            {
                Color = GetRatioAnimeColor();
                Invalidate(Region);
                ColorRatio++;
                Thread.Sleep(10);
            }
            ColorRatio = ColorDivCnt;
        }

        // 色アニメーションDown
        private void AnimeColorDown()
        {
            while (ColorRatio >= 0)
            {
                Color = GetRatioAnimeColor();
                Invalidate(Region);
                ColorRatio--;
                Thread.Sleep(10);
            }
            ColorRatio = 0;
        }

        // アニメーション色取得
        private Color GetRatioAnimeColor()
        {
            double mr = (double)(ColorDivCnt - ColorRatio) / ColorDivCnt;
            double hr = (double)ColorRatio / ColorDivCnt;

            double r = MainColor.R * mr + HoverColor.R * hr;
            double g = MainColor.G * mr + HoverColor.G * hr;
            double b = MainColor.B * mr + HoverColor.B * hr;

            return Color.FromArgb((int)r, (int)g, (int)b);
        }
    }
}
