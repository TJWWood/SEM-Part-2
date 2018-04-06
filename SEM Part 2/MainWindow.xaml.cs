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
using Business;

namespace SEM_Part_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Bicycle> bikeList = new List<Bicycle>();
        int duration = 2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();

            Business.Frame frame = new Business.Frame();
            if (rand.Next(0, 2) == 1)
            {
                frame.Type = combo_frame_type.Text;
                frame.Colour = combo_frame_colour.Text;
                frame.Size = combo_frame_size.Text;
            }
            else
            {
                MessageBox.Show("Frame OOS: Adding 2 days to Completion Time");
                frame.Type = combo_frame_type.Text;
                frame.Colour = combo_frame_colour.Text;
                frame.Size = combo_frame_size.Text;
                duration += 2;
            }

            double frameTypeCost = Double.Parse(((ComboBoxItem)combo_frame_type.SelectedItem).Tag.ToString());
            double frameColourCost = Double.Parse(((ComboBoxItem)combo_frame_colour.SelectedItem).Tag.ToString());
            double frameSizeCost = Double.Parse(((ComboBoxItem)combo_frame_size.SelectedItem).Tag.ToString());
            frame.Cost = frameTypeCost + frameColourCost + frameSizeCost;

            Gears gears = new Gears();
            if (rand.Next(0, 2) == 1)
            {
                gears.Type = combo_gears.Text;
            }
            else
            {
                MessageBox.Show("Gears OOS: Adding 2 days to Completion Time");
                gears.Type = combo_gears.Text;
                duration += 2;
            }

            gears.Cost = Double.Parse(((ComboBoxItem)combo_gears.SelectedItem).Tag.ToString());

            Breaks breaks = new Breaks();
            if (rand.Next(0, 2) == 1)
            {
                breaks.Type = combo_breaks.Text;
            }
            else
            {
                MessageBox.Show("Breaks OOS: Adding 2 days to Completion Time");
                breaks.Type = combo_breaks.Text;
                duration += 2;
            }
            breaks.Cost = Double.Parse(((ComboBoxItem)combo_breaks.SelectedItem).Tag.ToString());

            GroupSet groupSet = new GroupSet();
            groupSet.Gears = gears;
            groupSet.Breaks = breaks;
            groupSet.Cost = groupSet.calculateGroupSet(gears, breaks);

            Wheels wheels = new Wheels();
            if (rand.Next(0, 2) == 1)
            {
                wheels.Type = combo_handlebars.Text;

            }
            else
            {
                MessageBox.Show("Wheels OOS: Adding 2 days to Completion Time");
                wheels.Type = combo_handlebars.Text;
                duration += 2;
            }
            wheels.Cost = Double.Parse(((ComboBoxItem)combo_wheels.SelectedItem).Tag.ToString());

            Handlebars handleBars = new Handlebars();
            if (rand.Next(0, 2) == 1)
            {
                handleBars.Type = combo_handlebars.Text;
            }
            else
            {
                MessageBox.Show("Handlebars OOS: Adding 2 days to Completion Time");
                handleBars.Type = combo_handlebars.Text;
                duration += 2;
            }
            handleBars.Cost = Double.Parse(((ComboBoxItem)combo_handlebars.SelectedItem).Tag.ToString());

            Saddle saddle = new Saddle();
            if (rand.Next(0, 2) == 1)
            {
                saddle.Type = combo_saddle.Text;
            }
            else
            {
                MessageBox.Show("Saddle OOS: Adding 2 days to Completion Time");
                saddle.Type = combo_saddle.Text;
                duration += 2;
            }
            saddle.Cost = Double.Parse(((ComboBoxItem)combo_saddle.SelectedItem).Tag.ToString());

            FinishingSet finishingSet = new FinishingSet();
            finishingSet.HandleBars = handleBars;
            finishingSet.Saddle = saddle;
            finishingSet.Cost = finishingSet.calculateFinishingSet(handleBars, saddle);

            Bicycle bicycle = new Bicycle();
            bicycle.Frame = frame;
            bicycle.GroupSet = groupSet;
            bicycle.FinishingSet = finishingSet;
            bicycle.Cost = bicycle.calculateFinalCost(frame, groupSet, finishingSet, wheels);
            if(check_warranty.IsChecked == true)
            {
                bicycle.Cost += 50.0;
            }        
            bicycle.Duration = duration;
            duration = 2;

            bikeList.Add(bicycle);
            string output = "";
            int bikeNum = 1;
            double totalCost = 0.0;

            foreach (Bicycle bike in bikeList)
            {
                output += "Bike " + bikeNum + ":\n" + "Cost: " + bike.Cost + "\nCompletion Time: " + bike.Duration + " days.\n\n";
                bikeNum++;
                totalCost += bike.Cost;
            }
            MessageBox.Show(output + "\nTotal Cost: " + totalCost);
        }
    }
}
