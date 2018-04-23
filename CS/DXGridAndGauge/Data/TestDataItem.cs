using DXGridAndGauge.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DXGridAndGauge.Data {
    public class TestDataItem : Bindable {
        public int ID {
            get { return id; }
            set {
                if (id == value) return;
                id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Text {
            get { return text; }
            set {
                if (text == value) return;
                text = value;
                OnPropertyChanged("Text");
            }
        }
        public DateTime Date {
            get { return date; }
            set {
                if (date == value) return;
                date = value;
                OnPropertyChanged("Date");
            }
        }
        public int ComboValueID {
            get { return comboValueID; }
            set {
                if (comboValueID == value) return;
                comboValueID = value;
                OnPropertyChanged("ComboValueID");
            }
        }
        int id = -1;
        string text = null;
        DateTime date;
        int comboValueID;
    }
}
