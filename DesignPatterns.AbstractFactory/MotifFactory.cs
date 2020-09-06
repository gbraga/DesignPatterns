namespace DesignPatterns.AbstractFactory
{
    public class MotifFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar() => new MotifScrollBar();

        public override Window CreateWindow() => new MotifWindow();
    }
}
