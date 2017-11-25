﻿using CloudBust.Application.Models;
using Orchard.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudBust.Dashboard.ViewModels
{
    public class SessionsViewModel
    {
        public ApplicationRecord Application { get; set; }
        public IUser User { get; set; }
        public IList<ApplicationGameRecord> Games { get; set; }
        public ApplicationGameRecord Game { get; set; }
        public string UserName { get; set; }
        public IList<SessionRecord> Sessions { get; set; }
        public int Page { get; set; }
    }
}