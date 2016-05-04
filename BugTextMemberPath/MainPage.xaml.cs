using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BugTextMemberPath
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Box.ItemsSource = new ItemWrapper[3]
            {
                new ItemWrapper { Item = new Item { Name = "Item 1" } },
                new ItemWrapper { Item = new Item { Name = "Item 2" } },
                new ItemWrapper { Item = new Item { Name = "Item 3" } },
            };
        }
    }

    public class Item
    {
        public string Name { get; set; }
    }

    public class ItemWrapper
    {
        public Item Item { get; set; }
    }
}
