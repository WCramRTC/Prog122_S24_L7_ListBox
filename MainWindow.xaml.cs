using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog122_S24_L7_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> people = new List<Person>();
        List<string> items = new List<string>();
        List<string> dndList = new List<string> {
                "Healing Potion",
                "Longsword",
                "Chain Mail",
                "Dwarven Throwing Axe",
                "Spellbook",
                "Rope (50 ft.)",
                "Tinderbox",
                "Backpack",
                "Bedroll",
                "Flask of Alchemist's Fire"  // A slightly more exciting item!
            };

        List<string> cranes = new List<string>
        {
            "RT65S",
            "RT865BXL",
            "GMK7450",
            "GMK5350",
            "RT635C"
        };


        // RT65S
        // RT865BXL
        // GMK7450
        // GMK5350
        // RT635C

        public MainWindow()
        {
            InitializeComponent();

            items.Add("Charles");
            items.Add("Rafael");
            items.Add("Dylan");
            items.Add("Will");
            items.Add("Longsword");
            items.Add("Mimic");

            people.Add(new Person("Rafael", "Banderas", dndList));
            people.Add(new Person("Charles", "Conan", cranes));
            people.Add(new Person("Will", "Calvera", items));

            // .ItemsSource
            cmbNames.ItemsSource = people;
            cmbNames.SelectedIndex = 0;

 


            //PopulateListBox(dndList, cmbNames.Items);

        } // MainWindow()


        private void cmbNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedCmbIndex = cmbNames.SelectedIndex;

            lbDisplay.ItemsSource = people[selectedCmbIndex].PersonaList;
        }


        public void PopulateListBox(List<string> items, ItemCollection itemCollection)
        {
            itemCollection.Clear();
            foreach (string item in items)
            {
                itemCollection.Add(item);
            }
        }

        private void lbDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // How do we get the selected item?
            // .Selected

            // Getting the selected index
            // .SelectedIndex
            int selectedIndex = lbDisplay.SelectedIndex;
            lblCurrentSelectionIndex.Content = selectedIndex;

            // Getting the selected value
            // .SelectedItem
            if(lbDisplay.SelectedValue != null)
            {
                string value = lbDisplay.SelectedValue.ToString();
                lblCurrentSelectedValue.Content = value;

            }


        } // lbDisplay_SelectionChanged

        public void AddExamples()
        {
            // How do we add data to the list box
            // .Items is the internal list for listbox
            // that holds the items that will display

            lbDisplay.Items.Add("Charles");
            lbDisplay.Items.Add("Mimic");
            lbDisplay.Items.Add("Longsword");

            // Rafael
            // Charles
            // Will
            // Dylan
            cmbNames.Items.Add("Rafael");
            cmbNames.Items.Add("Charles");
            cmbNames.Items.Add("Will");
            cmbNames.Items.Add("Dylan");

            // assign the comboboxes currently selected index to our new label
            // here
            lbCmbSelectedIndex.Content = cmbNames.SelectedIndex;
        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {
            // Grab the selected index from the combobox
            int selectedFromCombo = cmbNames.SelectedIndex;

            // Grab the string from text box
            string userValue = txtAddToList.Text;

            // Access the selected persons list
            List<string> userList = people[selectedFromCombo].PersonaList;

            // Add the string to the selected persons list
            userList.Add(userValue);

            // Refresh the list box
            lbDisplay.Items.Refresh();

        }// btnAddToList_Click



        // ComboBox
        // ListBox

    } // class

} // namespace