﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Common;
using Windows.Foundation.Collections;
using Windows.Storage;

namespace Template10.Services.StateService
{

    public static class StateService
    {
        public static async Task<IStateItems> GetStateAsync(StateTypes type, string key = null)
        {
            key = key ?? string.Empty;
            switch (type)
            {
                case StateTypes.Session: return await StateItems.LoadAsync(key, type);
                case StateTypes.Frame: return await StateItems.LoadAsync(key, type);
                case StateTypes.Page: return await StateItems.LoadAsync(key, type);
                default: throw new NotSupportedException(type.ToString());
            }
        }
    }
}
