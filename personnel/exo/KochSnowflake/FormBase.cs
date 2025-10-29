namespace KochSnowflake
{
    public partial class FormBase : Form
    {
        Panel DrawingPanel;

        public FormBase()
        {
            InitializeComponent();

            DrawingPanel = new Panel();
            DrawingPanel.Location = new Point(90, 59);
            DrawingPanel.Name = "drawingPanel";
            DrawingPanel.Size = new Size(800, 600);
            DrawingPanel.TabIndex = 0;
            DrawingPanel.Paint += drawingPanel_Paint;

            this.Controls.Add(DrawingPanel);
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Blue, 1))
            {
                e.Graphics.DrawLine(pen, new Point(50, 50), new Point(75, 65));
            }
        }
    }
}
