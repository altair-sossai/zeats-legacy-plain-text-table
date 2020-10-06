﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeats.Legacy.PlainTextTable.Enums;
using Zeats.Legacy.PlainTextTable.Extensions;
using Zeats.Legacy.PlainTextTable.Grid;
using Zeats.Legacy.PlainTextTable.Render;
using Zeats.Legacy.PlainTextTable.Styles.Types;

namespace Zeats.Legacy.PlainTextTable.UnitTest.Styles.Types
{
    [TestClass]
    public class WhiteSpaceBorderStyleTest
    {
        [TestMethod]
        public void Case_01()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                }
            };

            grid
                .AddCell("Produto", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Valor", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Qtd.", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Total", horizontalAlign: HorizontalAlign.Center);

            grid
                .AddCell("Refeição")
                .AddCell("R$ 44,90")
                .AddCell("0,000 kg")
                .AddCell("R$ 8,89");

            grid
                .AddCell("Refrigerantes")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell("Sucos")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            var gridRender = new GridRender(grid);

            gridRender.AddStyle<WhiteSpaceBorderStyle>();

            var actual = gridRender.Render(57);

            var expected =
                "                                                         " + Environment.NewLine +
                "            Produto             Valor     Qtd.    Total  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Refeição                      R$ 44,90 0,000 kg R$ 8,89 " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Refrigerantes                                           " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Sucos                                                   " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         ";


            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Case_02()
        {
            var grid = new GridDefinition
            {
                RowDefinitions = new List<RowDefinition>
                {
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto},
                    new RowDefinition {HeightType = HeightType.Auto}
                },
                ColumnDefinitions = new List<ColumnDefinition>
                {
                    new ColumnDefinition {WidthType = WidthType.Star, Width = 1},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto},
                    new ColumnDefinition {WidthType = WidthType.Auto}
                }
            };

            grid
                .AddCell("Produto", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Valor", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Qtd.", horizontalAlign: HorizontalAlign.Center)
                .AddCell("Total", horizontalAlign: HorizontalAlign.Center);

            grid
                .AddCell("Refeição")
                .AddCell("R$ 44,90")
                .AddCell("0,000 kg")
                .AddCell("R$ 8,89");

            grid
                .AddCell("Refrigerantes")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell("Sucos")
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            grid
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty)
                .AddCell(string.Empty);

            var gridRender = new GridRender(grid);

            gridRender.AddStyle<WhiteSpaceBorderStyle>();
            gridRender.AddStyle<BottomBorderStyle>();

            var actual = gridRender.Render(57);

            var expected =
                "                                                         " + Environment.NewLine +
                "            Produto             Valor     Qtd.    Total  " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Refeição                      R$ 44,90 0,000 kg R$ 8,89 " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Refrigerantes                                           " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                " Sucos                                                   " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "                                                         " + Environment.NewLine +
                "---------------------------------------------------------";


            Assert.AreEqual(expected, actual);
        }
    }
}