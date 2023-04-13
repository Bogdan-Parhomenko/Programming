using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            RectanglesAddingListBox.DisplayMember = nameof(Rectangle.Info);
        }

        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            RectanglesIdTextBox.Text = rectangle.Id.ToString();
            RectanglesXTextBox.Text = rectangle.X.ToString();
            RectanglesYTextBox.Text = rectangle.Y.ToString();
            RectanglesWidthTextBox.Text = rectangle.Width.ToString();
            RectanglesHeightTextBox.Text = rectangle.Height.ToString();
        }

        private void ClearRectangleInfo()
        {
            RectanglesIdTextBox.Clear();
            RectanglesXTextBox.Clear();
            RectanglesXTextBox.BackColor = Color.White;
            RectanglesYTextBox.Clear();
            RectanglesYTextBox.BackColor = Color.White;
            RectanglesWidthTextBox.Clear();
            RectanglesWidthTextBox.BackColor = Color.White;
            RectanglesHeightTextBox.Clear();
            RectanglesHeightTextBox.BackColor = Color.White;
        }

        private void RectanglesAddingButton_Click(object sender, EventArgs e)
        {
            var addedRectangleId = _rectangles.Count;
            _rectangles.Add(RectangleFactory.Randomize(CanvasPanel));
            RectanglesAddingListBox.Items.Add(_rectangles[addedRectangleId]);
            var panel = new Panel
            {
                Location = new Point((int)_rectangles[addedRectangleId].X, (int)_rectangles[addedRectangleId].Y),
                Width = (int)_rectangles[addedRectangleId].Width,
                Height = (int)_rectangles[addedRectangleId].Height,
                BackColor = Color.FromArgb(127, 127, 255, 127)
            };
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);
            FindCollisions();
        }

        private void RectanglesDeletingButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = RectanglesAddingListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _rectanglePanels.RemoveAt(selectedIndex);
                CanvasPanel.Controls.RemoveAt(selectedIndex);
                _rectangles.RemoveAt(selectedIndex);
                RectanglesAddingListBox.Items.RemoveAt(selectedIndex);
                FindCollisions();
            }
        }

        private void RectanglesAddingListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesAddingListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesAddingListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
            else
            {
                ClearRectangleInfo();
            }
        }

        private void RectanglesXTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesXTextBox.BackColor = Color.White;
                _currentRectangle.X = Double.Parse(RectanglesXTextBox.Text);
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Location =
                    new Point((int)_currentRectangle.X, (int)_currentRectangle.Y);
                FindCollisions();
            }
            catch
            {
                RectanglesXTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesYTextBox.BackColor = Color.White;
                _currentRectangle.Y = Double.Parse(RectanglesYTextBox.Text);
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Location =
                    new Point((int)_currentRectangle.X, (int)_currentRectangle.Y);
                FindCollisions();
            }
            catch
            {
                RectanglesYTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesWidthTextBox.BackColor = Color.White;
                _currentRectangle.Width = Double.Parse(RectanglesWidthTextBox.Text);
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Width = (int)_currentRectangle.Width;
                FindCollisions();
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = Color.LightPink;
            }
        }

        private void RectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesHeightTextBox.BackColor = Color.White;
                _currentRectangle.Height = Double.Parse(RectanglesHeightTextBox.Text);
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Height = (int)_currentRectangle.Height;
                FindCollisions();
            }
            catch
            {
                RectanglesHeightTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
