using System.Linq;
using Zeats.Legacy.PlainTextTable.Extensions;
using Zeats.Legacy.PlainTextTable.Grid;

namespace Zeats.Legacy.PlainTextTable.ValueObjects
{
    public class TableInfo
    {
        public TableInfo(GridDefinition grid, int columns)
        {
            Columns = columns;

            ColumnsSize = grid.ColumnsSize(columns);
            ColumnsBreaks = ColumnsSize.ColumnsBreaks();

            RowsSize = grid.RowsSize(ColumnsSize);
            RowsBreaks = RowsSize.RowsBreaks();

            Rows = RowsSize.Sum();
        }

        public int Rows { get; }
        public int Columns { get; }
        public int[] RowsSize { get; }
        public Interval[] RowsBreaks { get; }
        public int[] ColumnsSize { get; }
        public Interval[] ColumnsBreaks { get; }

        public char[,] InitTable()
        {
            var table = new char[Rows, Columns];

            table.Init(Rows, Columns);

            return table;
        }
    }
}