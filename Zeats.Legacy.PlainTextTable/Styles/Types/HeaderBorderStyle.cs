using Zeats.Legacy.PlainTextTable.Grid;

namespace Zeats.Legacy.PlainTextTable.Styles.Types
{
    public class HeaderBorderStyle : IBorderStyle
    {
        public void Apply(GridDefinition grid)
        {
            foreach (var cellDefinition in grid.CellDefinitions)
            {
                var border = cellDefinition.Border;

                if (cellDefinition.Row == 0)
                {
                    border.Left = BorderDefinition.DefaultVerticalSeparator;
                    border.Top = BorderDefinition.DefaultHorizontalSeparator;
                    border.Right = BorderDefinition.DefaultVerticalSeparator;
                    border.Bottom = BorderDefinition.DefaultHorizontalSeparator;

                    border.TopLeft = BorderDefinition.DefaultCrossSeparator;
                    border.TopRight = BorderDefinition.DefaultCrossSeparator;
                    border.BottomRight = BorderDefinition.DefaultCrossSeparator;
                    border.BottomLeft = BorderDefinition.DefaultCrossSeparator;
                }

                if (cellDefinition.Row == 1)
                {
                    border.Top = BorderDefinition.DefaultHorizontalSeparator;
                    border.TopLeft = BorderDefinition.DefaultCrossSeparator;
                    border.TopRight = BorderDefinition.DefaultCrossSeparator;
                }
            }
        }
    }
}