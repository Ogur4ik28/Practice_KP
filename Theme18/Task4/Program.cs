using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task4
{
    class MusicCatalog
    {
        Hashtable catalog = new Hashtable();

        public void AddDisk(string diskName)
        {
            if (!catalog.ContainsKey(diskName))
            {
                catalog.Add(diskName, new ArrayList());
                Console.WriteLine($"Диск '{diskName}' успешно добавлен.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' уже существует в каталоге.");
            }
        }

        public void RemoveDisk(string diskName)
        {
            if (catalog.ContainsKey(diskName))
            {
                catalog.Remove(diskName);
                Console.WriteLine($"Диск '{diskName}' успешно удален из каталога.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' не найден в каталоге.");
            }
        }

        public void AddSong(string diskName, string songName)
        {
            if (catalog.ContainsKey(diskName))
            {
                ArrayList songs = (ArrayList)catalog[diskName];
                songs.Add(songName);
                Console.WriteLine($"Песня '{songName}' успешно добавлена на диск '{diskName}'.");
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' не найден в каталоге.");
            }
        }

        public void RemoveSong(string diskName, string songName)
        {
            if (catalog.ContainsKey(diskName))
            {
                ArrayList songs = (ArrayList)catalog[diskName];
                if (songs.Contains(songName))
                {
                    songs.Remove(songName);
                    Console.WriteLine($"Песня '{songName}' успешно удалена с диска '{diskName}'.");
                }
                else
                {
                    Console.WriteLine($"Песня '{songName}' не найдена на диске '{diskName}'.");
                }
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' не найден в каталоге.");
            }
        }

        public void ShowCatalog()
        {
            if (catalog.Count == 0)
            {
                Console.WriteLine("Каталог пуст.");
            }
            else
            {
                Console.WriteLine("Содержимое каталога:");
                foreach (DictionaryEntry disk in catalog)
                {
                    Console.WriteLine($"Диск: {disk.Key}");
                    Console.WriteLine("Песни:");
                    ArrayList songs = (ArrayList)disk.Value;
                    foreach (string song in songs)
                    {
                        Console.WriteLine($"- {song}");
                    }
                }
            }
        }

        public void ShowDiskContent(string diskName)
        {
            if (catalog.ContainsKey(diskName))
            {
                Console.WriteLine($"Содержимое диска '{diskName}':");
                ArrayList songs = (ArrayList)catalog[diskName];
                foreach (string song in songs)
                {
                    Console.WriteLine($"- {song}");
                }
            }
            else
            {
                Console.WriteLine($"Диск '{diskName}' не найден в каталоге.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddDisk("CD1");
            catalog.AddSong("CD1", "Песня 1");
            catalog.AddSong("CD1", "Песня 2");

            catalog.AddDisk("CD2");
            catalog.AddSong("CD2", "Песня A");
            catalog.AddSong("CD2", "Песня B");

            catalog.ShowCatalog();
            catalog.ShowDiskContent("CD1");
            catalog.ShowDiskContent("CD3");

            catalog.RemoveSong("CD1", "Песня 1");
            catalog.RemoveDisk("CD2");

            catalog.ShowCatalog();

            Console.ReadKey();
        }
    }
}
