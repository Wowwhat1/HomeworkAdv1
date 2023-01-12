// See https://aka.ms/new-console-template for more information
using Song;

int numSongs = int.Parse(Console.ReadLine());

List<Song.Song> songs = new List<Song.Song>();

for (int i = 0; i < numSongs; i++)
{
    string[] data = Console.ReadLine().Split("_");

    string type = data[0];
    string name = data[1];
    string time = data[2];

    Song.Song song = new Song.Song();

    song.TypeList = type;
    song.Name = name;
    song.Time = time;

    songs.Add(song);
}

string typeList = Console.ReadLine();

if (typeList == "all")
{
    foreach (Song.Song song in songs)
    {
        Console.WriteLine(song.Name);
    }
}
else
{
    foreach (Song.Song song in songs)
    {
        if (song.TypeList == typeList)
        {
            Console.WriteLine(song.Name);
        }
    } 
}