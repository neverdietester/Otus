using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    public class OtusDictionary
    {
        private const int InitialCapacity = 32;
        private Entry[] entries;
        private int size;

        public OtusDictionary()
        {
            entries = new Entry[InitialCapacity];
            size = 0;
        }

        public void Add(int key, string value)
        {
            if (value == null)
            {
                throw new ArgumentException("Null value is not allowed.");
            }

            if (size >= entries.Length)
            {
                // Увеличиваем размер массива, если надо
                Resize();
            }

            int index = GetIndex(key);

            if (entries[index] == null)
            {
                entries[index] = new Entry(key, value);
                size++;
            }
            else
            {
                // Коллизия, ищем новый индекс
                int newIndex = FindNextIndex(index);
                entries[newIndex] = new Entry(key, value);
                size++;
            }
        }

        public string Get(int key)
        {
            int index = GetIndex(key);

            while (entries[index] != null)
            {
                if (entries[index].Key == key)
                {
                    return entries[index].Value;
                }

                index = (index + 1) % entries.Length;
            }

            return null;
        }

        private void Resize()
        {
            Entry[] newEntries = new Entry[entries.Length * 2];

            foreach (Entry entry in entries)
            {
                if (entry != null)
                {
                    int newIndex = GetIndex(entry.Key, newEntries.Length);
                    newEntries[newIndex] = entry;
                }
            }

            entries = newEntries;
        }

        private int GetIndex(int key)
        {
            return GetIndex(key, entries.Length);
        }

        private int GetIndex(int key, int length)
        {
            return Math.Abs(key) % length;
        }

        private int FindNextIndex(int index)
        {
            do
            {
                index = (index + 1) % entries.Length;
            } while (entries[index] != null);

            return index;
        }
    }
}
