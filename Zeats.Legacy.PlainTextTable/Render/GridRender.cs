using System.Collections.Generic;
using Zeats.Legacy.PlainTextTable.Extensions;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.Styles;
using Zeats.Legacy.PlainTextTable.ValueObjects;

namespace Zeats.Legacy.PlainTextTable.Render
{
    public class GridRender
    {
        private readonly GridDefinition _grid;

        public GridRender(GridDefinition grid)
        {
            _grid = grid;
            Styles = new List<IBorderStyle>();
        }

        public List<IBorderStyle> Styles { get; }

        public string Render(int columns)
        {
            _grid.ApplyStyle(Styles);

            var tableInfo = new TableInfo(_grid, columns);
            var table = tableInfo.InitTable();

            foreach (var cellDefinition in _grid.CellDefinitions)
                table.DrawCell(cellDefinition, tableInfo.RowsBreaks, tableInfo.ColumnsBreaks);

            return table.Print(tableInfo.Rows, columns);
        }
    }
}