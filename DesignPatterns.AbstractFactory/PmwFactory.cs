namespace DesignPatterns.AbstractFactory
{
    public class PmwFactory : WidgetFactory
    {
        public override ScrollBar CreateScrollBar() => new PmwScrollBar();

        public override Window CreateWindow() => new PmwWindow();
    }
}
