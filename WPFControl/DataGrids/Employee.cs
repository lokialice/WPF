﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGrids
{
    public class Employee: INotifyPropertyChanged
    {
        private String name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaiseProperChanged();
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaiseProperChanged();
            }
        }

        private bool wasReElected;

        public bool WasReElected
        {
            get { return wasReElected; }
            set
            {
                wasReElected = value;
                RaiseProperChanged();
            }
        }

        private Party affiliation;

        public Party Affiliation
        {
            get { return affiliation; }
            set
            {
                affiliation = value;
                RaiseProperChanged();
            }
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();

            employees.Add(new Employee() { Name = "Ali", Title = "Minister", WasReElected = true, Affiliation = Party.Indepentent });
            employees.Add(new Employee() { Name = "Ahmed", Title = "CM", WasReElected = false, Affiliation = Party.Federalist });
            employees.Add(new Employee() { Name = "Amjad", Title = "PM", WasReElected = true, Affiliation = Party.DemocratRepublican });
            employees.Add(new Employee() { Name = "Waquas", Title = "Minister", WasReElected = false, Affiliation = Party.Indepentent });
            employees.Add(new Employee() { Name = "Bilal", Title = "Minister", WasReElected = true, Affiliation = Party.Federalist });
            employees.Add(new Employee() { Name = "Waquar", Title = "Minister", WasReElected = false, Affiliation = Party.DemocratRepublican });

            return employees;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaiseProperChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
