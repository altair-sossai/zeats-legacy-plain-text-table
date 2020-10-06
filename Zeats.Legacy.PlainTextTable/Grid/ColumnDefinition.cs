using Zeats.Legacy.PlainTextTable.Enums;

namespace Zeats.Legacy.PlainTextTable.Grid
{
    public class ColumnDefinition
    {
        public ColumnDefinition()
        {
            WidthType = WidthType.Star;
            Width = 1;
        }

        public WidthType WidthType { get; set; }
        public int Width { get; set; }
    }
}