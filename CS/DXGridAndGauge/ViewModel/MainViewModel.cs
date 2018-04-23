using DXGridAndGauge.Core;
using DXGridAndGauge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXGridAndGauge.ViewModel {
    public class MainViewModel : Bindable {
        public static TestDataItems CreateTestItems() {
            TestDataItems res = new TestDataItems();
            res.Add(new TestDataItem() { ID = 0, Text = "Text 0", Date = DateTime.Now, ComboValueID = 0 });
            res.Add(new TestDataItem() { ID = 1, Text = "Text 1", Date = DateTime.Now.AddDays(1), ComboValueID = 1 });
            res.Add(new TestDataItem() { ID = 2, Text = "Text 2", Date = DateTime.Now.AddDays(2), ComboValueID = 2 });
            return res;
        }
        public static ComboValues CreateComboValues() {
            ComboValues res = new ComboValues();
            res.Add(new ComboValue() { ID = 0, Text = "ComboValue 0" });
            res.Add(new ComboValue() { ID = 1, Text = "ComboValue 1" });
            res.Add(new ComboValue() { ID = 2, Text = "ComboValue 2" });
            return res;
        }
        public TestDataItems Data {
            get { return data; }
            set {
                if (data == value) return;
                data = value;
                OnPropertyChanged("Data");
            }
        }
        public ComboValues ComboValues {
            get { return comboValues; }
            set {
                if (comboValues == value) return;
                comboValues = value;
                OnPropertyChanged("ComboValues");
            }
        }
        public MainViewModel() {
            Data = CreateTestItems();
            ComboValues = CreateComboValues();
        }

        TestDataItems data;
        ComboValues comboValues;
    }

}
