﻿using System.Collections.Generic;
using System.Linq;

using Icebox.Common.Entities;

namespace Icebox.Persistance.Extensions
{
    public static class ServerNodeExtensions
    {
        public static IEnumerable<ServerNode> InPool(this IEnumerable<ServerNode> query, string cluserId)
        {
            return query
                .Where(server => server.ClusterId == cluserId);
        }
    }
}
