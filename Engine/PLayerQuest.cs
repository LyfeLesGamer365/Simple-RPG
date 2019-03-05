﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Engine
{
    public class PlayerQuest : INotifyPropertyChanged
    {
        private Quest _details;
        private bool _isCompleted;

        public Quest details
        {
            get { return _details; }
            set
            {
                _details = value;
                OnPropertyChanged("Details");
            }
        }
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                OnPropertyChanged("IsCompleted");
                OnPropertyChanged("Name");
            }
        }

        public string Name
        {
            get { return details.Name; }
        }

        public PlayerQuest(Quest details)
        {
            _details = details;
            IsCompleted = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }

        }
    }
}
