using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Содержит логику вкладки Rectangles.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Список элементов класса Rectangle.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// экземпляр класса Rectangle.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Список элементов класса Panel.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создает объект типа <see cref="RectanglesCollisionControl"/>.
        /// В RectanglesAddingListBox будет отображаться свойство прямоугольника Info.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            RectanglesAddingListBox.DisplayMember = nameof(Rectangle.Info);
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
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

        /// <summary>
        /// Сравнивает переданный прямоугольник с остальными и если они пересекаются, перекрашивает их.
        /// </summary>
        /// <param name="rectangle">Сравниваемый прямоугольник.</param>
        private void FindCollisions(Rectangle rectangle)
        {
            var lastRectangleIndex = _rectangles.Count - 1;

            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (rectangle == _rectangles[i])
                {
                    return;
                }
                if (CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    _rectanglePanels[i].BackColor = AppColors.CollisionTrueColor;
                    _rectanglePanels[lastRectangleIndex].BackColor = AppColors.CollisionTrueColor;
                }
            }
        }

        /// <summary>
        /// Обновляет текстовые поля выбранного прямоугольника.
        /// </summary>
        /// <param name="rectangle">прямоугольник, текстовые поля которого необходимо обновить.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            RectanglesIdTextBox.Text = rectangle.Id.ToString();
            RectanglesXTextBox.Text = rectangle.X.ToString();
            RectanglesYTextBox.Text = rectangle.Y.ToString();
            RectanglesWidthTextBox.Text = rectangle.Width.ToString();
            RectanglesHeightTextBox.Text = rectangle.Height.ToString();
        }

        /// <summary>
        /// Очищает все текстовые поля и перекрашивает их в исходный цвет.
        /// </summary>
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

        /// <summary>
        /// При нажатии на RectanglesAddingButton добавляет в список _rectangles новый
        /// прямоугольник со случайными значениями.
        /// Добавляет на RectanglesAddingListBox этот прямоугольник.
        /// Добавляет в список _rectanglePanels новую панель со случайными значениями.
        /// Добавляет на CanvasPanel эту панель.
        /// Проверяет пересечение добавленного прямоугольника с остальными.
        /// </summary>
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
            FindCollisions(_rectangles[addedRectangleId]);
        }

        /// <summary>
        /// При нажатии на RectanglesDeletingButton удаляет выбранный прямоугольник из _rectangles.
        /// Удаляет соответсвующую этому прямоугольнику панель.
        /// Удаляет с RectanglesAddingListBox этот прямоугольник.
        /// Удаляет с CanvasPanel эту панель.
        /// Проверяет пересечение всех прямоугольников.
        /// Если прямоугольник не выбран, то ничего не происходит.
        /// </summary>
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

        /// <summary>
        /// При изменении выбранного элемента RectanglesAddingListBox
        /// присваивает _currentRectangle выбранный элемент
        /// и заполняет все текстовые поля значениями _currentRectangle.
        /// Если прямоугольник не выбран, то очищает все текстовые поля.
        /// </summary>
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

        /// <summary>
        /// При изменении текста RectanglesXTextBox пытается присвоить этот текст в свойство X элемента
        /// _currentRectangle и красит RectangleXTextBox в соответствии с валидацией.
        /// При изменении текстовых полей обновляет информацию в RectanglesAddingListBox
        /// в соответствии с этими значениями.
        /// Перерисовывает соответствующую этому прямоугольнику панель в соответствии с новыми значениями.
        /// Проверяет пересечение прямоугольников.
        /// </summary>
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

        /// <summary>
        /// При изменении текста RectanglesYTextBox пытается присвоить этот текст в свойство Y элемента
        /// _currentRectangle и красит RectangleYTextBox в соответствии с валидацией.
        /// При изменении текстовых полей обновляет информацию в RectanglesAddingListBox
        /// в соответствии с этими значениями.
        /// Перерисовывает соответствующую этому прямоугольнику панель в соответствии с новыми значениями.
        /// Проверяет пересечение прямоугольников.
        /// </summary>
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

        /// <summary>
        /// При изменении текста RectanglesWidthTextBox пытается присвоить этот текст в свойство Width элемента
        /// _currentRectangle и красит RectangleWidthTextBox в соответствии с валидацией.
        /// При изменении текстовых полей обновляет информацию в RectanglesAddingListBox
        /// в соответствии с этими значениями.
        /// Перерисовывает соответствующую этому прямоугольнику панель в соответствии с новыми значениями.
        /// Проверяет пересечение прямоугольников.
        /// </summary>
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

        /// <summary>
        /// При изменении текста RectanglesWidthTextBox пытается присвоить этот текст в свойство Width элемента
        /// _currentRectangle и красит RectangleWidthTextBox в соответствии с валидацией.
        /// При изменении текстовых полей обновляет информацию в RectanglesAddingListBox
        /// в соответствии с этими значениями.
        /// Перерисовывает соответствующую этому прямоугольнику панель в соответствии с новыми значениями.
        /// Проверяет пересечение прямоугольников.
        /// </summary>
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
