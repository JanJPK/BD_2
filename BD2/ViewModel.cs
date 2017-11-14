using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD2
{
    public class ViewModel
    {
        public ObservableCollection<string> ComboBoxTest { get; private set; }

        public ViewModel()
        {
            ComboBoxTest = new ObservableCollection<string>
            {
                "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6"
            };
        }
    }
}
