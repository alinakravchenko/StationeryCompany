﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryCompany2
{
    internal class MenuItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Action Delegate { get; set; }
        public MenuItem() { }
        public MenuItem(int Id, string Description, Action Delegate)
        {
            this.Id = Id;
            this.Description = Description;
            this.Delegate = Delegate;
        }
    }
}
