using POO_C_.Interfaces;

namespace POO_C_.Models;

internal class Album : IRatable
{
    private List<Music> musics = new();
    private List<Evaluation> rates = new();
    public List<Music> Musics => musics;

    public string Name { get; }
    public int Duration => musics.Sum(music => music.Duration);

    public Album(string name)
    {
        Name = name;
    }
    
    public double Average
    {
        get
        {
            if (musics.Count == 0) return 0;
            else return rates.Average(r => r.Rate);
        }
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void DisplayMusics()
    {
        Console.WriteLine($"Lista de músicas do álbum {Name}:\n");
        foreach (Music music in musics)
        {
            Console.WriteLine($"Music: {music.Title}");
        }
        Console.WriteLine($"Duração do álbum {Name}: {Duration}s");
    }

    public void Rate(Evaluation rate)
    {
        rates.Add(rate);
    }
}