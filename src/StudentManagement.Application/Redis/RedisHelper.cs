using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Redis
{
    public class RedisHelper
    {
        private readonly IDatabase _db;

        public RedisHelper()
        {
            var redis = ConnectionMultiplexer.Connect("localhost:6379");
            _db = redis.GetDatabase();
        }

        public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {
            var json = JsonConvert.SerializeObject(value);
            await _db.StringSetAsync(key, json, expiry);
        }

        public async Task<T?> GetAsync<T>(string key)
        {
            var value = await _db.StringGetAsync(key);
            if (value.IsNullOrEmpty)
                return default;

            return JsonConvert.DeserializeObject<T>(value!);
        }

        public async Task<bool> RemoveAsync(string key)
        {
            return await _db.KeyDeleteAsync(key);
        }
    }
}
