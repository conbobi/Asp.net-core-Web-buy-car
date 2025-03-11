using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASC.Tests.TestUtilities
{
    public class FakeSession : ISession
    {
        public bool IsAvailable => true; // Giả lập luôn có sẵn session
        public string Id { get; } = Guid.NewGuid().ToString();

        private Dictionary<string, byte[]> sessionFactory = new Dictionary<string, byte[]>();
        //---------------
        private Dictionary<string, byte[]> _sessionStorage = new Dictionary<string, byte[]>();

        public bool TryGetValue(string key, out byte[] value) => _sessionStorage.TryGetValue(key, out value);

        public void Set(string key, byte[] value) => _sessionStorage[key] = value;

        public void Remove(string key) => _sessionStorage.Remove(key);

        public IEnumerable<string> Keys => _sessionStorage.Keys;

        public void SetString(string key, string value) => _sessionStorage[key] = Encoding.UTF8.GetBytes(value);

        public string GetString(string key)
        {
            return _sessionStorage.TryGetValue(key, out byte[] data)
                ? Encoding.UTF8.GetString(data)
                : null;
        }

        public void Load() { }
        public void Commit() { }
        //----------------
        public void Clear()
        {
            sessionFactory.Clear();
        }

        public Task CommitAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask; // Không làm gì cả, chỉ trả về Task hoàn thành
        }

        public Task LoadAsync(CancellationToken cancellationToken = default)
        {
            return Task.CompletedTask; // Không làm gì cả, chỉ trả về Task hoàn thành
        }

    }
}
