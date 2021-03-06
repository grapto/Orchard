﻿using Orchard.Security;
using CloudBust.Application.Services;
using System;

namespace CloudBust.Dashboard.ViewModels
{
    public class FieldCreateViewModel  {
        public IUser User { get; set; }
        public string ApplicationDataTableName { get; set; }
        public string ApplicationDataTableID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FieldType { get; set; }
    }    
}
