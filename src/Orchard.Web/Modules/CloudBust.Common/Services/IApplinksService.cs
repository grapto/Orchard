﻿using System;
using System.Collections.Generic;
using Orchard;
using CloudBust.Common.Models;

namespace CloudBust.Common.Services {
    public interface IApplinksService : IDependency {
		ApplinksFileRecord Get();
		Tuple<bool, IEnumerable<string>> Save(string text);
	}
}