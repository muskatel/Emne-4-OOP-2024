using System.Drawing;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Brushes = System.Drawing.Brushes;
using Color = System.Drawing.Color;
using Point = Avalonia.Point;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DrawStuff();
    }

    private void DrawStuff()
    {
        GraphCanvas.Children.Add(new Line()
        {
            StartPoint = new Point(0,0),
            EndPoint = new Point(10,10),
            Stroke = Avalonia.Media.Brushes.Black
        });
    }
}