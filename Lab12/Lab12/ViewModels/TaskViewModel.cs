﻿using Lab12.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab12.ViewModels
{
    internal class TaskViewModel:ViewModelBase
    {

        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        string status;
        public string Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        List<TaskModel> task;
        public List<TaskModel> Task
        {
            get { return task; }
            set
            {
                if (task != value)
                {
                    task = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        public TaskViewModel() 
        {
            Tasks = new ObservableCollection<TaskModel>();

            Save = new Command(() =>
            {
                TaskModel task = new TaskModel();
                task.Title = this.Title;

                TaskModel.Add(task);
            });

            Get= new Command(() =>
            {
            })
        }
    }
}
