using Programming.Model.Classes;
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
                panel.BackColor = AppColors.CollisionFalseColor;
            }

            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.CollisionTrueColor;
                        _rectanglePanels[j].BackColor = AppColors.CollisionTrueColor;
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
            RectanglesXTextBox.BackColor = AppColors.ValidationTrueColor;
            RectanglesYTextBox.Clear();
            RectanglesYTextBox.BackColor = AppColors.ValidationTrueColor;
            RectanglesWidthTextBox.Clear();
            RectanglesWidthTextBox.BackColor = AppColors.ValidationTrueColor;
            RectanglesHeightTextBox.Clear();
            RectanglesHeightTextBox.BackColor = AppColors.ValidationTrueColor;
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
                BackColor = AppColors.CollisionFalseColor
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
                RectanglesXTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.X = Double.Parse(RectanglesXTextBox.Text);
                RectanglesAddingListBox.SelectedIndexChanged -= RectanglesAddingListBox_SelectedIndexChanged;
                RectanglesAddingListBox.Items[RectanglesAddingListBox.SelectedIndex] = 
                _rectangles[RectanglesAddingListBox.SelectedIndex];
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Location =
                    new Point((int)_currentRectangle.X, (int)_currentRectangle.Y);
                FindCollisions();
                RectanglesAddingListBox.SelectedIndexChanged += RectanglesAddingListBox_SelectedIndexChanged;
            }
            catch
            {
                RectanglesXTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        private void RectanglesYTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesYTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.Y = Double.Parse(RectanglesYTextBox.Text);
                RectanglesAddingListBox.SelectedIndexChanged -= RectanglesAddingListBox_SelectedIndexChanged;
                RectanglesAddingListBox.Items[RectanglesAddingListBox.SelectedIndex] =
                _rectangles[RectanglesAddingListBox.SelectedIndex];
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Location =
                    new Point((int)_currentRectangle.X, (int)_currentRectangle.Y);
                FindCollisions();
                RectanglesAddingListBox.SelectedIndexChanged += RectanglesAddingListBox_SelectedIndexChanged;
            }
            catch
            {
                RectanglesYTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesWidthTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.Width = Double.Parse(RectanglesWidthTextBox.Text);
                RectanglesAddingListBox.SelectedIndexChanged -= RectanglesAddingListBox_SelectedIndexChanged;
                RectanglesAddingListBox.Items[RectanglesAddingListBox.SelectedIndex] =
                _rectangles[RectanglesAddingListBox.SelectedIndex];
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Width = (int)_currentRectangle.Width;
                FindCollisions();
                RectanglesAddingListBox.SelectedIndexChanged += RectanglesAddingListBox_SelectedIndexChanged;
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }

        private void RectanglesHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RectanglesHeightTextBox.BackColor = AppColors.ValidationTrueColor;
                _currentRectangle.Height = Double.Parse(RectanglesHeightTextBox.Text);
                RectanglesAddingListBox.SelectedIndexChanged -= RectanglesAddingListBox_SelectedIndexChanged;
                RectanglesAddingListBox.Items[RectanglesAddingListBox.SelectedIndex] =
                _rectangles[RectanglesAddingListBox.SelectedIndex];
                _rectanglePanels[RectanglesAddingListBox.SelectedIndex].Height = (int)_currentRectangle.Height;
                FindCollisions();
                RectanglesAddingListBox.SelectedIndexChanged += RectanglesAddingListBox_SelectedIndexChanged;
            }
            catch
            {
                RectanglesHeightTextBox.BackColor = AppColors.ValidationFalseColor;
            }
        }
    }
}
