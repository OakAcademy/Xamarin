using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CafeMenuApp.Models
{
    public class Food : INotifyPropertyChanged
    {
        public enum GroupName { Eatables, ColdDrinks, HotDrinks, Desserts }

        public string Name { get; set; }
        public GroupName GroupTitle { get; set; }
        public int Count { get; set; } = 1;
        public string ImagePath { get => Name + ".png"; }
        public bool Checked
        {
            get => _checked;
            set
            {
                _checked = value;
                OnPropertyChanged("Checked");
            }
        }
        private bool _checked;


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
