using System.Collections.Generic;

namespace Domain
{
    public class ThreadSafeMap<TKey, TValue>
    {

        #region Constructors

        public ThreadSafeMap()
        {
            Map = new Dictionary<TKey, TValue>();
        }

        #endregion

        #region Properties

        public int Count { get { return Map.Count; } }

        public TValue this[TKey key]
        {
            get { return GetValue(key); }
            set { SetValue(key, value); }
        }

        private Dictionary<TKey, TValue> Map { get; set; }

        #endregion

        #region Public Methods

        public void Add(TKey key, TValue value)
        {
            // guard clause - invalid input
            if (value == null)
            {
                return;
            }

            lock (Map)
            {
                Map.Add(key, value);
            }
        }

        public void Clear()
        {
            lock (Map)
            {
                Map.Clear();
            }
        }

        public bool ContainsKey(TKey key)
        {
            lock (Map)
            {
                return Map.ContainsKey(key);
            }
        }

        public bool ContainsValue(TValue value)
        {
            // guard clause - invalid value
            if (value == null)
            {
                return false;
            }

            lock (Map)
            {
                return Map.ContainsValue(value);
            }
        }

        public bool Remove(TKey key)
        {
            lock (Map)
            {
                return Map.Remove(key);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            lock (Map)
            {
                return Map.TryGetValue(key, out value);
            }
        }

        #endregion

        #region Helper Methods

        private TValue GetValue(TKey key)
        {
            lock (Map)
            {
                TValue foundValue;
                Map.TryGetValue(key, out foundValue);
                return foundValue;
            }
        }

        private void SetValue(TKey key, TValue newValue)
        {
            lock (Map)
            {
                Map[key] = newValue;
            }
        }

        #endregion

    }
}
