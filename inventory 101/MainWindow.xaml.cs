﻿using System;
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
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;


namespace inventory_101
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string CategorySelectionName;
        object newItem;
        int selectedCategoryId;
        List<StackPanel> categoryPanels = new List<StackPanel>();
        List<Cables> items = new List<Cables>();
        public XmlSerializer serialiser = new XmlSerializer(typeof(List<Cables>));
        
        

        public MainWindow()
        {
            //adds category pannels to a list and hides them
            InitializeComponent();
            categoryPanels.Add(cncLathePanel);
            categoryPanels.Add(cncMillPanel);
            categoryPanels.Add(EDPrinterPanel);
            categoryPanels.Add(WeakCurrentPanel);
            categoryPanels.Add(StrongCurrentPanel);
            categoryPanels.Add(cablePanel);
            categoryPanels.Add(SimpleToolsPanel);
            for (int i = 0; Category_selection.Items.Count > i; i++)
            {
                categoryPanels[i].Visibility = Visibility.Collapsed;



            }
            //loads the items file
            
            
            using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
            {

                items = (List<Cables>)serialiser.Deserialize(file);



            }
            


        }

        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CategorySelectionName = Category_selection.SelectedValue.ToString().Substring(38);
            selectedCategoryId = Category_selection.SelectedIndex;
            Categorydisplay.Text = CategorySelectionName.ToString();
            SelectedCategorypanel(selectedCategoryId);
            
            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool visible = (Category_selection.Visibility == Visibility.Visible);

            if (visible)
            {
                Category_selection.Visibility = Visibility.Collapsed;
            }
            else 
            {
                Category_selection.Visibility = Visibility.Visible;
            }
        }

        private void SelectedCategorypanel(int selectedCategoryId) 
        {
        
            for(int i = 0; Category_selection.Items.Count > i; i++) 
            {
                categoryPanels[i].Visibility = Visibility.Collapsed;
            
            
            
            }

            categoryPanels[selectedCategoryId].Visibility = Visibility.Visible;

        if(selectedCategoryId == 5) 
            {
               

            
            }
        
        
        
        

        }
        private void SaveClickCables(object sender, RoutedEventArgs e)
        {
            string Name = CableName.Text.Trim();
            float length;
            Cables cable = new Cables();

            if (Name.Trim() == "")
            {
                MessageBox.Show("please make sure the item has a name");
            }
            else if (!float.TryParse(CableLength.Text.Trim(), out length))
            {
                if (CableLength.Text.Trim() == "")
                {
                    MessageBox.Show("please add the length of the cable");
                }
                else
                {

                    MessageBox.Show("make sure the lenght only contains numbers and \".\" ");

                }
                
            }
            else { 

            Debug(Name);
                cable.length = length;
                cable.name = Name;
                cable.id = 0;
                items.Add(cable);
                items.Add(cable);
                Debug(cable.name +" "+ cable.length);
                
                using (FileStream file = File.Open(@"Items.xml", FileMode.OpenOrCreate))
                {

                    serialiser.Serialize(file, items);



                }
            }
        }

        private void Debug(string debugInput) 
        {

            DebugOutput.Text = "Debug[" + debugInput + "]";


        }

    }
}
