using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    class Playlist
    {
        private List<Song> listSongs;
        private int currentIndex;

        public Playlist()
        {
            listSongs = new List<Song>();
            currentIndex = 0;
        }
        public Song CurrentSong()
        {
            if (listSongs.Count > 0)
                return listSongs[currentIndex];
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void AddSong(Song song)
        {
            if (song.Equals(default(Song)))
                throw new ArgumentNullException("song", "Аудиозапись не может быть пустой.");
            listSongs.Add(song);
        }
        public void AddSong(string author, string title, string filename)
        {
            if (string.IsNullOrEmpty(author))
                throw new ArgumentException("Поле 'Автор' не может быть пустым.");

            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Поле 'Название' не может быть пустым.");

            if (string.IsNullOrEmpty(filename))
                throw new ArgumentException("Поле 'Имя файла' не может быть пустым.");

            Song song = new Song(author, title, filename);
            listSongs.Add(song);
        }
        public void NextSong()
        {
            if (listSongs.Count > 0)
            {
                currentIndex++;
                if (currentIndex >= listSongs.Count)
                    currentIndex = 0;
            }
            else
            {
                throw new InvalidOperationException("Невозможно перейти к следующей аудиозаписи для пустого плейлиста!");
            }
        }

        public void PreviousSong()
        {
            if (listSongs.Count > 0)
            {
                currentIndex--;
                if(currentIndex < 0)
                    currentIndex = listSongs.Count - 1;
            }
            else
            {
                throw new InvalidOperationException("Невозможно перейти к предыдущей аудиозаписи для пустого плейлиста!");
            }
        }
        public void GoToSong(int index)
        {
            if (index < 0 || index >= listSongs.Count)
                throw new ArgumentOutOfRangeException("index", "Неверный индекс аудиозаписи.");

            currentIndex = index;
        }
        public void GoToStart()
        {
            if (listSongs.Count > 0)
                currentIndex = 0;
            else
                throw new InvalidOperationException("Невозможно перейти к началу плейлиста для пустого плейлиста!");
        }
        public void RemoveSong(int index)
        {
            if (index < 0 || index >= listSongs.Count)
                throw new ArgumentOutOfRangeException("index", "Неверный индекс аудиозаписи для удаления.");

            listSongs.RemoveAt(index);
            if (currentIndex >= listSongs.Count)
                currentIndex = listSongs.Count - 1;
        }

        public int RemoveSong(string title)
        {

            if (string.IsNullOrEmpty(title))
                throw new ArgumentException("Поле 'Название' не может быть пустым.");

            int removedCount = listSongs.RemoveAll(song => song.Title == title);
            if (currentIndex >= listSongs.Count)
                currentIndex = listSongs.Count - 1;
            return removedCount;
        }

        public void ClearPlaylist()
        {
            listSongs.Clear();
            currentIndex = 0;
        }

        public void PlaySong(ListBox listBox, Label label)
        {
            if (listBox.Items.Count == 0)
            {
                throw new InvalidOperationException("Невозможно включить пустой плейлист!");
            }
            else
            {
                label.Text = listBox.Items[0].ToString();
            }
        }
        public void StopSong(ListBox listBox, Label label)
        {
            if (listBox.Items.Count == 0)
            {
                throw new InvalidOperationException("Невозможно поставить на паузу пустой плейлист!");
            }
            else
            {
                label.Text = "Пауза";
            }
        }
        public List<Song> GetSongs()
        {
            return listSongs;
        }
    }
}
