using System;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private Random _random = new Random();

        private Rectangle[] _rectangles = new Rectangle[5];

        private Rectangle _currentRectangle;

        public RectanglesControl()
        {
            InitializeComponent();

            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = new Rectangle(_random.Next(1, 301),
                    _random.Next(1, 301),
                    _random.Next(1, 401),
                    _random.Next(1, 401),
                    Enum.GetNames(typeof(Color))[_random.Next(8)]);
                RectanglesListBox.Items.Add($"Rectangle {_rectangles[i].Id}");
            }
        }

        private int FindRectangleWithMaxWidth()
        {
            var maxWidth = _rectangles[0].Width;
            var i = 0;
            var maxWidthRectangle = 0;
            foreach (var rectangle in _rectangles)
            {
                if (rectangle.Width > maxWidth)
                {
                    maxWidth = rectangle.Width;
                    maxWidthRectangle = i;
                }
                i++;
            }
            return maxWidthRectangle;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            HeightTextBox.Text = _currentRectangle.Height.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            XCenterTextBox.Text = _currentRectangle.Center.X.ToString();
            YCenterTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                HeightTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Height = Double.Parse(HeightTextBox.Text);
            }
            catch
            {
                HeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Double.Parse(WidthTextBox.Text);
            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ColorTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Color = (Enum.Parse(typeof(Color), ColorTextBox.Text)).ToString();
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }
    }
}
