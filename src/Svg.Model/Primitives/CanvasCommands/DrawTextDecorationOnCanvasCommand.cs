using Svg.Model.Painting;

namespace Svg.Model.Primitives
{
    public class DrawTextDecorationCanvasCommand : CanvasCommand
    {
        public string Text { get; }
        public float X { get; }
        public float Y { get; }
        public Paint Paint { get; }
        public SvgTextDecoration TextDecoration { get; }

        public DrawTextDecorationCanvasCommand(string text, float x, float y, Paint paint, SvgTextDecoration textDecoration)
        {
            Text = text;
            X = x;
            Y = y;
            Paint = paint;
            TextDecoration = textDecoration;
        }
    }
}
