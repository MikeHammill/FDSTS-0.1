using System.Windows;
using System.Windows.Controls;

namespace FDSTS.App;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Navigate_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button && button.Tag is string page)
        {
            PageTitle.Text = page;
            PageHeading.Text = page;
            PageDescription.Text = page switch
            {
                "Home" => "Your household financial decision-support dashboard.",
                "Financial Position" => "Manage assets, liabilities, accounts and net worth.",
                "Planning" => "Manage Actions, Research & Planning, and Decision Points.",
                "Decisions" => "Record important household decisions and their outcomes.",
                "Insights" => "Review observations and suggested areas for attention.",
                "Reports" => "Generate household financial and decision-support reports.",
                "Administration" => "Manage household profile, settings, backups and rule versions.",
                _ => string.Empty
            };
        }
    }
}
