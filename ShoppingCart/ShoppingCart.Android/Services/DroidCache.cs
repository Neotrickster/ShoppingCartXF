using Akavache;
using ShoppingCart.Services;
using System;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Droid.Services
{
    public class DroidCache : ICache
    {
        public DroidCache()
        {
            BlobCache.ApplicationName = "ShoppingCart.Droid";
        }

        public async Task<T> GetObject<T>(string key)
        {
            return await BlobCache.LocalMachine.GetObject<T>(key);
        }

        public async Task InsertObject<T>(string key, T value)
        {
            await BlobCache.LocalMachine.InsertObject(key, value);
        }
    }
}