using Zeats.Legacy.PlainTextTable.Render;
using Zeats.Legacy.PlainTextTable.Styles;

namespace Zeats.Legacy.PlainTextTable.Extensions
{
    public static class GridRenderExtensions
    {
        public static GridRender AddStyle<T>(this GridRender gridRender)
            where T : IBorderStyle, new()
        {
            gridRender.Styles.Add(new T());

            return gridRender;
        }

        public static GridRender AddStyle(this GridRender gridRender, IBorderStyle borderStyle)
        {
            gridRender.Styles.Add(borderStyle);

            return gridRender;
        }
    }
}