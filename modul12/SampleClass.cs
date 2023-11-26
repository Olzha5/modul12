﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul12
{
    public class SampleClass : iPropertychanged
    {
        private int sampleProperty;
        public event PropertyeventHandler Propertychanged;

        public int SampleProperty
        {
            get { return sampleProperty; }
            set
            {
                if (sampleProperty != value)
                {
                    sampleProperty = value;
                    OnPropertyChanged(nameof(SampleProperty));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            Propertychanged?.Invoke(this, new PropertyeventArgs(propertyName));
        }
    }

}
