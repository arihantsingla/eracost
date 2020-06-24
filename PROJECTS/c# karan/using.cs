using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bankwpf
{

public partial class MainWindow : Window
{
private double savingBal = 0.0;
private double checkBal = 0.0;

public MainWindow()
{
InitializeComponent();
}

private void okBtn_Click(object sender, RoutedEventArgs e)
{

if (amount.Text == "")
{
MessageBoxButton buttonErr = MessageBoxButton.OK;
MessageBoxResult result1 = MessageBox.Show("Please Enter The Amount To Perform The Transfer", "Error", buttonErr, MessageBoxImage.Error);
}
else
{
double val = Convert.ToDouble(amount.Text);

if (val <= 0.0)
{
MessageBoxButton buttonErr = MessageBoxButton.OK;
MessageBoxResult result1 = MessageBox.Show("Please check the amount you are trying to enter and try again! Thank You", "Error", buttonErr, MessageBoxImage.Error);
}
else
{

if (rb3.IsChecked == true)
{
MessageBoxButton button = MessageBoxButton.YesNo;

if (rb1.IsChecked == true)
{
MessageBoxResult result = MessageBox.Show("Do you want to withdrawl $" + amount.Text + " from your Saving account", "Important Query", button, MessageBoxImage.Information);

if (result == MessageBoxResult.Yes)
{
if (savingBal < val)
{
MessageBoxButton buttonErr = MessageBoxButton.OK;
MessageBoxResult result1 = MessageBox.Show("You can not withdraw the amount which exceed your balance!\nPlease try again", "Error", buttonErr, MessageBoxImage.Error);
}
else
{
savingBal -= val;
balance.Text = savingBal.ToString();
amount.Text = "";
}
}
}
if (rb2.IsChecked == true)
{
MessageBoxResult result = MessageBox.Show("Do you want to withdrawl $" + amount.Text + " from your Chequing account", "Important Query", button);
if (result == MessageBoxResult.Yes)
{
if (checkBal < val)
{
MessageBoxButton buttonErr = MessageBoxButton.OK;
MessageBoxResult result1 = MessageBox.Show("You can not withdraw the amount exceed your balance!\nPlease try again", "Error", buttonErr, MessageBoxImage.Error);
}
else
{
checkBal -= val;
balance.Text = checkBal.ToString();
amount.Text = "";
}
}
}
}

if (rb4.IsChecked == true)
{
MessageBoxButton button = MessageBoxButton.YesNo;

if (rb1.IsChecked == true)
{
MessageBoxResult result = MessageBox.Show("Do you want to deposite $" + amount.Text + " to your Saving account", "Important Query", button, MessageBoxImage.Information);

if (result == MessageBoxResult.Yes)
{
savingBal += val;
balance.Text = savingBal.ToString();
amount.Text = "";
}
}
if (rb2.IsChecked == true)
{
MessageBoxResult result = MessageBox.Show("Do you want to deposite $" + amount.Text + " from your Chequing account", "Important Query", button);

if (result == MessageBoxResult.Yes)
{
checkBal += val;
balance.Text = checkBal.ToString();
amount.Text = "";
}
}

}
}
}
}

private void quitBtn_Click(object sender, RoutedEventArgs e)
{
System.Environment.Exit(0);
}

private void rb1_Checked(object sender, RoutedEventArgs e)
{
if (balance != null)
{
balance.Text = savingBal.ToString();
}
}

private void rb2_Checked(object sender, RoutedEventArgs e)
{
if (balance != null)
{
balance.Text = checkBal.ToString();
}
}
}
}