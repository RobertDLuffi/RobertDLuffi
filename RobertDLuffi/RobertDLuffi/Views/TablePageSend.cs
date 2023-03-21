using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RobertDLuffi.Views
{
    public class TablePageSend : ContentPage
    {
        public TablePageSend()
        {
            Grid grid = new Grid
            {
                RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            },
                ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
            };
            grid.Children.Add(new BoxView { Color = Color.Aqua }, 0, 0);
            grid.Children.Add(new BoxView { Color = Color.Blue }, 0, 1);
            grid.Children.Add(new BoxView { Color = Color.Fuchsia }, 0, 2);

            grid.Children.Add(new BoxView { Color = Color.Teal }, 1, 0);
            grid.Children.Add(new BoxView { Color = Color.Green }, 1, 1);
            grid.Children.Add(new BoxView { Color = Color.Maroon }, 1, 2);

            grid.Children.Add(new BoxView { Color = Color.Olive }, 2, 0);
            grid.Children.Add(new BoxView { Color = Color.Pink }, 2, 1);
            grid.Children.Add(new BoxView { Color = Color.Yellow }, 2, 2);

            grid.Children.Add(new BoxView { Color = Color.Olive }, 3, 0);
            grid.Children.Add(new BoxView { Color = Color.Pink }, 3, 1);
            grid.Children.Add(new BoxView { Color = Color.Yellow }, 3, 2);

            Content = grid;
        }
    }
}