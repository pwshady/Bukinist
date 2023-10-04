using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.Service
{
    static class RandomExtensions
    {

        public static T NextItemRnd<T>(this Random rnd, params T[] items) => items[rnd.Next(items.Length)];

    }
}
