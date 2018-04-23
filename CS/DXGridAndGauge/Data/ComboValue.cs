using DXGridAndGauge.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXGridAndGauge.Data {
    public class ComboValue : Bindable {
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
        int id = -1;
        string text = null;
    }
}
