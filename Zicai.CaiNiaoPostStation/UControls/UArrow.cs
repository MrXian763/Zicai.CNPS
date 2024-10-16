using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zicai.CaiNiaoPostStation.UControls
{
    public partial class UArrow : UserControl
    {
        public UArrow()
        {
            InitializeComponent();

            // 控件样式标志设置
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.SizeChanged += UArrow_SizeChanged;
            this.Size = new System.Drawing.Size(100, 50);
        }

        // 要绘制的路径
        GraphicsPath path;

        private Color arrowColor = Color.Blue;
        // 箭头颜色
        [Description("箭头颜色"), Category("自定义")]
        public Color ArrowColor
        {
            get { return arrowColor; }
            set
            {
                arrowColor = value;
                Invalidate(); // 重绘
            }
        }

        private Color? borderColor = null;
        // 箭头边框颜色
        [Description("箭头边框颜色"), Category("自定义")]
        public Color? BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // 重绘
            }
        }

        private ArrowDirection direction;
        // 箭头方向
        [Description("箭头方向"), Category("自定义")]
        public ArrowDirection Direction
        {
            get { return direction; }
            set
            {
                direction = value;
                // 重置路径
                DrawArrowPath();
                Invalidate(); // 重绘
            }
        }

        /// <summary>
        /// 控件大小改变时触发
        /// </summary>
        private void UArrow_SizeChanged(object sender, EventArgs e)
        {
            // 重置箭头路径（形状的区域）
            DrawArrowPath();
        }

        /// <summary>
        /// 生成形状路径
        /// </summary>
        private void DrawArrowPath()
        {
            Point[] points = null; // 点集合
            switch (direction)
            {
                case ArrowDirection.Left:
                    points = new Point[]
                    {
                        new Point(0, Height / 2),
                        new Point(Width / 3, 0),
                        new Point(Width / 3, Height / 4),
                        new Point(Width - 1, Height / 4),
                        new Point(Width - 1, Height - Height / 4),
                        new Point(Width / 3, Height - Height / 4),
                        new Point(Width / 3, Height),
                       new Point(0, Height / 2)
                    };
                    break;
                case ArrowDirection.Right:
                    points = new Point[]
                    {
                        new Point(0, Height / 4),
                        new Point(Width - Width / 3, Height / 4),
                        new Point(Width - Width / 3, 0),
                        new Point(Width - 1, Height / 2),
                        new Point(Width - Width / 3, Height),
                        new Point(Width - Width / 3, Height - Height / 4),
                        new Point(0, Height - Height / 4),
                        new Point(0, Height / 4)
                    };
                    break;
                case ArrowDirection.Up:
                    points = new Point[]
                    {
                       new Point(this.Width / 2, 0),
                       new Point(this.Width, Height / 3),
                       new Point(this.Width - this.Width / 4, Height /3),
                       new Point(this.Width - this.Width / 4, this.Height - 1),
                       new Point(this.Width / 4, this.Height - 1),
                       new Point(this.Width / 4, Height / 3),
                       new Point(0, Height / 3),
                       new Point(this.Width / 2, 0)
                    };
                    break;
                case ArrowDirection.Down:
                    points = new Point[]
                    {
                       new Point(this.Width - this.Width / 4, 0),
                       new Point(this.Width - this.Width / 4, this.Height - Height / 3),
                       new Point(this.Width, this.Height - Height / 3),
                       new Point(this.Width / 2, this.Height - 1),
                       new Point(0, this.Height - Height / 3),
                       new Point(this.Width / 4, this.Height - Height / 3),
                       new Point(this.Width / 4, 0),
                       new Point(this.Width - this.Width / 4, 0)
                    };
                    break;
            }
            path = new GraphicsPath();
            path.AddLines(points);
            path.CloseAllFigures();
        }

        /// <summary>
        /// 绘图
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPath(new SolidBrush(ArrowColor), path);
            if (BorderColor != null && BorderColor != Color.Empty)
            {
                g.DrawPath(new Pen(new SolidBrush(borderColor.Value), 2), path);
            }
        }

        /// <summary>
        /// 箭头方向
        /// </summary>
        public enum ArrowDirection
        {
            Left,
            Right,
            Up,
            Down
        }
    }
}
